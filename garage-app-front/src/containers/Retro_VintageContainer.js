import React, {Component} from "react";
import {fetchProductsByCategoryAndFilter, handleClickOpenDialog} from "../actions/productActions";
import {connect} from "react-redux";
import Loading from "../components/Loading";
import RetroVintageStuff from "../components/RetroVintageStuff";
import {withRouter} from "react-router-dom";


class Retro_VintageContainer extends Component {

    componentDidMount() {
        this.props.fetchProductsByCategoryAndFilter('Retro_Vintage');
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
                            handleClickOpen={this.props.handleClickOpenDialog}
                        />
                    )
                }
            } else {
                return (
                    <RetroVintageStuff
                        products={this.props.products}
                        token={this.props.token}
                        handleClickOpen={this.props.handleClickOpenDialog}
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
        handleClickOpenDialog: () =>{
            dispatch(handleClickOpenDialog())
        },
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(Retro_VintageContainer));