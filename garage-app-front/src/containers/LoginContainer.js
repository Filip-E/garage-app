import React from "react";
import {Component} from "react";
import {connect} from "react-redux";
import Login from "../components/Login";
import authenticateUser from "../actions/AuthActions";
import Redirect from "react-router-dom/es/Redirect";



class LoginContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {username : '', password: '', redirect : false };
        this.handleChange = this.handleChange.bind(this);

    }
    cancel = () => {
        this.setState({redirect: true})
    };
    handleChange (event){
        const id = event.target.id;
        this.setState({[id]: event.target.value });
    }
    handleSubmit = (event) => {
        event.preventDefault();
        this.props.authUser({'username' : this.state.username, 'password' : this.state.password});
    };
    render() {
        if(this.state.redirect){
            return(<Redirect to="/"/>)
        }
        if(this.props.auth.token){
            return(
                <p> you are already logged in</p>
            )
        }else{
            return(
                <Login
                    cancel={this.cancel}
                    submit={this.handleSubmit}
                    handleChange={this.handleChange}
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
        authUser: (user) =>{
            dispatch(authenticateUser(user))
        }
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(LoginContainer);