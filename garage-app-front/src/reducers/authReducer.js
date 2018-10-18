import actionTypes from "../actions/actionTypes";
import {getCookie, setSessionCookie} from "../utils/CookieManager";

const initialState = {
    error: '',
    response: '',
    token: getCookie('token')
};
export default function authReducer(state = initialState, action) {
    switch (action.type) {
        case actionTypes.AUTH_SUCCESS:{
            setSessionCookie('token',action.payload.data);
            return{
                ...state,
                error: null,
                response: action.payload,
                token: action.payload.data
            }
        }
        case actionTypes.AUTH_FAIL:{
            return{
                ...state,
                error: action.payload.error,
                response: null,
                token: ''
            }
        }
        case actionTypes.LOG_OUT:{
            setSessionCookie('token', '');
            return{
                ...state,
                error: null,
                response: null,
                token: ''
            }
        }
        default:
            return state;
    }
}
