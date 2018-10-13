import React, {Component} from 'react';
import {BrowserRouter as Router} from "react-router-dom";
import '../App.css';
import DenseAppBarContainer from "../containers/DenseAppBarContainer";

class App extends Component {
  render() {
    return (
        <Router>
            <DenseAppBarContainer/>
        </Router>
    );
  }
}

export default App;
