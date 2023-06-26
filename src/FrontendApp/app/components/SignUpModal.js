import React from 'react';
import { AiOutlineClose } from 'react-icons/ai';

const SignUpModal = ({ onClose }) => {
  const handleClose = () => {
    onClose();
  };

  return (
    <div className='fixed inset-0 flex items-center justify-center bg-opacity-60 backdrop-filter backdrop-blur'>
      <div className='p-4 rounded-lg w-full md:w-1/4 shadow-lg bg-green'>
        <form>
          <h2>Sign Up</h2>
          <label>
            Email:
            <input type='email' name='email' required />
          </label>
          <label>
            Password:
            <input type='password' name='password' required />
          </label>
          <button type='submit'>Sign Up</button>
        </form>
        <AiOutlineClose onClick={handleClose} />
      </div>
    </div>
  );
};

export default SignUpModal;
