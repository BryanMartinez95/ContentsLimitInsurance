import React from "react";

const AssetGroupRow = (props) => {
  return (
    <tr style={{ backgroundColor: "#e5f5f9" }}>
      <td colSpan="2">
        <strong>{props.groupByValue}</strong>
      </td>
      <td>
        <strong className="is-pulled-right">${props.value.toFixed(2)}</strong>
      </td>
      <td></td>
    </tr>
  );
};

export default AssetGroupRow;
