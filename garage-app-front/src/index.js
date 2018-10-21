import React from 'react';
import {createStore, applyMiddleware} from "redux";
import ReactDOM from 'react-dom';
import './index.css';
import App from './components/App';
import registerServiceWorker from './registerServiceWorker';
import thunk from "redux-thunk";
import rootReducer from "./reducers/rootReducer";
import {composeWithDevTools} from "redux-devtools-extension";
import Provider from "react-redux/es/components/Provider";
import MuiThemeProvider from "@material-ui/core/es/styles/MuiThemeProvider";
import createMuiTheme from "@material-ui/core/es/styles/createMuiTheme";


const middleware = applyMiddleware(thunk);
const store = createStore(rootReducer, composeWithDevTools(middleware));
const theme = createMuiTheme({
    palette: {
        type: 'light',
    },
    typography: {
        useNextVariants: true,
    },
});
ReactDOM.render(
    <MuiThemeProvider theme={theme}>
        <Provider store={store}>
            <App/>
        </Provider>
    </MuiThemeProvider>,
    document.getElementById('root')
);
registerServiceWorker();
