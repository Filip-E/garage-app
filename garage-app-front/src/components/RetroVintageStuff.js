import React, {Component} from "react";
import Grid from '@material-ui/core/Grid';
import withStyles from "@material-ui/core/es/styles/withStyles";
import ProductCardContainer from "../containers/ProductCardContainer";

const styles = () => ({
    root: {
        flexGrow: 1,
    },
});

class RetroVintageStuff extends Component {
    render() {

        return (
            <div>
                <h1>Retro Vintage</h1>
                <Grid container spacing={24}>
                    {this.props.products.map(product => {
                        return (
                            <ProductCardContainer key={product.Name} product={product}/>
                        )
                    })}
                </Grid>
            </div>
        )
    }
}

export default withStyles(styles)(RetroVintageStuff);