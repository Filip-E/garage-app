import React from "react";
import {Component} from "react";
import {connect} from "react-redux";
import Login from "../components/Login";
import authenticateUser from "../actions/AuthActions";
import Redirect from "react-router-dom/es/Redirect";
import {getCookie} from "../utils/CookieManager";
import {withRouter} from "react-router-dom";


class LoginContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {username: '', password: '', redirect: false};
        this.handleChange = this.handleChange.bind(this);
        this.goBack = this.goBack.bind(this);
    }

    goBack = () =>{
        this.props.history.goBack();
    };

    handleChange(event) {
        const id = event.target.id;
        this.setState({[id]: event.target.value});
    }

    handleSubmit = (event) => {
        event.preventDefault();
        this.props.authUser({'username': this.state.username, 'password': this.state.password});
    };

    render() {
        if (this.state.redirect || getCookie('token') !== '') {
            return (
                <Redirect to={this.goBack()}/>
            );
        }
        else {
            return (
                <Login
                    cancel={this.goBack}
                    submit={this.handleSubmit}
                    handleChange={this.handleChange}
                    errorText={this.props.auth.error.Message}
                />
            )
        }

    }
}

const mapStateToProps = (state) => {
    return {
        auth: state.auth
    }
};

const mapDispatchToProps = dispatch => {
    return {
        authUser: (user) => {
            dispatch(authenticateUser(user))
        }
    };
};

export default  withRouter(connect(mapStateToProps, mapDispatchToProps)(LoginContainer));