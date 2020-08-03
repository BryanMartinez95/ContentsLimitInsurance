import React from 'react';

const AssetGroupSelector = props => {
    return(
        <select name="asset-group-selector" value="category" onChange={props.change()} >
            <option value="none">None</option>
            <option value="location">Location</option>
            <option value="category">Category</option>
            <option value="date">Date</option>
        </select>
    );
}

export default AssetGroupSelector;