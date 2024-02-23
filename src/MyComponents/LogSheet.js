import React, { useState } from "react";
import { useNavigate } from 'react-router-dom'
import axios from "axios";
import { toast } from 'react-toastify';


export default function LogSheet() {
    const navigate = useNavigate();
    const [formData, setFormData] = useState({
        DateTime: "",
        Type: "",
    });
    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };
    function getDate() {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth()+1; //January is 0!
        var yyyy = today.getFullYear();
      
        if(dd<10) {
            dd = '0'+dd
        } 
      
        if(mm<10) {
            mm = '0'+mm
        } 
      
        today = yyyy + '/' + mm + '/' + dd;
        console.log(today);
        document.getElementById("inputDateTime").value = today;
      }
      window.onload = function() {
        getDate();
      };

      const handleSubmit = () => {
        axios.post("http://localhost:8080/logsheet", formData)
            .then((response) => {
                if (response.status === 201) {
                    toast.success('Signup successful');
                    sessionStorage.setItem('token', response.data);
                    navigate("/signin");
                } else {
                    toast.error('Something went wrong. Please try again.');
                }
            })
            .catch(() => {
                toast.error('Some error occurred');
            });
    };
  return (
    <div className="container">
    <div className="row">
      {/* <div className="col-md-6">
        <img src={logo} alt="" className="img-fluid" />
      </div> */}
      <div className="col-md-6 lead">
        <div>
          <h1 style={{ color: "rgb(189, 4, 4)" }} className="display-5">Add Timesheet Entry</h1>
          <div className="form-group my-3">
            <label htmlFor="inputDateTime">Select date and time</label>
            <input type="datetime-local" className="form-control border-none" id="inputDateTime" value={formData.DateTime} onChange={handleChange} onLoad="getDate()" style={{ background: "none" }} />
          </div>
          <div className="form-group my-3">
                            <label htmlFor="Type">Entry Type</label>
                            <select className="form-control" id="type" name="type" value={formData.Type} onChange={handleChange}>
                                <option value="">Select Type</option>
                                <option value="Type_Theory">Theory</option>
                                <option value="Type_Lab">Lab</option>
                            </select>
           </div>
          <div className="form-group my-3">
            <label htmlFor="CourseModule">Add Course and Module</label>
            <link href="/courseModule" ></link>
          </div>
          <button className="my-4 btn btn-danger rounded-3" onClick={handleSubmit}>Add</button>
          <button className="my-4 btn btn-danger rounded-3" onClick={handleSubmit}>Cancel</button>
        </div>
      </div>
    </div>
  </div>
  )
}
