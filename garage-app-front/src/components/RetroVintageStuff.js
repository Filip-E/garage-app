import {Component} from "react";
import React from "react";
import ProductCard from "./ProductCard";

class RetroVintageStuff extends Component {
    render() {
        console.log(this.props.products);
        return (
            <div>
                <h1>Retro Vintage</h1>
                <ul>
                    <li>
                        {this.props.products.map(product => {
                            return (
                                <ProductCard product={product}/>
                            )
                        })}
                    </li>
                </ul>
            </div>
        )
    }
}

export default RetroVintageStuff;