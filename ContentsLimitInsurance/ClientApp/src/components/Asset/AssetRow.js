import React from "react";

const AssetRow = (props) => {
  return (
    <tr>
      <td></td>
      <td>{props.name}</td>
      {/* <td>{props.location}</td> */}
      {/* <td>{props.datePurchased.toString()}</td> */}

      <td>
        <span className="is-pulled-right">${props.value.toFixed(2)}</span>
      </td>
      <td>
        <button
          className="delete is-pulled-right"
          onClick={() => props.deleteAssetRowHandler(props.id)}
        ></button>
      </td>
    </tr>
  );
};

export default AssetRow;
