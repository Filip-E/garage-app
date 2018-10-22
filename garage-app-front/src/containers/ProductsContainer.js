import React, {Component} from "react";
import {
    fetchProducts,
    fetchProductsAndFilter,
    handleClickOpenDialog,
    makeEditDialogFalse,
    setProductId
} from "../actions/productActions";
import {connect} from "react-redux";
import Loading from "../components/Loading";
import ProductsComponent from "../components/ProductsComponent";
import {withRouter} from "react-router-dom";


class ProductsContainer extends Component {

    componentDidMount() {
        if(this.props.token){
            this.props.fetchProducts(this.props.productCategory);
        }else{
            this.props.fetchProductsAndFilter(this.props.productCategory);
        }
    }
    componentDidUpdate(prevProps, prevState, snapshot) {
        if(prevProps.token !== this.props.token){
            if(this.props.token){
                this.props.fetchProducts(this.props.productCategory);
            }else{
                this.props.fetchProductsAndFilter(this.props.productCategory);
            }
        }
    }
    render() {
        if (this.props.fetched) {
            if (this.props.response !== null) {
                if (this.props.response.status === 201) {
                    console.log("201 fetch");
                    this.props.fetchProducts(this.props.productCategory);
                }
            }
            if (this.props.error !== null) {
                if (this.props.error.status === 500) {
                    return (
                        <p>oeps, er is iets mis gegaan</p>
                    )
                } else {
                    return (
                        <ProductsComponent
                            products={this.props.products}
                            token={this.props.token}
                            handleClickOpen={this.props.handleClickOpenDialog}
                            editDialog={this.props.editDialogState}
                            pageTitle={this.props.pageTitle}
                            productCategory={this.props.productCategory}
                        />
                    )
                }
            } else {
                return (
                    <ProductsComponent
                        products={this.props.products}
                        token={this.props.token}
                        handleClickOpen={this.props.handleClickOpenDialog}
                        editDialog={this.props.editDialogState}
                        pageTitle={this.props.pageTitle}
                        productCategory={this.props.productCategory}
                    />
                )
            }
        } else {
            return (
                <Loading/>
            )
        }
    }
}

const mapStateToProps = (state) => {
    return {
        products: state.product.products,
        error: state.product.error,
        fetched: state.product.fetched,
        response: state.product.response,
        open: state.product.open,
        token: state.auth.token,
        editDialogState: state.product.editDialogState
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProducts: (category) =>{
            dispatch(fetchProducts(category));
        },
        fetchProductsAndFilter: (category) => {
            dispatch(fetchProductsAndFilter(category));
        },
        handleClickOpenDialog: () =>{
            dispatch(makeEditDialogFalse());
            dispatch(handleClickOpenDialog());
            dispatch(setProductId(1));
        },
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ProductsContainer));