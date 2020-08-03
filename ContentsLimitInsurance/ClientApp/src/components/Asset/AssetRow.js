import React from "react";

const AssetRow = (props) => {
  return (
    <tr>
      <td></td>
      <td>{props.name}</td>
      {/* <td>{props.location}</td> */}
      {/* <td>{props.datePurchased.toString()}</td> */}

      <td>${props.value.toFixed(2)}</td>
      <td>
        <button onClick={() => props.deleteAssetRowHandler(props.id)}>X</button>
      </td>
    </tr>
  );
};

export default AssetRow;
