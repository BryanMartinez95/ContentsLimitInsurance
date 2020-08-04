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
    console.log(event.target.value);
    const updateValue =
      event.target.type === "number" && event.target.value != ""
        ? parseFloat(event.target.value)
        : event.target.value;

    setNewAssetState({
      ...newAsset,
      [event.target.name]: updateValue,
    });
  };

  const handleSubmit = (event) => {
    axios.post("Asset/CreateAsset", newAsset).then(
      (response) => {
        props.updateAssetList();

        //reset form
        setNewAssetState({
          ...newAssetTemplate,
          itemCategory: assetCategories.length > 0 ? assetCategories[0].id : "", //default item category to the first in the list
        });
      },
      (error) => {
        // console.log("error", error);
        alert(error);
      }
    );

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
      <div className="card">
        <header className="card-header is-dark">
          <h3 className="card-header-title">Add Asset</h3>
        </header>

        <div className="card-content">
          <div className="content">
            <div className="field">
              <label className="label">Name</label>
              <div className="control">
                <input
                  className="input"
                  type="text"
                  name="itemName"
                  placeholder="Name"
                  value={newAsset.itemName}
                  onChange={handleChange}
                />
              </div>
            </div>
            <div className="field">
              <label className="label">Value</label>
              <div className="control">
                <input
                  className="input"
                  type="number"
                  name="itemValue"
                  placeholder="Value"
                  value={newAsset.itemValue}
                  onChange={handleChange}
                ></input>
              </div>
            </div>

            <div className="field">
              <label className="label">Category</label>
              <div className="select">
                <select name="itemCategory" onChange={handleChange}>
                  {assetCategoriesOptions}
                </select>
              </div>
            </div>
          </div>
        </div>
        <footer className="card-footer level-right">
          <div className="field">
            <div className="control">
              <input
                className="button is-link"
                type="submit"
                value="Add"
                disabled={
                  newAsset.itemName == "" ||
                  newAsset.itemValue == "" ||
                  newAsset.Category == ""
                }
              />{" "}
            </div>
          </div>
        </footer>
      </div>
    </form>
  );
};

export default NewAssetForm;
