import React, {Component} from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import DialogTitle from '@material-ui/core/DialogTitle';
import DialogContent from '@material-ui/core/DialogContent';
import DialogActions from '@material-ui/core/DialogActions';
import withMobileDialog from '@material-ui/core/withMobileDialog';
import Dialog from '@material-ui/core/Dialog';
import DialogContentText from "@material-ui/core/DialogContentText/DialogContentText";

class Login extends Component {

    render() {
        return (
            <Dialog
                open
                fullScreen={this.props.fullScreen}>
                    <DialogTitle>Log in</DialogTitle>
                    <DialogContent>
                        <DialogContentText>
                            {this.props.errorText}
                        </DialogContentText>
                        <TextField
                            autoFocus
                            margin="dense"
                            id="username"
                            label="username"
                            type="string"
                            fullWidth
                            onChange={this.props.handleChange}
                        />
                        <TextField
                            margin="dense"
                            id="password"
                            label="password"
                            type="password"
                            fullWidth
                            onChange={this.props.handleChange}
                        />
                    </DialogContent>
                    <DialogActions>
                        <Button onClick={this.props.cancel}>
                            Cancel
                        </Button>
                        <Button onClick={this.props.submit} color="primary">
                            Log in
                        </Button>
                    </DialogActions>
            </Dialog>
        );
    }
}

export default withMobileDialog()(Login);