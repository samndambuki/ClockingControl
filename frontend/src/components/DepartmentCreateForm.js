import React, { useState } from "react";
import Constants from "../utilities/Constants";

export default function DepartmentCreateForm(props) {
  const initialFormData = Object.freeze({
    departmentName: "Enter the department name",
  });
  const [formData, setFormData] = useState(initialFormData);

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const departmentToCreate = {
      departmentId: 0,
      departmentName: formData.departmentName,
    };

    const url = Constants.API_URL_UPDATE_DEPARTMENT;

    fetch(url, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(departmentToCreate),
    })
      .then((response) => response.json())
      .then((responseFromServer) => {
        console.log(responseFromServer);
      })
      .catch((error) => {
        console.log(error);
        alert(error);
      });

    props.onDepartmentCreated(departmentToCreate);
  };

  return (
    <form className="w-100 px-5">
      <h1 className="mt-5">Create New Department</h1>
      <div className="mt-5">
        <label className="h3 form-label ">Department Name</label>
        <input
          value={formData.departmentName}
          name="departmentName"
          type="text"
          className="form-control"
          onChange={handleChange}
        ></input>

        <button
          onClick={handleSubmit}
          className="btn btn-dark btn-lg w-100 mt-5"
        >
          Submit
        </button>
        <button
          onClick={() => props.onDepartmentCreated(null)}
          className="btn btn-secondary btn-lg w-100 mt-3"
        >
          Cancel
        </button>
      </div>
    </form>
  );
}
