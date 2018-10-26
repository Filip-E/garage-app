import actionTypes from "../actions/CategoryActionTypes";

const initialState = {
    fetching: false,
    fetched: false,
    types: [],
    categories: {},
    error: null,
    response: null,
    categoriesForServer: [],
};

export default function productReducer(state = initialState, action) {
    switch (action.type) {
        case actionTypes.FETCH_CATEGORIES: {
            return Object.assign({}, state, {
                fetching: true,
                fetched: false
            })
        }
        case actionTypes.FETCH_CATEGORIES_SUCCESS: {
            return Object.assign({}, state, {
                fetching: false,
                fetched: true,
                response: action.payload,
                categories: action.payload.data,
                error: null
            })
        }
        case actionTypes.FETCH_CATEGORIES_FAIL: {
            return Object.assign({}, state, {
                fetching: false,
                fetched: true,
                error: action.payload.response
            })
        }
        case actionTypes.FETCH_PRODUCT_CATEGORIES: {
            return Object.assign({}, state, {
                fetching: true,
                fetched: false
            })
        }
        case actionTypes.FETCH_PRODUCT_CATEGORIES_SUCCESS: {
            let categoryTypes = [];
            action.payload.data.forEach((category) => {
                categoryTypes.push(category.Type)
            });
            return Object.assign({}, state, {
                fetching: false,
                fetched: true,
                response: action.payload,
                types: categoryTypes,
                error: null
            })
        }
        case actionTypes.FETCH_PRODUCT_CATEGORIES_FAIL: {
            return Object.assign({}, state, {
                fetching: false,
                fetched: true,
                error: action.payload.response
            })
        }
        case actionTypes.EDIT_CATEGORIES_FOR_SERVER: {
            return Object.assign({}, state, {
                categoriesForServer: action.payload
            })
        }
        default:
            return state;
    }
};
