import React, {Component} from "react";
import {
    fetchProducts,
    fetchProductsAndFilter, filterStock,
    handleClickOpenDialog,
    makeEditDialogFalse,
    setProductId
} from "../actions/productActions";
import {connect} from "react-redux";
import Loading from "../components/Loading";
import ProductsComponent from "../components/ProductsComponent";
import {withRouter} from "react-router-dom";


class ProductsContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            openAddCategoryDialogState: false,
        };
        this.handleClickOpen = this.handleClickOpen.bind(this);
        this.handleCloseAddCategory = this.handleCloseAddCategory.bind(this);
        this.handleOpenAddCategory = this.handleOpenAddCategory.bind(this);
    }

    handleCloseAddCategory() {
        this.setState({openAddCategoryDialogState: false})
    }

    handleOpenAddCategory() {
        this.setState({openAddCategoryDialogState: true})
    }

    componentDidMount() {
        if (this.props.token) {
            this.props.fetchProducts(this.props.productCategory);
        } else {
            this.props.fetchProductsAndFilter(this.props.productCategory);
        }
    }

    componentDidUpdate(prevProps, prevState, snapshot) {
        if(this.props.response !== null){
            if (this.props.response.status === 204){
                if (this.props.response.config.method === 'delete') {
                    this.props.fetchProducts(this.props.productCategory);
                }
            }
        }
        if (prevProps.token !== this.props.token) {
            if (this.props.token) {
                this.props.fetchProducts(this.props.productCategory);
            } else {
                this.props.fetchProductsAndFilter(this.props.productCategory);
            }

        }
        if (prevProps.responseAddCategory !== this.props.responseAddCategory) {
            if (this.props.responseAddCategory !== null) {
                this.setState({openAddCategoryDialogState: false})
            }
        }
        if (!this.props.token) {
            if (!prevProps.products.equals(this.props.products)) {
                this.props.filterStock();
            }
        }
    }

    handleClickOpen() {
        this.props.prepareAddDialog(this.props.products[0].Id);
    }

    render() {
        if (this.props.fetched) {
            if (this.props.response !== null) {
                if (this.props.response.status === 201) {
                    this.props.fetchProducts(this.props.productCategory);
                }
            }
            if (this.props.error !== null) {
                if (this.props.error.status === 500) {
                    return (
                        <p>oeps, er is iets mis gegaan</p>
                    )
                } else {
                    return (
                        <ProductsComponent
                            products={this.props.products}
                            token={this.props.token}
                            handleClickOpen={this.handleClickOpen}
                            editDialog={this.props.editDialogState}
                            pageTitle={this.props.pageTitle}
                            productCategory={this.props.productCategory}
                            openAddCategoryDialogState={this.state.openAddCategoryDialogState}
                            handleCloseAddCategory={this.handleCloseAddCategory}
                            handleOpenAddCategory={this.handleOpenAddCategory}
                        />
                    )
                }
            } else {
                return (
                    <ProductsComponent
                        products={this.props.products}
                        token={this.props.token}
                        handleClickOpen={this.handleClickOpen}
                        editDialog={this.props.editDialogState}
                        pageTitle={this.props.pageTitle}
                        productCategory={this.props.productCategory}
                        openAddCategoryDialogState={this.state.openAddCategoryDialogState}
                        handleCloseAddCategory={this.handleCloseAddCategory}
                        handleOpenAddCategory={this.handleOpenAddCategory}
                    />
                )
            }
        } else {
            return (
                <Loading/>
            )
        }
    }
}

const mapStateToProps = (state) => {
    return {
        products: state.product.products,
        error: state.product.error,
        fetched: state.product.fetched,
        response: state.product.response,
        open: state.product.open,
        token: state.auth.token,
        editDialogState: state.product.editDialogState,
        responseAddCategory: state.category.responseAddCategory
    }
};

const mapDispatchToProps = dispatch => {
    return {
        fetchProducts: (category) => {
            dispatch(fetchProducts(category));
        },
        fetchProductsAndFilter: (category) => {
            dispatch(fetchProductsAndFilter(category));
        },
        filterStock: () => {
            dispatch(filterStock());
        },
        prepareAddDialog: (productId) => {
            dispatch(makeEditDialogFalse());
            dispatch(handleClickOpenDialog());
            dispatch(setProductId(productId));
        },
    };
};

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(ProductsContainer));