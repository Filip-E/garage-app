import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import ProductCard from "../components/ProductCard";
import {fetchProductCategories} from "../actions/CategoryActions";
import MainCategories from "../utils/MainCategories";
import {fetchCarSpecifications} from "../actions/CarActions";

const mapStateToProps = (state) => {
    return {
        token: state.auth.token,
        categories: state.category.types,
        response: state.category.response,
        specifications: state.car.specifications
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProductCategories: (productId) => {
            dispatch(fetchProductCategories(productId));
        },
        fetchCarSpecifications: (productId) =>{
            dispatch(fetchCarSpecifications(productId));
        }
    };
};

class ProductCardContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            categories: [],
            specifications: this.props.specifications
        }
    }

    componentDidMount() {
        if (this.props.productCategory === MainCategories.PARTS) {
            this.props.fetchProductCategories(this.props.product.Id);
        } else if (this.props.productCategory === MainCategories.CARS) {
            this.props.fetchCarSpecifications(this.props.product.Id);
        }
    }

    componentDidUpdate(prevProps, prevState, snapshot) {
        if (this.props.productCategory === MainCategories.PARTS) {
            if (prevProps !== this.props) {
                // check if the categories in the store are the ones for the productCard that is currently rendering
                let categoryCallUrl = this.props.response.config.url.split("/");
                let categoryCallUrlId = parseInt(categoryCallUrl[categoryCallUrl.length - 1], 10);
                if (this.props.product.Id === categoryCallUrlId) {
                    this.setState({categories: this.props.categories});
                }
            }
        } else if (this.props.productCategory === MainCategories.CARS) {
            if(prevProps.specifications !== this.props.specifications){
                this.setState({specifications: this.props.specifications})
            }
        }
    }


    render() {
        if (this.props.productCategory === MainCategories.CARS) {
            return (
                <ProductCard
                    token={this.props.token}
                    product={this.props.product}
                    productCategory={this.props.productCategory}
                    // categories={this.state.categories}
                    specifications={this.state.specifications}
                />
            )
        } else {
            return (
                <ProductCard
                    token={this.props.token}
                    product={this.props.product}
                    productCategory={this.props.productCategory}
                    categories={this.state.categories}
                />
            )
        }


    }
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ProductCardContainer));