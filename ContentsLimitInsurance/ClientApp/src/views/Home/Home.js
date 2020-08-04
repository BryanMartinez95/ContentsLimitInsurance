import React, { Fragment, useState, useEffect } from "react";
import AssetList from "../../components/Asset/AssetList";
import NewAssetForm from "../../components/Asset/NewAssetForm";
import axios from "../../api";
import Spinner from "../../components/UI/Spinner";

const Home = () => {
  const [assetGroupListState, setAssetListState] = useState([]);
  const [loading, setLoadingState] = useState(true);

  useEffect(() => {
    setLoadingState(true);
    getAssetListHandler();
  }, []);

  const getAssetListHandler = () => {
    axios.get("Asset/GetAssetGroupList").then((response) => {
      setAssetListState(response.data);
      setLoadingState(false);
    });
  };

  const deleteAssetRowHandler = (id) => {
    setLoadingState(true);
    axios.delete("Asset/DeleteAsset/" + id).then((response) => {
      getAssetListHandler();
    });
  };

  let assetListComponent = <Spinner />;

  if (!loading) {
    assetListComponent = (
      <AssetList
        assetGroupList={assetGroupListState}
        deleteAssetRowHandler={deleteAssetRowHandler}
      ></AssetList>
    );
  }

  return (
    <Fragment>
      <div className="container">
        <h4 className="title is-4">Asset Inventory List</h4>
        {assetListComponent}
      </div>
      <br />
      <div className="container">
        <NewAssetForm updateAssetList={getAssetListHandler}></NewAssetForm>
      </div>
    </Fragment>
  );
};

export default Home;
