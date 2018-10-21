import {Component} from "react";
import React from "react";
import CardActions from "@material-ui/core/CardActions/CardActions";
import Button from "@material-ui/core/Button/Button";
import EditIcon from '@material-ui/icons/Edit';
import DeleteIcon from '@material-ui/icons/Delete';

class AdminCardActionsComponent extends Component {
    render() {
        return (
            <CardActions>
                <Button variant="fab" color="secondary" aria-label="Edit" mini onClick={this.props.editProduct}>
                    <EditIcon fontSize="small"/>
                </Button>
                <Button variant="fab" aria-label="Delete" mini onClick={this.props.deleteProduct}>
                    <DeleteIcon fontSize="small"/>
                </Button>
            </CardActions>
        )
    }
}

export default AdminCardActionsComponent;