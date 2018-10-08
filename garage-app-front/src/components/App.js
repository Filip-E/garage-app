import React, {Component} from 'react';
import {BrowserRouter as Router} from "react-router-dom";
import '../App.css';
import DenseAppBar from "./DenseAppBar";

class App extends Component {
  render() {
    return (
        <Router>
            <DenseAppBar/>
        </Router>
    );
  }
}

export default App;
