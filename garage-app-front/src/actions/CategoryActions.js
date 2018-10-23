import actionTypes from "./CategoryActionTypes";
import axios from "axios";
import {apiLocation} from "./serverUrl";

export function fetchCategories() {
    return (dispatch) => {
        dispatch({type: actionTypes.FETCH_CATEGORIES});
        return axios
            .get(apiLocation + "/category")
            .then(response => {
                dispatch({
                    type: actionTypes.FETCH_CATEGORIES_SUCCESS,
                    payload: response
                })
            })
            .catch(error => {
                dispatch({
                    type: actionTypes.FETCH_CATEGORIES_FAIL,
                    payload: error
                })
            });
    }
}
export function fetchProductCategories(productId) {
    return (dispatch) => {
        dispatch({type: actionTypes.FETCH_PRODUCT_CATEGORIES});
        return axios
            .get(apiLocation + "/category/product/" + productId)
            .then(response => {
                dispatch({
                    type: actionTypes.FETCH_PRODUCT_CATEGORIES_SUCCESS,
                    payload: response
                })
            })
            .catch(error => {
                dispatch({
                    type: actionTypes.FETCH_PRODUCT_CATEGORIES_FAIL,
                    payload: error
                })
            });
    }
}