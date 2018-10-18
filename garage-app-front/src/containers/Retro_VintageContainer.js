import React from "react";
import {Component} from "react";
import {addProduct, fetchProductsByCategoryAndFilter, handleClickOpenDialog, handleClose} from "../actions/productActions";
import {connect} from "react-redux";
import Loading from "../components/Loading";
import RetroVintageStuff from "../components/RetroVintageStuff";
import {withRouter} from "react-router-dom";


class Retro_VintageContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            price: 0,
            stock: 0,
        };
        this.handleChange = this.handleChange.bind(this);
        this.submit = this.submit.bind(this);
    }

    componentDidMount() {
        this.props.fetchProductsByCategoryAndFilter('Retro_Vintage');
    }

    handleChange(event) {
        const id = event.target.id;
        this.setState({[id]: event.target.value});
    }

    submit(event) {
        event.preventDefault();
        this.props.addProduct({
            Name: this.state.name,
            Price: this.state.price,
            Stock: this.state.stock,
            CategoryTypes: [
                "Retro_Vintage"
            ]
        }, this.props.token);
    }

    render() {
        if (this.props.fetched) {
            if (this.props.response !== null) {
                if (this.props.response.status === 201) {
                    this.props.fetchProductsByCategoryAndFilter('Retro_Vintage');
                }
            }
            if (this.props.error !== null) {
                if (this.props.error.status === 500) {
                    return (
                        <p>oeps, er is iets mis gegaan</p>
                    )
                } else {
                    return (
                        <RetroVintageStuff
                            products={this.props.products}
                            token={this.props.token}
                            submit={this.submit}
                            open={this.props.open}
                            handleChange={this.handleChange}
                            handleClickOpen={this.props.handleClickOpenDialog}
                            handleClose ={this.props.handleClose}
                            error = {this.props.error.response.data.Message}
                        />
                    )
                }
            } else {
                return (
                    <RetroVintageStuff
                        products={this.props.products}
                        token={this.props.token}
                        submit={this.submit}
                        open={this.props.open}
                        handleChange={this.handleChange}
                        handleClickOpen={this.props.handleClickOpenDialog}
                        handleClose ={this.props.handleClose}
                        error=""
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
        token: state.auth.token
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProductsByCategoryAndFilter: (category) => {
            dispatch(fetchProductsByCategoryAndFilter(category));
        },
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

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(Retro_VintageContainer));