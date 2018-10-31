import React from "react";
import {Component} from "react";
import ProductsContainer from "../containers/ProductsContainer";
import MainCategories from "../utils/MainCategories";

class RetroVintageProductsWrapper extends Component{
    render(){
        return(
            <ProductsContainer pageTitle="Retro Vintage Stuff" productCategory={MainCategories.RETRO_VINTAGE}/>
        )
    }
}

export default RetroVintageProductsWrapper;