import {Component} from "react";
import React from "react";

class ProductCard extends Component {
    render() {
        console.log(this.props.product);
        return (
            <li>
                Naam: {this.props.product.Name} <br/>
                Prijs: {this.props.product.Price} <br/>
                Stock: {this.props.product.Stock} <br/>
            </li>
        )
    }
}

export default ProductCard;