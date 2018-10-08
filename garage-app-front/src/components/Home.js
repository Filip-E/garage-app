import {Component} from "react";
import logo from "../logo.svg";
import React from "react";
import DenseAppBar from "./DenseAppBar";

class Home extends Component {
    render() {
        return (
            <DenseAppBar>
                <div className="App">
                    <header className="App-header">
                        <img src={logo} className="App-logo" alt="logo"/>
                        <h1 className="App-title">Welcome to React</h1>
                    </header>
                    <p className="App-intro">
                        To get started, edit <code>src/App.js</code> and save to reload.
                    </p>
                </div>
            </DenseAppBar>
        )
    }
}

export default Home;