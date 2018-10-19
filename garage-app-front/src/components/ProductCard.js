import React, {Component} from "react";
import Grid from "@material-ui/core/Grid/Grid";
import Card from "@material-ui/core/Card/Card";
import withStyles from "@material-ui/core/es/styles/withStyles";
import CardContent from "@material-ui/core/CardContent/CardContent";
import Typography from "@material-ui/core/Typography/Typography";
import AdminCardActionsContainer from "../containers/AdminCardActionsContainer";

const styles = {
    card: {
        minWidth: 275,
    }
};

class ProductCard extends Component {

    render() {
        let actions;
        if(this.props.token !== ''){
            actions = (<AdminCardActionsContainer productId={this.props.product.Id}/>);
        }else{
            actions = (<div/>);
        }
        return (
            <Grid item>
                <Card>
                    <CardContent>
                        <Typography gutterBottom variant="title" component="body2">
                            {this.props.product.Name}
                        </Typography>
                        <Typography component="p">
                            Prijs: {this.props.product.Price} <br/>
                            Stock: {this.props.product.Stock} <br/>
                        </Typography>
                    </CardContent>
                    {actions}
                </Card>
            </Grid>
        )
    }
}

export default withStyles(styles)(ProductCard);