import React from 'react';
import PropTypes from 'prop-types';
import {withStyles} from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
// import Typography from '@material-ui/core/Typography';
import IconButton from '@material-ui/core/IconButton';
import {Redirect, Route, Switch} from "react-router-dom";
import Home from "./Home";
import Retro_VintageStuff from "./Retro_VintageStuff";
import Service from "./Service";
import Parts from "./Parts";
import Contact from "./Contact";
import Cars from "./Cars";

// import MenuIcon from '@material-ui/icons/Menu';

const styles = {
    root: {
        flexGrow: 1,
    },
    menuButton: {
        marginLeft: -18,
        marginRight: 10,
    },
};

function DenseAppBar(props) {
    const {classes} = props;
    const retroVintage = "/retro_vintage";
    const home = "/";
    const service = "/service";
    const parts = "/parts";
    const cars = "/cars";
    const contact = "/contact";
    return (
        <div className={classes.root}>
            <AppBar position="static">
                <Toolbar variant="dense">
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={home}>
                        Home
                    </IconButton>
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={service}>
                        Service
                    </IconButton>
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={retroVintage}>
                        Retro / Vintage stuff
                    </IconButton>
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={parts}>
                        Parts
                    </IconButton>
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={cars}>
                        Cars
                    </IconButton>
                    <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={contact}>
                        Contact
                    </IconButton>
                    {/*<Typography variant="title" color="inherit">*/}
                    {/*Photos*/}
                    {/*</Typography>*/}
                </Toolbar>
            </AppBar>
            <Switch>
                <Route exact path={home} component={Home}/>
                <Route exact path={service} component={Service}/>
                <Route exact path={retroVintage} component={Retro_VintageStuff}/>
                <Route exact path={parts} component={Parts}/>
                <Route exact path={cars} component={Cars}/>
                <Route exact path={contact} component={Contact}/>
                <Redirect to={home}/>
            </Switch>
        </div>
    );
}

DenseAppBar.propTypes = {
    classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(DenseAppBar);
