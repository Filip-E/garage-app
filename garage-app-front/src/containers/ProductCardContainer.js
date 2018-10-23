import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import ProductCard from "../components/ProductCard";
import {fetchProductCategories} from "../actions/CategoryActions";

class ProductCardContainer extends Component{

    componentDidMount() {
        this.props.fetchProductCategories(this.props.product.Id);
    }


    render(){
        // don't render when product is null. don't know why this happens. see map in ProductsComponent.js
        if(this.props.product){
            return(
                <ProductCard token={this.props.token} product={this.props.product} productCategory={this.props.productCategory} categories={this.props.categories}/>
            )
        }else{
            return <div/>
        }

    }
}
const mapStateToProps = (state) => {
    return {
        token : state.auth.token,
        categories: state.category.types
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