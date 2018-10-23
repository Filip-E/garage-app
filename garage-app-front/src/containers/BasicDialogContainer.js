import React, {Component} from "react";
import {addProduct, editProduct, handleClickOpenDialog, handleClose} from "../actions/productActions";
import BasicDialog from "../components/BasicDialog";
import {connect} from "react-redux";


class BasicDialogContainer extends Component {
    constructor(props) {
        super(props);
        let productState = {};
        this.props.products.forEach((p) => {
            if (p.Id === this.props.productId) {
                for (let i = 0; i < Object.keys(p).length; i++) {
                    let prop = Object.keys(p)[i];
                    productState[prop] = p[prop];
                }
            }
        });
        this.state = productState;
        this.handleChange = this.handleChange.bind(this);
        this.submit = this.submit.bind(this);
    }

    componentDidUpdate(prevProps, prevState, snapshot){
        if(prevProps !== this.props){
            let productState = {};
            this.props.products.forEach((p) => {
                if (p.Id === this.props.productId) {
                    for (let i = 0; i < Object.keys(p).length; i++) {
                        let prop = Object.keys(p)[i];
                        productState[prop] = p[prop];
                    }
                }
            });
            this.setState(productState);
        }
    }
    handleChange(event) {
        const id = event.target.id;
        this.setState({[id]: event.target.value});
    }

    submit(event) {
        event.preventDefault();
        console.log("categories on submit");
        console.log(this.props.categoriesForServer);
        let product = {
            Name: this.state.Name,
            Price: this.state.Price,
            Stock: this.state.Stock,
            CategoryTypes: [
                // todo fix this for retro vintage. it's not yet setting categoriesForServer
                ...this.props.categoriesForServer
                // this.props.productCategory
            ]
        };
        console.log(product);
        if (event.target.textContent === "ADD") {
            delete product.Id;
            this.props.addProduct(product, this.props.token);
        } else if (event.target.textContent === "EDIT") {
            product["Id"] = this.props.productId;
            this.props.editProduct(product, this.props.token);
        }
    }

    render() {
        return (
            // productId + edit needs to be set by the object calling <BasicDialogContainer/>
            <BasicDialog
                open={this.props.open}
                handleClose={this.props.handleClose}
                error={this.props.error}
                handleChange={this.handleChange}
                submit={this.submit}
                products={this.props.products}
                productId={this.props.productId}
                edit={this.props.edit}
                productCategory={this.props.productCategory}
            />
        );
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
        productId: state.product.storeProductId,
        categoriesForServer: state.category.categoriesForServer
    }
};

const mapDispatchToProps = dispatch => {
    return {
        addProduct: (productWithCategoryTypes, token) => {
            dispatch(addProduct(productWithCategoryTypes, token));
        },
        editProduct: (productWithCategoryTypes, token) => {
            dispatch(editProduct(productWithCategoryTypes, token));
        },
        prepareAddDialog: () => {
            dispatch(handleClickOpenDialog())
        },
        handleClose: () => {
            dispatch(handleClose())
        }
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(BasicDialogContainer);