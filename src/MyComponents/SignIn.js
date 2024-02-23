import React, { useState } from "react";
//import logo from "./Images/LoginImage.png";
import { useNavigate } from "react-router-dom";
//import { useDispatch } from "react-redux";
import { toast } from 'react-toastify';
import axios from "axios";

const Login = () => {
  //const dispatch = useDispatch();
  const navigate = useNavigate();
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");

  const handleSubmit = () => {
    const loginInfo = { emailId: Email, password: Password };
    if (Email.length === 0) {
      toast.warn('Please enter your email');
    } else if (Password.length === 0) {
      toast.warn('Please enter your password');
    } else {
      axios.post("http://localhost:8080/signin", loginInfo)
        .then((result) => {
          if (result.status === 200) {
            toast.success('Logged in successfully');
            const token = { token: result.data.jwt };
            //dispatch(addUser(token));
            navigate("/");
          } else {
            toast.error('Mismatch error occurred');
          }
        })
        .catch((error) => {
          console.log(error);
          toast.error('An error occurred while logging in');
        });
    }
  };

  return (
    <div className="container">
      <div className="row">
        {/* <div className="col-md-6">
          <img src={logo} alt="" className="img-fluid" />
        </div> */}
        <div className="col-md-6 lead">
          <div>
            <h1 style={{ color: "rgb(189, 4, 4)" }} className="display-5">LOGIN HERE</h1>
            <div className="form-group my-3">
              <label htmlFor="exampleInputEmail1">Email address</label>
              <input type="email" className="form-control border-none" id="exampleInputEmail1" value={Email} onChange={e => setEmail(e.target.value)} placeholder="Enter Email" style={{ background: "none" }} />
            </div>
            <div className="form-group my-3">
              <label htmlFor="exampleInputPassword1">Password</label>
              <input type="password" className="form-control border-none" id="exampleInputPassword1" value={Password} onChange={e => setPassword(e.target.value)} placeholder="Enter Password" style={{ background: "none" }} />
            </div>
            <button className="my-4 btn btn-danger rounded-3" onClick={handleSubmit}>Submit</button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Login;
