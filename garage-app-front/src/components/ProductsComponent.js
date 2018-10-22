import React, {Component} from "react";
import Grid from '@material-ui/core/Grid';
import ProductCardContainer from "../containers/ProductCardContainer";
import AddIcon from '@material-ui/icons/Add';
import Button from "@material-ui/core/Button/Button";
import BasicDialogContainer from "../containers/BasicDialogContainer";
import withStyles from "@material-ui/core/styles/withStyles";

const styles = () => ({
    root: {
        flexGrow: 1,
    },
});

class ProductsComponent extends Component {
    render() {
        let actions;
        if (this.props.token !== '') {
            actions = (
                <Button mini variant="fab" color="primary" aria-label="Add" onClick={
                    this.props.handleClickOpen
                }>
                    <AddIcon fontSize="small"/>
                </Button>);
        } else {
            actions = (<div/>);
        }
        return (
            <div>
                <h1>{this.props.pageTitle} {actions}</h1>
                <Grid container spacing={24}>
                    {this.props.products.map(product => {
                        return (
                            <ProductCardContainer key={product.Name} product={product} />
                        )
                    })}
                </Grid>
                <BasicDialogContainer edit={this.props.editDialog} productCategory={this.props.productCategory}/>
            </div>
        )
    }
}

export default withStyles(styles)(ProductsComponent);