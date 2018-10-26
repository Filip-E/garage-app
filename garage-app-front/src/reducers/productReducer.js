import actionTypes from "../actions/ProductActionTypes";
const initialState = {
    fetching: false,
    fetched: false,
    products: [],
    error: null,
    response: null,
    open: false,
    editDialogState: false,
    storeProductId: 0
};

export default function productReducer(state = initialState, action) {
    switch (action.type) {
        case actionTypes.FETCH_PRODUCTS:{
            return Object.assign({}, state,{
                fetching: true,
                fetched: false
            })
        }
        case actionTypes.FETCH_PRODUCTS_SUCCESS:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: action.payload,
                products: action.payload.data,
                error: null
            })
        }
        case actionTypes.FETCH_PRODUCTS_FAIL:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                error: action.payload.response
            })
        }
        case actionTypes.FILTER_STOCK:{
            let filteredProducts = state.products.filter((product)=> product.Stock !== 0);
            return Object.assign({}, state,{
                products : filteredProducts
            })
        }
        case actionTypes.ADD_PRODUCT_START:{
            return Object.assign({}, state,{
                fetching: true,
                fetched: false,
                response: null,
                error: null,
            })
        }
        case actionTypes.ADD_PRODUCT_SUCCESS:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: action.payload,
                error: null,
                open: false
            })
        }
        case actionTypes.ADD_PRODUCT_FAIL:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: null,
                error: action.payload,
                open: true
            })
        }
        case actionTypes.EDIT_PRODUCT_START:{
            return Object.assign({}, state,{
                fetching: true,
                fetched: false,
                response: null,
                error: null,
            })
        }
        case actionTypes.EDIT_PRODUCT_SUCCESS:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: action.payload,
                error: null,
                open: false
            })
        }
        case actionTypes.EDIT_PRODUCT_FAIL:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: null,
                error: action.payload,
                open: true
            })
        }
        case actionTypes.DELETE_PRODUCT_START:{
            return Object.assign({}, state,{
                ...state,
                fetching: true,
                fetched: false,
                response: null,
                error: null,
            })
        }
        case actionTypes.DELETE_PRODUCT_SUCCESS:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: action.payload,
                error: null
            })
        }
        case actionTypes.DELETE_PRODUCT_FAIL:{
            return Object.assign({}, state,{
                fetching: false,
                fetched: true,
                response: null,
                error: action.payload
            })
        }
        case actionTypes.DIALOG_CLOSE:{
            return Object.assign({}, state,{
                open: false
            })
        }
        case actionTypes.DIALOG_OPEN:{
            return Object.assign({}, state,{
                open: true
            })
        }
        case actionTypes.EDIT_DIALOG_TRUE:{
            return Object.assign({}, state,{
                editDialogState: true
            })
        }
        case actionTypes.EDIT_DIALOG_FALSE:{
            return Object.assign({}, state,{
                editDialogState: false
            })
        }
        case actionTypes.SET_PRODUCT_ID:{
            return Object.assign({}, state,{
                storeProductId: action.payload
            })
        }
        default:
            return state;
    }
}