import {combineReducers} from "redux";

import product from "./productReducer";
import auth from "./authReducer";

const rootReducer = combineReducers({
    product, //es6 short hand property name
    auth
});

export default rootReducer;
