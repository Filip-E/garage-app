import React from "react";
import {Component} from "react";
import ProductsContainer from "../containers/ProductsContainer";
import MainCategories from "../utils/MainCategories";

class CarsProductsWrapper extends Component{
    render(){
        return(
            <ProductsContainer pageTitle="Cars" productCategory={MainCategories.CARS}/>
        )
    }
}

export default CarsProductsWrapper;