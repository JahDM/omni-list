'use client';
import { useState } from 'react';
import Link from 'next/link';

function HamburgerMenu() {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const handleMenuToggle = () => {
    setIsMenuOpen(!isMenuOpen);
  };

  return (
    <section
      className="relative"
      onMouseEnter={handleMenuToggle}
    >
      <div className="cursor-pointer text-2xl">&#9776;</div>
      {isMenuOpen && (
        <nav
          className="absolute top-8 left-0 bg-green p-2 rounded-md z-10"
          onMouseLeave={handleMenuToggle}
        >
          <ul className="w-80 p-4">
            <li className="text-2xl">
              <Link href="/">Films</Link>
            </li>
            <div className="invisible h-2"></div>
            <li className="text-2xl">
              <Link href="/">TV Series</Link>
            </li>
            <div className="invisible h-2"></div>
            <li className="text-2xl">
              <Link href="/">Games</Link>
            </li>
            <div className="invisible h-2"></div>
            <li className="text-2xl">
              <Link href="/">Books</Link>
            </li>
          </ul>
        </nav>
      )}
    </section>
  );
}

export default HamburgerMenu;
