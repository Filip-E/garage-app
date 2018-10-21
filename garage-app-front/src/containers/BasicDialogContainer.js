import React from "react";
import {Component} from "react";
import {
    addProduct,
    handleClickOpenDialog,
    handleClose
} from "../actions/productActions";
import connect from "react-redux/es/connect/connect";
import BasicDialog from "../components/BasicDialog";


class BasicDialogContainer extends Component{
    constructor(props) {
        super(props);
        this.state = {
            Name: "",
            Price: 0,
            Stock: 0,
            Id:null,
        };
        this.handleChange = this.handleChange.bind(this);
        this.submit = this.submit.bind(this);
    }
    handleChange(event) {
        const id = event.target.id;
        this.setState({[id]: event.target.value});
    }

    submit(event) {
        event.preventDefault();
        this.props.addProduct({
            Name: this.state.Name,
            Price: this.state.Price,
            Stock: this.state.Stock,
            CategoryTypes: [
                "Retro_Vintage"
            ]
        }, this.props.token);
    }

    render(){
        return(
            // productId + edit needs to be set by the object calling <BasicDialogContainer/>
            <BasicDialog
            open={this.props.open}
            handleClose={this.props.handleClose}
            error={this.props.error}
            handleChange={this.handleChange}
            submit={this.submit}
            products={this.props.products}
            productId={this.props.productId}
            edit={this.props.edit}
            />
        );
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
        productId: state.product.storeProductId
    }
};

const mapDispatchToProps = dispatch => {
    return {
        addProduct: (productWithCategoryTypes, token) => {
            dispatch(addProduct(productWithCategoryTypes, token));
        },
        handleClickOpenDialog: () =>{
            dispatch(handleClickOpenDialog())
        },
        handleClose: () =>{
            dispatch(handleClose())
        }
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(BasicDialogContainer);