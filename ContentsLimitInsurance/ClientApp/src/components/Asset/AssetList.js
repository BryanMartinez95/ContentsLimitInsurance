import React,{ Fragment } from 'react';
import AssetRow from './AssetRow';
import AssetGroupRow from './AssetGroupRow';

const AssetList = props => {
    console.log('props',props);
    const items = props.inventoryGroups.map((group,index) => {
        return (
            <Fragment key={group.id}>
                {/* <AssetGroupRow
                    key={group.id}
                    groupByValue={group.groupByValue}
                    value={group.value}>
                </AssetGroupRow>
                {group.inventoryItems.map((item,index) => {
                    console.log('??');
                    return (<AssetRow 
                        key={item.id}
                        name={item.name}
                        location={item.location}
                        datePurchased={item.datePurchased}
                        value={item.value}>
                    </AssetRow>
                    );
                })} */}
            </Fragment>
        );
    });

    return (
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Location</th>
                    {/* <th>Date Purchased</th> */}
                    <th>Value</th>
                </tr>
            </thead>
            <tbody>
                {items}
            </tbody>
        </table>
    );
}

export default AssetList;