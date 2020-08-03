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
    axios.get("Asset").then((response) => {
      console.log("getresposne", response.data);
      setAssetListState(response.data);
    });
  };

  const deleteAssetRowHandler = (id) => {
    axios.delete("Asset/" + id).then((response) => {
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
