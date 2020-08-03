import React, { Fragment } from "react";
import AssetRow from "./AssetRow";
import AssetGroupRow from "./AssetGroupRow";

const AssetList = (props) => {
  let total = 0;
  const items = props.assetGroupList.map((group, index) => {
    total += group.total;
    return (
      <Fragment key={group.groupById}>
        <AssetGroupRow
          key={group.groupById}
          groupByValue={group.groupByValue}
          value={group.total}
        ></AssetGroupRow>
        {group.assetList.map((asset, index) => {
          return (
            <AssetRow
              key={asset.id}
              id={asset.id}
              name={asset.name}
              location={asset.location}
              datePurchased={asset.datePurchased}
              value={asset.value}
              deleteAssetRowHandler={props.deleteAssetRowHandler}
            ></AssetRow>
          );
        })}
      </Fragment>
    );
  });
  return (
    <table>
      <thead>
        <tr>
          <th>Category</th>
          <th>Name</th>
          {/* <th>Location</th> */}
          <th>Value</th>
        </tr>
      </thead>
      <tbody>
        {items}
        <AssetGroupRow groupByValue="TOTAL" value={total}></AssetGroupRow>
      </tbody>
    </table>
  );
};

export default AssetList;
