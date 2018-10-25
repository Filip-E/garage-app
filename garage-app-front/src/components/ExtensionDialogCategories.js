import React, {Component} from 'react';
import Typography from "@material-ui/core/Typography/Typography";
import Select from "@material-ui/core/Select/Select";
import MenuItem from "@material-ui/core/MenuItem/MenuItem";
import Checkbox from "@material-ui/core/Checkbox/Checkbox";
import ListItemText from "@material-ui/core/ListItemText/ListItemText";
import Input from "@material-ui/core/Input/Input";

class ExtensionDialogCategories extends Component {
    constructor(props) {
        super(props);
        this.renderTextFields = this.renderTextFields.bind(this);
    }

    renderTextFields() {
        let categories = this.props.allCategories;
        // start loop from 1 !!! don't care about first category in the array
        let fields = [];
        let menuItems = [];
        for (let i = 0; i < categories.length; i++) {
            let category = categories[i].Type;
            /*            fields.push(
                            <TextField
                                margin="dense"
                                fullWidth
                                key={category}
                                defaultValue={category}
                            />
                        );*/
            menuItems.push(
                <MenuItem key={category} value={category}>
                    <Checkbox checked={this.props.categoriesProduct.indexOf(category) > -1}/>
                    <ListItemText primary={category}/>
                </MenuItem>)
        }
        fields.push(
            <div>
                {/*<InputLabel htmlFor="select-multiple-checkbox">Tag</InputLabel>*/}
                <Select
                    multiple
                    value={this.props.categoriesProduct}
                    onChange={this.props.handleChange}
                    input={<Input id="select-multiple-checkbox"/>}
                    renderValue={selected => selected.join(', ')}
                    // MenuProps={MenuProps}
                >
                    {menuItems}
                </Select>
            </div>);
        return (fields);
    }

    render() {
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