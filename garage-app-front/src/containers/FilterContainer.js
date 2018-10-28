import React, {Component} from 'react';
import {connect} from 'react-redux';
import Filter from "../components/Filter";
import {fetchCategories} from "../actions/CategoryActions";

function mapStateToProps(state) {
    return {
        products: state.product.products,
        categories: state.category.categories,
        fetched: state.category.fetched,
    };
}

function mapDispatchToProps(dispatch) {
    return {
        fetchCategories: () => {
            dispatch(fetchCategories());
        },
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
            suggestions.push({label: element.Name})
        });
        this.props.categories.forEach((element) => {
            suggestions.push({label: element.Type})
        });
        return suggestions;
    }

    render() {
        if (this.props.fetched) {
            return (
                <Filter suggestions={this.createSuggestionsArray()}/>
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