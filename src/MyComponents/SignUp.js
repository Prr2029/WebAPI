import React, { useState } from "react";
//import logo from "./Images/logo.png";
import { useNavigate } from "react-router-dom";
import { toast } from 'react-toastify';
import axios from "axios";

const Registration = () => {
    const navigate = useNavigate();
    const [formData, setFormData] = useState({
        Name: "",
        Email: "",
        Age: "",
        Address: "",
        MobileNo: "",
        Password: "",
        Gender: "",
        Role: ""
    });

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleSubmit = () => {
        axios.post("http://localhost:3000/signup", formData)
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
                    <img src={logo} alt="" className="img-fluid"/>
                </div> */}
                <div className="col-md-6 lead">
                    <div>
                        <h1 style={{ color: "#bd0404" }} className="display-5">SIGNUP</h1>
                        <div className="form-group my-3">
                            <label htmlFor="Name">Name</label>
                            <input type="text" className="form-control" id="Name" name="Name" value={formData.Name} onChange={handleChange} placeholder="Enter Name"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Age">Age</label>
                            <input type="number" className="form-control" id="Age" name="Age" value={formData.Age} onChange={handleChange} placeholder="Enter Age"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Address">Address</label>
                            <input type="text" className="form-control" id="Address" name="Address" value={formData.Address} onChange={handleChange} placeholder="Enter Address"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Email">Email</label>
                            <input type="email" className="form-control" id="Email" name="Email" value={formData.Email} onChange={handleChange} placeholder="Enter Email"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="MobileNo">Phone Number</label>
                            <input type="text" className="form-control" id="MobileNo" name="MobileNo" value={formData.MobileNo} onChange={handleChange} placeholder="Enter Phone Number"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Password">Password</label>
                            <input type="password" className="form-control" id="Password" name="Password" value={formData.Password} onChange={handleChange} placeholder="Enter Password"/>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Gender">Gender</label>
                            <select className="form-control" id="Gender" name="Gender" value={formData.Gender} onChange={handleChange}>
                                <option value="">Select Gender</option>
                                <option value="MALE">Male</option>
                                <option value="FEMALE">Female</option>
                                <option value="OTHER">Other</option>
                            </select>
                        </div>
                        <div className="form-group my-3">
                            <label htmlFor="Role">Role</label>
                            <select className="form-control" id="Role" name="Role" value={formData.Role} onChange={handleChange}>
                                <option value="">Select Role</option>
                                <option value="ROLE_ADMIN">Admin</option>
                                <option value="ROLE_USER">User</option>
                            </select>
                        </div>
                        <button className="my-4 btn rounded-3 text-white" style={{ backgroundColor: "#a30617" }} onClick={handleSubmit}>Sign up</button>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Registration;
