import React from "react";

const AssetGroupRow = (props) => {
  return (
    <tr>
      <td colSpan="2">{props.groupByValue}</td>
      <td>${props.value.toFixed(2)}</td>
    </tr>
  );
};

export default AssetGroupRow;
