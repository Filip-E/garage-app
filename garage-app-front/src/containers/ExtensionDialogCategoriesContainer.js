import React, {Component} from 'react';
import {connect} from 'react-redux';
import ExtensionDialogCategories from "../components/ExtensionDialogCategories";
import {fetchCategories, fetchProductCategories} from "../actions/CategoryActions";


class ExtensionDialogCategoriesContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            categoriesProduct: this.props.categoryTypes
        };
        this.handleChange = this.handleChange.bind(this);
    }
    handleChange(event){
        this.setState({ categoriesProduct: event.target.value });
    };

    componentDidMount(){
        this.props.fetchProductCategories(this.props.productId);
        this.props.fetchCategories();
    }
    render() {
        return (
            <ExtensionDialogCategories
                // categoryTypes={this.props.categoryTypes}
                handleChange={this.handleChange}
                categoriesProduct={this.state.categoriesProduct}
                allCategories={this.props.categories}
            />
        );
    }
}

function mapStateToProps(state) {
    return {
        productId: state.product.storeProductId,
        categoryTypes: state.category.types,
        categories: state.category.categories
    };
}

function mapDispatchToProps(dispatch) {
    return {
        fetchCategories: () =>{
            dispatch(fetchCategories());
        },
        fetchProductCategories: (productId) => {
            dispatch(fetchProductCategories(productId));
        }
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(ExtensionDialogCategoriesContainer);