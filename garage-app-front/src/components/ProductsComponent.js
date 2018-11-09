import React, {Component} from "react";
import Grid from '@material-ui/core/Grid';
import ProductCardContainer from "../containers/ProductCardContainer";
import AddIcon from '@material-ui/icons/Add';
import Button from "@material-ui/core/Button/Button";
import BasicDialogContainer from "../containers/BasicDialogContainer";
import withStyles from "@material-ui/core/styles/withStyles";
import AddCategoryDialogContainer from "../containers/AddCategoryDialogContainer";
import FilterContainer from "../containers/FilterContainer";
import Typography from "@material-ui/core/Typography/Typography";
import MainCategories from "../utils/MainCategories";

const styles = () => ({
    root: {
        flexGrow: 1,
    },
});

class ProductsComponent extends Component {
    render() {
        let actions;
        if (this.props.token !== '') {
            if (this.props.productCategory === MainCategories.PARTS) {
                actions = (
                    <div>
                        <Button mini variant="fab" color="primary" aria-label="Add" onClick={
                            this.props.handleClickOpen
                        }>
                            <AddIcon fontSize="small"/>
                        </Button>&nbsp;

                        <Button mini variant="fab" color="secondary" aria-label="Add" onClick={
                            this.props.handleOpenAddCategory
                        }>
                            <AddIcon fontSize="small"/>
                        </Button>
                    </div>);
            } else {
                actions = (
                    <div>
                        <Button mini variant="fab" color="primary" aria-label="Add" onClick={
                            this.props.handleClickOpen
                        }>
                            <AddIcon fontSize="small"/>
                        </Button>
                    </div>);
            }

        } else {
            actions = (<div/>);
        }
        return (
            <div>
                <Typography>
                    <h1>{this.props.pageTitle} {actions}</h1><br/>
                </Typography>
                <FilterContainer productCategory={this.props.productCategory}/>
                <Grid container spacing={24}>
                    {this.props.products.map(product => {
                        return (
                            <ProductCardContainer key={product.Name} product={product}
                                                  productCategory={this.props.productCategory}/>
                        )
                    })}
                </Grid>
                <BasicDialogContainer edit={this.props.editDialog} productCategory={this.props.productCategory}/>
                <AddCategoryDialogContainer
                    openDialogState={this.props.openAddCategoryDialogState}
                    handleClose={this.props.handleCloseAddCategory}
                />
            </div>
        )
    }
}

export default withStyles(styles)(ProductsComponent);