import React from "react";
import {Component} from "react";
import {withRouter} from "react-router-dom";
import {connect} from "react-redux";
import ProductCard from "../components/ProductCard";

class AdminCardActionsContainer extends Component{

    render(){
        // don't render when product is null. don't know why this happens. see map in RetroVintageStuff.js
        if(this.props.product){
            return(
                <ProductCard token={this.props.token} product={this.props.product}/>
            )
        }else{
            return <div/>
        }

    }
}
const mapStateToProps = (state) => {
    return {
        token : state.auth.token
    }
};

const mapDispatchToProps = dispatch => {
    return {

    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(AdminCardActionsContainer));