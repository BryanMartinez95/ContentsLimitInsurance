import React, { useState, useEffect } from "react";
import axios from "../../api";

const NewAssetForm = (props) => {
  const newAssetTemplate = {
    itemName: "",
    itemValue: "",
    itemCategory: "",
  };

  const [isLoading, setisLoadingState] = useState(true);
  const [assetCategories, setAssetCategoriesState] = useState([]);
  const [newAsset, setNewAssetState] = useState(newAssetTemplate);

  //Runs on page load
  //populates Asset Category list
  useEffect(() => {
    //todo add an if check to wait till this is populated, then load  the select.
    axios.get("AssetCategory/GetList").then((response) => {
      setAssetCategoriesState(response.data);
    });
  }, []);

  //once assetCategories is populated, set first category to default
  useEffect(() => {
    setNewAssetState({
      ...newAsset,
      itemCategory: assetCategories.length > 0 ? assetCategories[0].id : "", //default item category to the first in the list
    });
  }, [assetCategories]);

  const handleChange = (event) => {
    const updateValue =
      event.target.type === "number"
        ? parseFloat(event.target.value)
        : event.target.value;

    setNewAssetState({
      ...newAsset,
      [event.target.name]: updateValue,
    });
  };

  const handleSubmit = (event) => {
    axios.post("Asset/CreateAsset", newAsset).then((response) => {
      props.updateAssetList();

      //reset form
      setNewAssetState({
        ...newAssetTemplate,
        itemCategory: assetCategories.length > 0 ? assetCategories[0].id : "", //default item category to the first in the list
      });
    });

    event.preventDefault();
  };

  const assetCategoriesOptions = assetCategories.map((category, index) => {
    return (
      <option key={category.id} value={category.id}>
        {category.name}
      </option>
    );
  });

  return (
    <form onSubmit={handleSubmit}>
      <label>Name</label>
      <input
        type="text"
        name="itemName"
        value={newAsset.itemName}
        onChange={handleChange}
      />
      <label>Value</label>
      <input
        type="number"
        name="itemValue"
        value={newAsset.itemValue}
        onChange={handleChange}
      ></input>
      <label>Category</label>
      <select name="itemCategory" onChange={handleChange}>
        {assetCategoriesOptions}
      </select>
      <input type="submit" value="Add" />
    </form>
  );
};

export default NewAssetForm;
