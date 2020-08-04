import axios from "axios";

const IS_PROD = process.env.NODE_ENV === "production";

const SERVER_URL = IS_PROD
    ? "https://contentslimitinsurance20200803193134.azurewebsites.net/api"
  : "https://localhost:44326/api";

const instance = axios.create({
  baseURL: SERVER_URL,
  headers: { "Content-Type": "application/json;charset=utf-8" },
});

export default instance;
