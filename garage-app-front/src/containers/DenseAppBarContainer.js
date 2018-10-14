import React from "react";
import {Component} from "react";
import {connect} from "react-redux";
import DenseAppBar from "../components/DenseAppBar";
import {logOut} from "../actions/AuthActions";
import {withRouter} from "react-router-dom";


class DenseAppBarContainer extends Component {

    render() {
        return(<DenseAppBar auth={this.props.auth} logout={this.props.logout}/>)
    }
}

const mapStateToProps = (state) => {
    return {
        auth: state.auth
    }
};

const mapDispatchToProps = dispatch => {
    return {
        logout: () =>{
            dispatch(logOut())
        }
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(DenseAppBarContainer));