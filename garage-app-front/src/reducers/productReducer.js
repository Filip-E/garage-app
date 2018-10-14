import actionTypes from "../actions/actionTypes";
const initialState = {
    fetching: false,
    fetched: false,
    products: [],
    error: null,
    response: null
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
                error: action.payload
            }
        }
        case actionTypes.FILTER_STOCK:{
            console.log('hi');
            let filteredProducts = state.products.filter((product)=> product.Stock !== 0);
            console.log(filteredProducts);
            console.log("state:");
            console.log({
                ...state,
                products : filteredProducts
            });
            return{
                ...state,
                products : filteredProducts
            }
        }
        default:
            return state;
    }
}