import {combineReducers} from "redux";

import product from "./productReducer";
import auth from "./authReducer";
import category from "./categoryReducer";
import car from "./carReducer";

const rootReducer = combineReducers({
    product, // extra info: es6 short hand property name
    auth,
    category,
    car
});

export default rootReducer;
