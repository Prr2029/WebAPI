import React from 'react'
import logo from './Images/logo.png'

export default function Logo() {
  return (
    <div>
      <div className="p-2 text-center">
     <img src={logo} className="logoStyle"/>
     <h4 className="navbar-brand text-light" href="/">Register Employee</h4>
    </div>
    </div>
  )
}
