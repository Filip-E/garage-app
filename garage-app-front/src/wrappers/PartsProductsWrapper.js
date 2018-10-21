import React from "react";
import {Component} from "react";
import ProductsContainer from "../containers/ProductsContainer";

class PartsProductsWrapper extends Component{
    render(){
        return(
            <ProductsContainer pageTitle="Parts" productCategory="Parts"/>
        )
    }
}

export default PartsProductsWrapper;