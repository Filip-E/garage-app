import React, {Component} from 'react';
import Dialog from "@material-ui/core/Dialog/Dialog";
import DialogTitle from "@material-ui/core/DialogTitle/DialogTitle";
import DialogContentText from "@material-ui/core/DialogContentText/DialogContentText";
import DialogContent from "@material-ui/core/DialogContent/DialogContent";
import TextField from "@material-ui/core/TextField/TextField";
import DialogActions from "@material-ui/core/DialogActions/DialogActions";
import Button from "@material-ui/core/Button/Button";

class AddCategoryDialog extends Component {
    render() {
        return (
            <Dialog
                open={this.props.open}
                onClose={this.props.handleClose}
                aria-labelledby="form-dialog-title"
            >
                <DialogTitle id="form-dialog-title">Maak een nieuwe categorie</DialogTitle>
                <DialogContentText>
                    {this.props.error}
                </DialogContentText>
                <DialogContent>
                    <TextField
                        margin="dense"
                        id="category"
                        label="category"
                        type="text"
                        fullWidth
                        onChange={this.props.handleChange}
                    />
                </DialogContent>
                <DialogActions>
                    <Button onClick={this.props.handleClose} color="secondary">
                        Cancel
                    </Button>
                    <Button onClick={this.props.submit} color="primary">ADD</Button>
                </DialogActions>
            </Dialog>
        );
    }
}

export default AddCategoryDialog;