import actionTypes from "./actionTypes";
import axios from "axios";
import {apiLocation} from "./serverUrl";

export default function authenticateUser(user){
    return (dispatch) => {
        return axios
            .get(apiLocation + '/api/Token?username=' + user.username + '&password=' + user.password)
            .then(response =>{
                dispatch({
                    type: actionTypes.AUTH_SUCCESS,
                    payload : response
                })
            })
            .catch(error =>{
                dispatch({
                    type: actionTypes.AUTH_FAIL,
                    payload: error
                })
            })
    }
}