import React from 'react';

const AssetGroupRow = props => {
    return (
        <tr>
            <td colSpan='2'>{props.groupByValue}</td>
            <td>{props.value}</td>
        </tr>
    );
}


export default AssetGroupRow;