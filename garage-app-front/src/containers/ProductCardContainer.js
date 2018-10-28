import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import ProductCard from "../components/ProductCard";
import {fetchProductCategories} from "../actions/CategoryActions";

class ProductCardContainer extends Component{
    constructor(props){
        super(props);
        this.state ={
            categories : []
        }
    }
    componentDidMount() {
        this.props.fetchProductCategories(this.props.product.Id);
    }
    componentDidUpdate(prevProps,prevState,snapshot){
        if(prevProps !== this.props){
            // check if the categories in the store are the ones for the productCard that is currently rendering
            let categoryCallUrl = this.props.response.config.url.split("/");
            let categoryCallUrlId = parseInt(categoryCallUrl[categoryCallUrl.length - 1], 10);
            if(this.props.product.Id === categoryCallUrlId){
                this.setState({categories: this.props.categories});
            }
        }
    }


    render(){
        // todo if shit breaks uncomment this stuff
        // don't render when product is null. don't know why this happens. see map in ProductsComponent.js
        // if(this.props.product){
            return(
                <ProductCard
                    token={this.props.token}
                    product={this.props.product}
                    productCategory={this.props.productCategory}
                    categories={this.state.categories}
                />
            )
        // }else{
        //     return <div/>
        // }

    }
}
const mapStateToProps = (state) => {
    return {
        token : state.auth.token,
        categories: state.category.types,
        response: state.category.response
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProductCategories: (productId) => {
            dispatch(fetchProductCategories(productId));
        }
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ProductCardContainer));