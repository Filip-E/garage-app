import React from "react";
import {Component} from "react";
import {connect} from "react-redux";
import DenseAppBar from "../components/DenseAppBar";
import {logOut} from "../actions/AuthActions";


class DenseAppBarContainer extends Component {

    render() {
        console.log(this.props.auth);
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
        logout: () =>{
            dispatch(logOut())
        }
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(DenseAppBarContainer);