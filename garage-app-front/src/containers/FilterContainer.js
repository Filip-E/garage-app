import React, {Component} from 'react';
import {connect} from 'react-redux';
import Filter from "../components/Filter";
import {fetchCategories, filterProductsBasedOnCategory} from "../actions/CategoryActions";
import {fetchProductsAndFilter, filterProductsBasedOnName} from "../actions/productActions";

// eslint-disable-next-line
import {isEmpty} from "../utils/utilFunctions";

function mapStateToProps(state) {
    return {
        products: state.product.products,
        categories: state.category.categories,
        fetched: state.category.fetched,
    };
}

function mapDispatchToProps(dispatch) {
    return {
        fetchProducts: (category) =>{
            dispatch(fetchProductsAndFilter(category))
        },
        fetchCategories: () => {
            dispatch(fetchCategories());
        },
        filterProductsBasedOnName: (names, categoryType) => {
            dispatch(filterProductsBasedOnName(names, categoryType));
        },
        filterProductsBasedOnCategory: (categories, categoryType) =>{
            dispatch(filterProductsBasedOnCategory(categories,categoryType));
        }
    };
}

class FilterContainer extends Component {
    constructor(props) {
        super(props);
        this.createSuggestionsArray = this.createSuggestionsArray.bind(this);
    }

    componentDidMount() {
        this.props.fetchCategories();
    }

    createSuggestionsArray() {
        let suggestions = [];
        this.props.products.forEach((element) => {
            suggestions.push({label: element.Name, type: "product"})
        });
        if (!isEmpty(this.props.categories)) {
            this.props.categories.forEach((element) => {
                suggestions.push({label: element.Type, type: "category"})
            });
        }
        return suggestions;
    }

    render() {
        if (this.props.fetched) {
            return (
                <Filter
                    suggestions={this.createSuggestionsArray()}
                    filterProducts={this.props.filterProductsBasedOnName}
                    filterProductsCategory={this.props.filterProductsBasedOnCategory}
                    products={this.props.products}
                    productCategory={this.props.productCategory}
                    fetchProducts={this.props.fetchProducts}
                />
            );
        } else {
            return (<div/>)
        }

    }
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(FilterContainer);