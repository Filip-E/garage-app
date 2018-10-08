import React, { Component } from "react";
import PropTypes from "prop-types";
import CircularProgress from "@material-ui/core/CircularProgress";
import Grid from "@material-ui/core/es/Grid/Grid";
import withStyles from "@material-ui/core/es/styles/withStyles";

const styles = () => ({
    root: {
        minHeight: "100vh",
        margin: "0px"
    }
});

class Loading extends Component {
    render() {
        const classes = this.props;
        return (
            <Grid
                className={classes.root}
                container
                spacing={24}
                justify="center"
                alignItems="center"
            >
                <Grid item xs={12}>
                    <CircularProgress id="circularProgress" />
                </Grid>
            </Grid>
        );
    }
}

Loading.propTypes = {
    classes: PropTypes.object.isRequired
};

export default withStyles(styles)(Loading);
