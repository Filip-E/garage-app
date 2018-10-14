import React from "react";
import {Component} from "react";
import {fetchProductsByCategoryAndFilter} from "../actions/productActions";
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
            if (this.props.error) {
                return (
                    <p>oeps, er is iets mis gegaan</p>
                )
            } else {
                return (
                    <RetroVintageStuff
                        products={this.props.products}
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
        fetched: state.product.fetched
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProductsByCategoryAndFilter: (category) => {
            dispatch(fetchProductsByCategoryAndFilter(category));
        }
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(Retro_VintageContainer));