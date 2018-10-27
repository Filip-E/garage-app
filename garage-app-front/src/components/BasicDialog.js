import React from "react";
import {Component} from "react";
import Dialog from "@material-ui/core/Dialog/Dialog";
import DialogTitle from "@material-ui/core/DialogTitle/DialogTitle";
import DialogContentText from "@material-ui/core/DialogContentText/DialogContentText";
import DialogContent from "@material-ui/core/DialogContent/DialogContent";
import TextField from "@material-ui/core/TextField/TextField";
import DialogActions from "@material-ui/core/DialogActions/DialogActions";
import Button from "@material-ui/core/Button/Button";
import ExtensionDialogCategoriesContainer from "../containers/ExtensionDialogCategoriesContainer";

class BasicDialog extends Component {
    constructor(props) {
        super(props);
        this.renderButton = this.renderButton.bind(this);
        this.renderExtensionCategories = this.renderExtensionCategories.bind(this);
    }

    makePropertiesArray() {
        const array = [];
        let product = {};
        this.props.products.forEach((element) => {
            if (element.Id === this.props.productId) {
                product = element;
            }
        });
        for (let key in product) {
            if (product.hasOwnProperty(key)) {
                if (key !== "Id") {
                    array.push({[key]: product[key]})
                }
            }
        }
        return (array);
    }

    renderButton() {
        if (this.props.edit) {
            return (<Button onClick={this.props.submit} color="primary">EDIT</Button>)
        } else {
            return (<Button onClick={this.props.submit} color="primary">ADD</Button>)
        }
    }

    renderTitle() {
        let subject = "";
        if (this.props.productCategory === "Parts") {
            subject = "Part";
        } else {
            subject = "Retro-Vintage";
        }
        let title = "";
        if (this.props.edit) {
            title = "Pas een " + subject + " item aan";
        } else {
            title = "Voeg een " + subject + " item toe";
        }
        return (title);
    }

    renderExtensionCategories() {
        if (this.props.productCategory === "Parts") {
            return (<ExtensionDialogCategoriesContainer/>)
        }
    }

    render() {
        return (
            <Dialog
                open={this.props.open}
                onClose={this.props.handleClose}
                aria-labelledby="form-dialog-title"
            >
                <DialogTitle id="form-dialog-title">{this.renderTitle()}</DialogTitle>
                <DialogContentText>
                    {this.props.error}
                </DialogContentText>
                <DialogContent>
                    {this.makePropertiesArray().map((property) => {
                        let value = "";
                        if (this.props.edit) {
                            value = property[Object.keys(property)[0]];
                        }
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
                                key={Object.keys(property)[0]}
                                margin="dense"
                                id={Object.keys(property)[0]}
                                label={Object.keys(property)[0]}
                                type={inputType}
                                fullWidth
                                defaultValue={value}
                                onChange={this.props.handleChange}
                            />
                        )
                    })
                    }
                    {this.renderExtensionCategories()}
                </DialogContent>
                <DialogActions>
                    <Button onClick={this.props.handleClose} color="secondary">
                        Cancel
                    </Button>
                    {this.renderButton()}
                </DialogActions>
            </Dialog>
        )
    }
}

export default BasicDialog;