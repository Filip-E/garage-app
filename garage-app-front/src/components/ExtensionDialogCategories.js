import React, {Component} from 'react';
import TextField from "@material-ui/core/TextField/TextField";
import Typography from "@material-ui/core/Typography/Typography";

class ExtensionDialogCategories extends Component {
    constructor(props) {
        super(props);
        this.renderTextFields = this.renderTextFields.bind(this);
    }


    renderTextFields() {
        let categories = this.props.categoryTypes;
        // start loop from 1 !!! don't care about first category in the array
        let fields = [];
        for (let i = 1; i < categories.length; i++) {
            let category = categories[i];
            fields.push(
                <TextField
                    margin="dense"
                    fullWidth
                    key={category}
                    defaultValue={category}
                />
            );
        }
        return (fields);
    }

    render() {
        console.log("Types:");
        console.log(this.props.categoryTypes);
        return (
            <div>
                <Typography variant="subtitle1">
                    <br/> Categorieën <br/>
                </Typography>

                {this.renderTextFields()}
            </div>
        );
    }
}

export default ExtensionDialogCategories;