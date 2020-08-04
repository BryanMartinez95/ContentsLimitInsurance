import React, { Fragment, useState, useEffect } from "react";
import AssetList from "../../components/Asset/AssetList";
import NewAssetForm from "../../components/Asset/NewAssetForm";
import axios from "../../api";

const Home = () => {
  const [assetGroupListState, setAssetListState] = useState([]);

  useEffect(() => {
    getAssetListHandler();
  }, []);

  const getAssetListHandler = () => {
    axios.get("Asset/GetAssetGroupList").then((response) => {
      setAssetListState(response.data);
    });
  };

  const deleteAssetRowHandler = (id) => {
    axios.delete("Asset/DeleteAsset/" + id).then((response) => {
      getAssetListHandler();
    });
  };

  return (
    <Fragment>
      <div className="container">
        <h4 className="title is-4">Asset Inventory List</h4>
        <AssetList
          assetGroupList={assetGroupListState}
          deleteAssetRowHandler={deleteAssetRowHandler}
        ></AssetList>
      </div>
      <br />
      <div className="container">
        {/* <div className="column is-12"> */}
        <NewAssetForm updateAssetList={getAssetListHandler}></NewAssetForm>
        {/* </div> */}
      </div>
    </Fragment>
  );
};

export default Home;
