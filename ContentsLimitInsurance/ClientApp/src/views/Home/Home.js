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
      <AssetList
        assetGroupList={assetGroupListState}
        deleteAssetRowHandler={deleteAssetRowHandler}
      ></AssetList>
      <NewAssetForm updateAssetList={getAssetListHandler}></NewAssetForm>
    </Fragment>
  );
};

export default Home;
