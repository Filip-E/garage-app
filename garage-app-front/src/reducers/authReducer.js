import actionTypes from "../actions/actionTypes";

const initialState = {
    error: '',
    response: '',
    token: ''
};
export default function authReducer(state = initialState, action) {
    switch (action.type) {
        case actionTypes.AUTH_SUCCESS:{
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
                error: action.payload,
                response: null,
                token: ''
            }
        }
        default:
            return state;
    }
}
