import React from 'react';

const AssetRow = props => {
    return (
        <tr>
            <td>{props.name}</td>
            <td>{props.location}</td>
            {/* <td>{props.datePurchased.toString()}</td> */}
            <td>{props.value}</td>
        </tr>
    );
}

export default AssetRow;