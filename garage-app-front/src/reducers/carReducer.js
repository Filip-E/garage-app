import CarActionTypes from "../actions/CarActionTypes";

const initialState = {
    specifications: [],
    requiredCarSpecifications: [],
    error: null
};

export default function carReducer(state = initialState, action) {
    switch (action.type) {
        case CarActionTypes.FETCH_SPECIFICATIONS: {
            return Object.assign(
                {},
                state,
                {
                    specifications: []
                });
        }
        case CarActionTypes.FETCH_SPECIFICATIONS_SUCCESS: {
            return Object.assign(
                {},
                state,
                {
                    specifications: action.payload.data
                });
        }
        case CarActionTypes.FETCH_SPECIFICATIONS_FAIL: {
            return Object.assign(
                {},
                state,
                {
                    error: action.payload
                });
        }
        case CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS: {
            return Object.assign(
                {},
                state,
                {
                    requiredCarSpecifications: []
                });
        }
        case CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS_SUCCESS: {
            return Object.assign(
                {},
                state,
                {
                    requiredCarSpecifications: action.payload.data
                });
        }
        case CarActionTypes.FETCH_REQUIRED_CAR_SPECIFICATIONS_FAIL: {
            return Object.assign(
                {},
                state,
                {
                    error: action.payload
                });
        }
        default:
            return state
    }
}