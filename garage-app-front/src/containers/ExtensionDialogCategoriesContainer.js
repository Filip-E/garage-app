import React, {Component} from 'react';
import {connect} from 'react-redux';
import ExtensionDialogCategories from "../components/ExtensionDialogCategories";
import {fetchCategories} from "../actions/CategoryActions";


class ExtensionDialogCategoriesContainer extends Component {
    componentDidMount(){
        this.props.fetchCategories(this.props.productId);
    }
    render() {
        return (
            <ExtensionDialogCategories
                categoryTypes={this.props.categoryTypes}
            />
        );
    }
}

function mapStateToProps(state) {
    return {
        productId: state.product.storeProductId,
        categoryTypes: state.category.types
    };
}

function mapDispatchToProps(dispatch) {
    return {
        fetchCategories: (productId) => {
            dispatch(fetchCategories(productId));
        }
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(ExtensionDialogCategoriesContainer);