import actionTypes from "../actions/actionTypes";
const initialState = {
    fetching: false,
    fetched: false,
    products: [],
    error: null,
    response: null,
    open: false
};

export default function productReducer(state = initialState, action) {
    switch (action.type) {
        case actionTypes.FETCH_PRODUCTS:{
            return{
                ...state,
                fetching: true,
                fetched: false
            }
        }
        case actionTypes.FETCH_PRODUCTS_SUCCESS:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                response: action.payload,
                products: action.payload.data,
                error: null
            }
        }
        case actionTypes.FETCH_PRODUCTS_FAIL:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                error: action.payload.response
            }
        }
        case actionTypes.FILTER_STOCK:{
            let filteredProducts = state.products.filter((product)=> product.Stock !== 0);
            return{
                ...state,
                products : filteredProducts
            }
        }
        case actionTypes.ADD_PRODUCT_START:{
            return{
                ...state,
                fetching: true,
                fetched: false,
                response: null,
                error: null,
            }
        }
        case actionTypes.ADD_PRODUCT_SUCCESS:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                response: action.payload,
                error: null,
                open: false
            }
        }
        case actionTypes.ADD_PRODUCT_FAIL:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                response: null,
                error: action.payload,
                open: true
            }
        }
        case actionTypes.DELETE_PRODUCT_START:{
            return{
                ...state,
                fetching: true,
                fetched: false,
                response: null,
                error: null,
            }
        }
        case actionTypes.DELETE_PRODUCT_SUCCESS:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                response: action.payload,
                error: null
            }
        }
        case actionTypes.DELETE_PRODUCT_FAIL:{
            return{
                ...state,
                fetching: false,
                fetched: true,
                response: null,
                error: action.payload
            }
        }
        case actionTypes.DIALOG_CLOSE:{
            return{
                ...state,
                open: false
            }
        }
        case actionTypes.DIALOG_OPEN:{
            return{
                ...state,
                open: true
            }
        }
        default:
            return state;
    }
}