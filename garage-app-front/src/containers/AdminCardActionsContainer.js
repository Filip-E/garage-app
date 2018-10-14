import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import AdminCardActions from "../components/AdminCardActions";

class AdminCardActionsContainer extends Component{

    render(){
        return(
            <AdminCardActions/>
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