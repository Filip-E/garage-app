import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import AdminCardActionsComponent from "../components/AdminCardActionsComponent";
import {deleteProduct, fetchProductsByCategoryAndFilter} from "../actions/productActions";

class AdminCardActionsContainer extends Component {
    constructor(props) {
        super(props);
        this.deleteProduct = this.deleteProduct.bind(this);
    }

    deleteProduct() {
        console.log(this.props);
        this.props.deleteProductDispatch(this.props.productId, this.props.token)
    }

    render() {
        if (this.props.response !== null) {
            if (this.props.response.status === 204) {
                this.props.fetchProductsByCategoryAndFilter('Retro_Vintage');
            }
        }
        return (
                <AdminCardActionsComponent
                    deleteProduct={this.deleteProduct}
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
        fetchProductsByCategoryAndFilter: (category) =>{
            dispatch(fetchProductsByCategoryAndFilter(category));
        }
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(AdminCardActionsContainer));