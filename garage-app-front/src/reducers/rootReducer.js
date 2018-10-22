import {combineReducers} from "redux";

import product from "./productReducer";
import auth from "./authReducer";
import category from "./categoryReducer";

const rootReducer = combineReducers({
    product, // extra info: es6 short hand property name
    auth,
    category
});

export default rootReducer;
