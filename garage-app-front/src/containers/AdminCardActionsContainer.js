import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import AdminCardActionsComponent from "../components/AdminCardActionsComponent";

class AdminCardActionsContainer extends Component{

    render(){
        return(
            <AdminCardActionsComponent/>
        )
    }
}
const mapStateToProps = (state) => {
    return {

    }
};

const mapDispatchToProps = dispatch => {
    return {

    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(AdminCardActionsContainer));