const API_BASE_URL_DEVELOPMENT = "https://localhost:7218";
const API_BASE_URL_PRODUCTION = "https://appname.azurewebsites.net";

const ENDPOINTS = {
  GET_ALL_STAFFS: "get-all-staffs",
  GET_STAFF_BY_ID: "get-staff-by-id",
  CREATE_STAFF: "create-staff",
  UPDATE_STAFF: "update-staff",
  DELETE_STAFF_BY_ID: "delete-staff-by-id",
  GET_ALL_DEPARTMENTS: "get-all-departments",
  GET_DEPARTMENT_BY_ID: "get-department-by-id",
  CREATE_DEPARTMENT: "create-department",
  UPDATE_DEPARTMENT: "update-department",
  DELETE_DEPARTMENT_BY_ID: "delete-department-by-id",
};

const development = {
  API_URL_GET_ALL_STAFFS: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_ALL_STAFFS}`,
  API_URL_GET_USER_BY_ID: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_STAFF_BY_ID}`,
  API_URL_CREATE_STAFF: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.CREATE_STAFF}`,
  API_URL_UPDATE_STAFF: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.UPDATE_STAFF}`,
  API_URL_DELETE_STAFF_BY_ID: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.DELETE_STAFF_BY_ID}`,
  API_URL_GET_ALL_DEPARTMENTS: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_ALL_DEPARTMENTS}`,
  API_URL_GET_DEPARTMENT_BY_ID: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_DEPARTMENT_BY_ID}`,
  API_URL_UPDATE_DEPARTMENT: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.CREATE_DEPARTMENT}`,
  API_URL_UPDATE__DEPARTMENT: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.UPDATE_DEPARTMENT}`,
  API_URL_DELETE_DEPARTMENT_BY_ID: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.DELETE_DEPARTMENT_BY_ID}`,
};

const production = {
  API_URL_GET_ALL_STAFFS: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.GET_ALL_STAFFS}`,
  API_URL_GET_USER_BY_ID: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.GET_STAFF_BY_ID}`,
  API_URL_CREATE_STAFF: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.CREATE_STAFF}`,
  API_URL_UPDATE_STAFF: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.UPDATE_STAFF}`,
  API_URL_DELETE_USER_BY_ID: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.DELETE_STAFF_BY_ID}`,
  API_URL_GET_ALL_DEPARTMENTS: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.GET_ALL_DEPARTMENTS}`,
  API_URL_GET_DEPARTMENT_BY_ID: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.GET_DEPARTMENT_BY_ID}`,
  API_URL_UPDATE_DEPARTMENT: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.CREATE_DEPARTMENT}`,
  API_URL_UPDATE__DEPARTMENT: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.UPDATE_DEPARTMENT}`,
  API_URL_DELETE_DEPARTMENT_BY_ID: `${API_BASE_URL_PRODUCTION}/${ENDPOINTS.DELETE_DEPARTMENT_BY_ID}`,
};

const Constants =
  process.env.NODE_ENV === `development` ? development : production;

export default Constants;
