import React, {Component} from 'react';
import {connect} from 'react-redux';
import AddCategoryDialog from "../components/AddCategoryDialog";
import {addCategory} from "../actions/CategoryActions";

class AddCategoryDialogContainer extends Component {
    constructor(props) {
        super(props);
        this.state = {
            category : null,
        };
        this.handleChange = this.handleChange.bind(this);
        this.submit = this.submit.bind(this);
    }
    handleChange(event){
        this.setState({category: event.target.value})
    }
    submit(){
        this.props.addCategory(this.state.category);
    }
    render() {
        return (
            <AddCategoryDialog
            open={this.props.openDialogState}
            handleClose={this.props.handleClose}
            error={this.props.error}
            handleChange={this.handleChange}
            submit={this.submit}
            />
        );
    }
}

function mapStateToProps(state) {
    return {
        error: state.category.errorAddCategory
    };
}
function mapDispatchToProps(dispatch) {
    return {
        addCategory: (category) =>{
            dispatch(addCategory(category));
        }
    };
}
export default connect(
    mapStateToProps,
    mapDispatchToProps
)(AddCategoryDialogContainer);