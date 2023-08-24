'use client';

import React, { useState } from 'react';
import { AiOutlineClose } from 'react-icons/ai';
import IncorrectInputPopup from './IncorrectInputPopUp';

const LoginModal = ({ onClose }) => {
  const [showPopup, setShowPopup] = useState(false);

  const [formData, setFormData] = useState({
    username: '',
    password: '',
    repeat_password: '',
  });

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setFormData((prevState) => ({ ...prevState, [name]: value }));
  };

  const handleClose = () => {
    setShowPopup(false);
    onClose();
  };

  async function handleLogInSubmit(event) {
    event.preventDefault();
    try {
      if (!formData.username || !formData.password || !formData.repeat_password) {
        console.log('Data is wrong');
        setShowPopup(true);
        return;
      }

      let LogInData = {
        username: formData.username,
        password: formData.password,
        repeat_password: formData.repeat_password,
      };

      const res = await fetch('/', {
        method: 'POST',
        body: JSON.stringify(LogInData),
        headers: {
          'Content-Type': 'application/json',
        },
      });
    } catch (error) {
      console.error(`An error occurred while submitting the form: ${error.message}`);
    }
  }

  return (
    <div className="fixed inset-0 flex items-center justify-center bg-opacity-60 backdrop-filter backdrop-blur z-20">
      <div className="p-4 rounded-lg w-full md:w-1/4 shadow-lg bg-green flex flex-col">
        <AiOutlineClose
          onClick={handleClose}
          className="self-end cursor-pointer hover:bg-navy-blue text-3xl hover:rounded-full hover:text-green"
        />
        <form className="flex flex-col items-center" onSubmit={handleLogInSubmit}>
          <h2 className="text-navy-blue text-2xl font-bold">Log In</h2>
          <label className="text-navy-blue mt-4 text-2xl">Username</label>
          <input
            type="text"
            name="username"
            className="input-field h-8"
            required
            onChange={handleInputChange}
            value={formData.username}
          />
          <label className="text-navy-blue mt-4 text-2xl">Password</label>
          <input
            type="password"
            name="password"
            className="input-field h-8"
            required
            onChange={handleInputChange}
            value={formData.password}
          />
          <button
            type="submit"
            className="mt-6 px-4 py-2 rounded-full text-navy-blue font-bold bg-green hover:bg-navy-blue hover:text-green"
          >
            Log In
          </button>
        </form>
        {showPopup && <IncorrectInputPopup onClose={handleClose} />}
      </div>
    </div>
  );
};

export default LoginModal;
