import axios from "axios";

export const PROJECTS_CLIENT = axios.create({
  baseURL: 'https://localhost:7059/',
  withCredentials: true,
  headers: {
    'Access-Control-Allow-Origin' : '*',
    'Access-Control-Allow-Methods':'GET,PUT,POST,DELETE,PATCH,OPTIONS',
    'Content-Type' : 'application/x-www-form-urlencoded; charset=UTF-8;application/json',
  }
});