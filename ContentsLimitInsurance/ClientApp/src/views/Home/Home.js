import React, { Fragment, useState, useEffect } from 'react';

import AssetList from '../../components/Asset/AssetList';
import AssetGroupSelector from '../../components/Asset/AssetGroupSelector';
import NewAsset from '../../components/Asset/NewAsset';

import axios from '../../api'

const Home = props => {
  const [assetListState,setAssetListState] = useState([]);

  useEffect(() => {
    axios.get('Asset')
    .then((response) => {
      setAssetListState(response.data);
    });
  },[]);


  useEffect(() => {
      console.log(assetListState);
  },[assetListState]);


  
    const assetGroupSelectorHandler = (group,id) => {
        console.log('??',group,id);
    }



  return (
      <Fragment>
          <AssetGroupSelector change={() => assetGroupSelectorHandler}></AssetGroupSelector>
           <AssetList inventoryGroups={assetListState} 
              groupBy={assetListState.groupBy}>
          </AssetList>
          <NewAsset></NewAsset>

      </Fragment>
  );
};

export default Home;