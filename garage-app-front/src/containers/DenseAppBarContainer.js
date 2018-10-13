import React from "react";
import {Component} from "react";
import fetchProducts from "../actions/productActions";
import {connect} from "react-redux";
import DenseAppBar from "../components/DenseAppBar";


class DenseAppBarContainer extends Component {
    componentDidMount() {
        this.props.fetchProducts();
    }

    render() {
        return(<DenseAppBar auth={this.props.auth}/>)
    }
}

const mapStateToProps = (state) => {
    return {
        auth: state.auth
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProducts: () => {
            dispatch(fetchProducts());
        },
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(DenseAppBarContainer);