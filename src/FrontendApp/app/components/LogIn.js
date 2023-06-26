'use client'

import React, { useState } from 'react';
import LoginModal from './LogInModal';
import SignUpModal from './SignUpModal';

const LogIn = () => {
  const [isLogInModalOpen, setIsLogInModalOpen] = useState(false);
  const [isSignUpModalOpen, setIsSignUpModalOpen] = useState(false);

  const handleLogInOpenModal = () => {
    setIsLogInModalOpen(true);
    console.log('Log In Modal is visible');
  };

  const handleLogInCloseModal = () => {
    setIsLogInModalOpen(false);
    console.log('Log In Modal is invisible');
  };

  const handleSignUpOpenModal = () => {
    setIsSignUpModalOpen(true);
    console.log('Signup Modal is visible');
  };
  
  const handleSignUpCloseModal = () => {
    setIsSignUpModalOpen(false);
    console.log('Signup Modal is invisible');
  };
  return (
    <section className="flex gap-2">
      <button
        className="p-2 border-2 w-24 border-solid border-navy-blue rounded-lg text-navy-blue font-extrabold hover:bg-navy-blue hover:text-green"
        onClick={handleLogInOpenModal}
      >
        Log In
      </button>
      <button
        className="p-2 border-2 w-24 border-solid border-navy-blue rounded-lg text-navy-blue font-extrabold hover:bg-navy-blue hover:text-green"
        onClick={handleSignUpOpenModal}
      >
        Sign In
      </button>

      {isLogInModalOpen && <LoginModal onClose={handleLogInCloseModal} />
      }
      {isSignUpModalOpen && <SignUpModal onClose={handleSignUpCloseModal} />
      }
    </section>
  );
};

export default LogIn;
