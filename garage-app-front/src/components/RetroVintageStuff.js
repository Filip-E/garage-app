import React, {Component} from "react";
import Grid from '@material-ui/core/Grid';
import withStyles from "@material-ui/core/es/styles/withStyles";
import ProductCardContainer from "../containers/ProductCardContainer";
import AddIcon from '@material-ui/icons/Add';
import Button from "@material-ui/core/Button/Button";

const styles = () => ({
    root: {
        flexGrow: 1,
    },
});

class RetroVintageStuff extends Component {
    render() {


        let actions;
        if (this.props.token !== '') {
            actions = (<Button mini variant="fab" color="primary" aria-label="Add" onClick={() =>console.log('test')} >
                <AddIcon fontSize="small"/>
            </Button>);
        } else {
            actions = (<div/>);
        }
        return (
            <div>
                <h1>Retro Vintage {actions}</h1>
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