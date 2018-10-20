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
        // this.fillProductIdIfNoneExists = this.fillProductIdIfNoneExists.bind(this);
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

    // fillProductIdIfNoneExists(){
    //     if(this.state.Id === null){
    //         if(this.props.Id === null){
    //             console.log("props id null");
    //             console.log(this.props.products[0].Id);
    //             this.setState({Id: this.props.products[0].Id});
    //         }else{
    //             console.log("props is not null aka is injected");
    //             console.log(this.props.Id);
    //             this.setState({Id: this.props.Id});
    //         }
    //     }
    // }

    render(){
        // this.fillProductIdIfNoneExists();
        return(
            <BasicDialog
            open={this.props.open}
            handleClose={this.props.handleClose}
            error={this.props.error}
            handleChange={this.handleChange}
            submit={this.submit}
            products={this.props.products}
            productId={this.props.productId}
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
        token: state.auth.token
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