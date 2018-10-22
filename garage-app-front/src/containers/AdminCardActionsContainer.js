import React, {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import AdminCardActionsComponent from "../components/AdminCardActionsComponent";
import {
    deleteProduct,
    fetchProducts,
    handleClickOpenDialog,
    makeEditDialogTrue,
    setProductId
} from "../actions/productActions";

class AdminCardActionsContainer extends Component {
    constructor(props) {
        super(props);
        this.editProduct = this.editProduct.bind(this);
        this.deleteProduct = this.deleteProduct.bind(this);
    }
    editProduct(){
        this.props.prepareEditDialog(this.props.productId);
    }
    deleteProduct() {
        this.props.deleteProductDispatch(this.props.productId, this.props.token)
    }

    render() {
        // if (this.props.response !== null) {
        //     if (this.props.response.status === 204) {
        //         this.props.fetchProducts(this.props.productCategory);
        //     }
        // }
        return (
                <AdminCardActionsComponent
                    deleteProduct={this.deleteProduct}
                    editProduct={this.editProduct}
                />
        )
    }
}

const mapStateToProps = (state) => {
    return {
        token: state.auth.token,
        response: state.product.response
    }
};

const mapDispatchToProps = dispatch => {
    return {
        deleteProductDispatch: (productId, token) => {
            dispatch(deleteProduct(productId, token));
        },
        fetchProducts: (category) =>{
            dispatch(fetchProducts(category));
        },
        prepareEditDialog: (productId) =>{
            dispatch(makeEditDialogTrue());
            dispatch(setProductId(productId));
            dispatch(handleClickOpenDialog());
        },
        makeEditDialogTrue: () =>{
            dispatch(makeEditDialogTrue());
        },
        prepareAddDialog: () =>{
            dispatch(handleClickOpenDialog());
        },
        setProductId: (productId)=>{
            dispatch(setProductId(productId));
        }
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(AdminCardActionsContainer));