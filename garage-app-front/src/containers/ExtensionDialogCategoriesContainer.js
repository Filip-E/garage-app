import React, {Component} from 'react';
import {connect} from 'react-redux';
import ExtensionDialogCategories from "../components/ExtensionDialogCategories";
import {fetchCategories, fetchProductCategories, setCategoriesForServer} from "../actions/CategoryActions";


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
        this.props.setCategoriesForServer(event.target.value);
    };

    componentDidMount(){
        this.props.fetchProductCategories(this.props.productId);
        this.props.fetchCategories();
        this.props.setCategoriesForServer(this.props.categoryTypes);
    }

    componentDidUpdate(prevProps, prevState, snapshot){
        if(prevProps !== this.props){
            // check if the categories in the store are the ones for the productCard that is currently rendering
            let categoryCallUrl = [ ...this.props.response.config.url];
            let categoryCallUrlId = parseInt(categoryCallUrl[categoryCallUrl.length - 1], 10);
            if(this.props.productId === categoryCallUrlId){
                this.setState({categoriesProduct: this.props.categoryTypes});
            }
        }
    }
    render() {
        return (
            <ExtensionDialogCategories
                // categoryTypes={this.props.categoryTypes}
                handleChange={this.handleChange}
                categoriesProduct={this.state.categoriesProduct}
                allCategories={this.props.categories}
                setCategories={this.props.setCategoriesForServer}
            />
        );
    }
}

function mapStateToProps(state) {
    return {
        productId: state.product.storeProductId,
        categoryTypes: state.category.types,
        categories: state.category.categories,
        response: state.category.response
    };
}

function mapDispatchToProps(dispatch) {
    return {
        fetchCategories: () =>{
            dispatch(fetchCategories());
        },
        fetchProductCategories: (productId) => {
            dispatch(fetchProductCategories(productId));
        },
        setCategoriesForServer: (categories) =>{
            dispatch(setCategoriesForServer(categories))
        }
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(ExtensionDialogCategoriesContainer);