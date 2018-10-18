import actionTypes from "./actionTypes";
import axios from "axios";
import {apiLocation} from "./serverUrl";

export default function authenticateUser(user){
    return (dispatch) => {
        return axios
            .get(apiLocation + '/Token/' + user.username + '/' + user.password)
            .then(response =>{
                dispatch({
                    type: actionTypes.AUTH_SUCCESS,
                    payload : response
                })
            })
            .catch(error =>{
                dispatch({
                    type: actionTypes.AUTH_FAIL,
                    payload: error.response.data.Message
                })
            })
    }
}
export function logOut() {
    return (dispatch) =>{
        dispatch({
            type: actionTypes.LOG_OUT,
        });
    }
}