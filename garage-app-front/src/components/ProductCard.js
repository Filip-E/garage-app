import React, {Component} from "react";
import Grid from "@material-ui/core/Grid/Grid";
import Card from "@material-ui/core/Card/Card";
import CardContent from "@material-ui/core/CardContent/CardContent";
import Typography from "@material-ui/core/Typography/Typography";
import AdminCardActionsContainer from "../containers/AdminCardActionsContainer";
import withStyles from "@material-ui/core/styles/withStyles";

const styles = {
    card: {
        minWidth: 275,
    }
};

class ProductCard extends Component {
    constructor(props) {
        super(props);
        this.renderCategories = this.renderCategories.bind(this);
    }

    renderCategories() {
        let renderResult = [];
        let categories = this.props.categories;
        if (categories[0] !== "Retro_Vintage") {
            renderResult.push(<Typography key="titleCategoriesList"><br/> Categories: </Typography>);
            for (let i = 1; i < categories.length; i++) {
                console.log(categories[i]);
                renderResult.push(<Typography key={categories[i]} component="p">{categories[i]}</Typography>)
            }
        }
        return (renderResult);
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
                        <Typography gutterBottom variant="title">
                            {this.props.product.Name}
                        </Typography>
                        <Typography component="p">
                            Prijs: {this.props.product.Price} <br/>
                            Stock: {this.props.product.Stock} <br/>
                        </Typography>
                        {this.renderCategories()}
                    </CardContent>
                    {actions}
                </Card>
            </Grid>
        )
    }
}

export default withStyles(styles)(ProductCard);