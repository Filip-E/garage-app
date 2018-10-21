import React from "react";
import {Component} from "react";
import ProductsContainer from "../containers/ProductsContainer";

class RetroVintageProductsWrapper extends Component{
    render(){
        return(
            <ProductsContainer pageTitle="Retro Vintage Stuff" productCategory="Retro_Vintage"/>
        )
    }
}

export default RetroVintageProductsWrapper;