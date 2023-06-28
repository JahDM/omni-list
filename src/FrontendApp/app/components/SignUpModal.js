'use client'

import React from 'react';
import { AiOutlineClose } from 'react-icons/ai';

const SignUpModal = ({ onClose }) => {
  const handleClose = () => {
    onClose();
  };

  return (
<div className='fixed inset-0 flex items-center justify-center bg-opacity-60 backdrop-filter backdrop-blur z-20'>
  <div className='p-4 rounded-lg w-full md:w-1/4 shadow-lg bg-green flex flex-col'>
    <AiOutlineClose
      onClick={handleClose}
      className='self-end cursor-pointer hover:bg-navy-blue text-3xl hover:rounded-full hover:text-green'
    />
    <form className='flex flex-col items-center'>
      <h2 className='text-navy-blue text-2xl font-bold'>Sign Up</h2>
      <label className='text-navy-blue mt-4'/>
        Email:
        <input type='email' name='email' className='input-field' required />
      
      <label className='text-navy-blue mt-4'/>
        Password:
        <input type='password' name='password' className='input-field' required />

      <label className='text-navy-blue mt-4'/>
        Repeat Password:
        <input type='password' name='password' className='input-field' required />

      <button
        type='submit'
        className='mt-6 px-4 py-2 rounded-full text-navy-blue font-bold bg-green hover:bg-navy-blue hover:text-green'
      >
        Sign Up
      </button>
    </form>
  </div>
</div>
  
  );
};

export default SignUpModal;
