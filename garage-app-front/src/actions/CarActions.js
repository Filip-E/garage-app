import CarActionTypes from "./CarActionTypes";
import axios from "axios";
import {apiLocation} from "./serverUrl";

export function fetchCarSpecifications(productId){
    return(dispatch) =>{
        dispatch({type: CarActionTypes.FETCH_SPECIFICATIONS});
        return axios
            .get(apiLocation + "/car/specification/" + productId)
            .then(response =>{
                dispatch({type: CarActionTypes.FETCH_SPECIFICATIONS_SUCCESS, payload: response});
            })
            .catch(error =>{
                dispatch({type: CarActionTypes.FETCH_SPECIFICATIONS_FAIL, payload: error});
            });
    }
}

export function fetchRequiredCarSpecifications(){
    return(dispatch) =>{
        dispatch({type: CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS});
        return axios
            .get(apiLocation + "/specificationType/car")
            .then(response =>{
                dispatch({type: CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS_SUCCESS, payload: response});
            })
            .catch(error =>{
                dispatch({type: CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS_FAIL, payload: error});
            });
    }
}