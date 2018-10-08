import {combineReducers} from "redux";

import product from "./productReducer";

const rootReducer = combineReducers({
    product //es6 short hand property name
});

export default rootReducer;
