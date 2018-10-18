import React, {Component} from "react";
import Grid from '@material-ui/core/Grid';
import withStyles from "@material-ui/core/es/styles/withStyles";
import ProductCardContainer from "../containers/ProductCardContainer";
import AddIcon from '@material-ui/icons/Add';
import Button from "@material-ui/core/Button/Button";
import Dialog from "@material-ui/core/Dialog/Dialog";
import DialogActions from "@material-ui/core/DialogActions/DialogActions";
import TextField from "@material-ui/core/TextField/TextField";
import DialogContent from "@material-ui/core/DialogContent/DialogContent";
import DialogTitle from "@material-ui/core/DialogTitle/DialogTitle";
import DialogContentText from "@material-ui/core/DialogContentText/DialogContentText";

const styles = () => ({
    root: {
        flexGrow: 1,
    },
});

class RetroVintageStuff extends Component {
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
                <h1>Retro Vintage {actions}</h1>
                <Grid container spacing={24}>
                    {this.props.products.map(product => {
                        return (
                            <ProductCardContainer key={product.Name} product={product}/>
                        )
                    })}
                </Grid>
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
                        <TextField
                            autoFocus
                            margin="dense"
                            id="name"
                            label="naam"
                            type="text"
                            fullWidth
                            onChange={this.props.handleChange}
                        />
                        <TextField
                            margin="dense"
                            id="price"
                            label="prijs"
                            type="number"
                            fullWidth
                            onChange={this.props.handleChange}
                        />
                        <TextField
                            margin="dense"
                            id="stock"
                            label="stock"
                            type="number"
                            fullWidth
                            onChange={this.props.handleChange}
                        />
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
            </div>

        )
    }
}

export default withStyles(styles)(RetroVintageStuff);