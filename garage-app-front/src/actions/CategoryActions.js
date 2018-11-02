import actionTypes from "./CategoryActionTypes";
import productActionTypes from "./ProductActionTypes";
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

export function setCategoriesForServer(categories){
    return (dispatch) =>{
        dispatch({type: actionTypes.EDIT_CATEGORIES_FOR_SERVER, payload: categories})
    }
}

export function addCategory(category, token){
    return (dispatch) =>{
        dispatch({type: actionTypes.ADD_CATEGORIES_START});
        console.log("add category send to server: ");
        let categoryObject = {Type: category};
        console.log(categoryObject);
        return axios
            .post(
                apiLocation + "/category",
                categoryObject,
                {
                    headers: { Authorization: "Bearer " + token }
                }
            ).then(response =>{
                dispatch({
                    type: actionTypes.ADD_CATEGORIES_SUCCESS,
                    payload: response
                });
            }).catch(error =>{
                dispatch({
                    type: actionTypes.ADD_CATEGORIES_FAIL,
                    payload: error.response.data.Message
                })
            });
    }
}

export function filterProductsBasedOnCategory(categories, categoryType) {
    return (dispatch) => {
        let data = {
            "Types": categories,
            "Category": categoryType
        };
        return axios
            .post(apiLocation + "/filter/product/categories", data)
            .then(response => {
                dispatch({
                    type: productActionTypes.FETCH_PRODUCTS_SUCCESS,
                    payload: response
                })
            })
            .catch(error => {
                dispatch({
                    type: productActionTypes.FETCH_PRODUCTS_FAIL,
                    payload: error
                })
            });
    }
}