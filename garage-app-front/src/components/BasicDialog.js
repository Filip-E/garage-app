import React from "react";
import {Component} from "react";
import Dialog from "@material-ui/core/Dialog/Dialog";
import DialogTitle from "@material-ui/core/DialogTitle/DialogTitle";
import DialogContentText from "@material-ui/core/DialogContentText/DialogContentText";
import DialogContent from "@material-ui/core/DialogContent/DialogContent";
import TextField from "@material-ui/core/TextField/TextField";
import DialogActions from "@material-ui/core/DialogActions/DialogActions";
import Button from "@material-ui/core/Button/Button";

class BasicDialog extends Component {
    test() {
        const array = [];
        let product = this.props.products[this.props.productId];
        for (let key in product) {
            if (product.hasOwnProperty(key)) {
                if (key !== "Id") {
                    array.push({[key]: product[key]})
                }
            }
        }
        return (array);
    }

    render() {
        // console.log("Id in component");
        // console.log(this.props.productId);
        return (
            <Dialog
                open={this.props.open}
                onClose={this.props.handleClose}
                aria-labelledby="form-dialog-title"
            >
                <DialogTitle id="form-dialog-title">Voeg een Retro-Vintage item toe</DialogTitle>
                <DialogContentText>
                    {this.props.error}
                </DialogContentText>
                <DialogContent>
                    {this.test().map((property) => {
                        let inputType = "";
                        // Object.keys(property)[0] => returns the key instead of the value of said key

                        // property is a javascript object
                        // do property[key] where key is the only one availble => the first one in the array returned by Object.keys
                        // check the type of property[key]
                        // change the inputType based on that
                        if (typeof(property[Object.keys(property)[0]]) === "string") {
                            inputType = "text";
                        } else if (typeof(property[Object.keys(property)[0]]) === "number") {
                            inputType = "number"
                        }
                        return (
                            <TextField
                                margin="dense"
                                id={Object.keys(property)[0]}
                                label={Object.keys(property)[0]}
                                type={inputType}
                                fullWidth
                                onChange={this.props.handleChange}
                            />
                        )
                    })
                    }
                </DialogContent>
                <DialogActions>
                    <Button onClick={this.props.handleClose} color="secondary">
                        Cancel
                    </Button>
                    <Button onClick={this.props.submit} color="primary">
                        Add
                    </Button>
                </DialogActions>
            </Dialog>
        )
    }
}

export default BasicDialog;