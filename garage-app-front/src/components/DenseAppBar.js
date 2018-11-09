import React, {Component} from 'react';
import PropTypes from 'prop-types';
import {withStyles} from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Button from '@material-ui/core/Button';
import IconButton from '@material-ui/core/IconButton';
import {Redirect, Route, Switch} from "react-router-dom";
import Home from "./Home";
import Service from "./Service";
import Contact from "./Contact";
import LoginContainer from "../containers/LoginContainer";
import {getCookie} from "../utils/CookieManager";
import RetroVintageProductsWrapper from "../wrappers/RetroVintageProductsWrapper";
import PartsProductsWrapper from "../wrappers/PartsProductsWrapper";
import CarsProductsWrapper from "../wrappers/CarsProductsWrapper";
import logo from "../images/j-cars.png";

const styles = {
    root: {
        flexGrow: 1,
    },
    menuButton: {
        marginLeft: -18,
        marginRight: 10,
    },
    rightToolbar: {
        marginLeft: 'auto',
        marginRight: -12,
    }
};

class DenseAppBar extends Component {
    render() {
        const classes = this.props.classes;
        const retroVintage = "/retro_vintage";
        const home = "/";
        const service = "/service";
        const parts = "/parts";
        const cars = "/cars";
        const contact = "/contact";
        const login = "/login";
        let btn;
        if (getCookie('garage_app_token') === '') {
            btn = (<Button color="inherit" href={login}>Login</Button>);
        } else {
            btn = (<Button color="inherit" onClick={this.props.logout}>Logout</Button>)
        }

        return (
            <div className={classes.root}>
                <img src={logo} alt="j-cars logo"/>
                <AppBar position="static">
                    <Toolbar variant="dense">
                        <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={home}>
                            Home
                        </IconButton>
                        <IconButton className={classes.menuButton} color="inherit" aria-label="Menu" href={service}>
                            Service
                        </IconButton>
                        <IconButton className={classes.menuButton} color="inherit" aria-label="Menu"
                                    href={retroVintage}>
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
                        <section className={classes.rightToolbar}>
                            {btn}
                        </section>
                    </Toolbar>
                </AppBar>
                <Switch>
                    <Route exact path={home} component={Home}/>
                    <Route exact path={service} component={Service}/>
                    <Route exact path={retroVintage} component={RetroVintageProductsWrapper}/>
                    <Route exact path={parts} component={PartsProductsWrapper}/>
                    <Route exact path={cars} component={CarsProductsWrapper}/>
                    <Route exact path={contact} component={Contact}/>
                    <Route exact path={login} component={LoginContainer}/>
                    <Redirect to={home}/>
                </Switch>
            </div>
        );
    }

}

DenseAppBar.propTypes = {
    classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(DenseAppBar);
