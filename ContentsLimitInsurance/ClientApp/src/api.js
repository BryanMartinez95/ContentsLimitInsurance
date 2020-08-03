import axios from 'axios';

const IS_PROD = process.env.NODE_ENV === 'production';

const SERVER_URL = IS_PROD ? 'https://contentslimitinsurance20200731222609.azurewebsites.net' : 'https://localhost:44326';

const instance = axios.create({
    baseURL: SERVER_URL,
    headers: {'Content-Type': 'application/json;charset=utf-8'}
});

export default instance;