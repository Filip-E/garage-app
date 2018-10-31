import React, {Component} from "react";
import Grid from "@material-ui/core/Grid/Grid";
import Card from "@material-ui/core/Card/Card";
import CardContent from "@material-ui/core/CardContent/CardContent";
import Typography from "@material-ui/core/Typography/Typography";
import AdminCardActionsContainer from "../containers/AdminCardActionsContainer";
import withStyles from "@material-ui/core/styles/withStyles";
import MainCategories from "../utils/MainCategories";

const styles = {
    card: {
        minWidth: 275,
    }
};

class ProductCard extends Component {
    constructor(props) {
        super(props);
        this.renderCategories = this.renderCategories.bind(this);
        this.renderSpecifications= this.renderSpecifications.bind(this);
    }

    renderCategoriesOrSpecifications(){
        if(this.props.productCategory === MainCategories.PARTS){
            return this.renderCategories();
        } else if(this.props.productCategory === MainCategories.CARS){
            return this.renderSpecifications();
        }
    }

    renderCategories() {
        let renderResult = [];
        let categories = this.props.categories;
        if (categories[0] !== "Retro_Vintage") {
            renderResult.push(<Typography key="titleCategoriesList" variant="h6" ><br/> Categories </Typography>);
            for (let i = 1; i < categories.length; i++) {
                renderResult.push(<Typography key={categories[i]} component="p">{categories[i]}</Typography>)
            }
        }
        return (renderResult);
    }

    renderSpecifications() {
        let renderResult = [];
        let specifications = this.props.specifications;
        renderResult.push(<Typography key="titleSpecificationsList" variant="h6" ><br/> Specifications </Typography>);
        for (let i = 0; i < specifications.length; i++) {
            renderResult.push(<Typography key={specifications[i].Id} component="p">{specifications[i].SpecificationType}: {specifications[i].Value}</Typography>)
        }
        return(renderResult);
    }

    render() {
        let actions;
        if (this.props.token !== '') {
            actions = (<AdminCardActionsContainer productId={this.props.product.Id}
                                                  productCategory={this.props.productCategory}/>);
        } else {
            actions = (<div/>);
        }

        return (
            <Grid item>
                <Card>
                    <CardContent>
                        <Typography gutterBottom variant="h5">
                            {this.props.product.Name}
                        </Typography>
                        <Typography component="p">
                            Prijs: {this.props.product.Price} <br/>
                            Stock: {this.props.product.Stock} <br/>
                        </Typography>
                        {this.renderCategoriesOrSpecifications()}
                    </CardContent>
                    {actions}
                </Card>
            </Grid>
        )
    }


}

export default withStyles(styles)(ProductCard);