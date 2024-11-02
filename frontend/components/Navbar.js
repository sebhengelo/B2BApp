import React from 'react';
import Link from 'next/link';

const Navbar = () => {
  return (
    <nav className="bg-gray-800 p-4">
      <div className="container mx-auto flex justify-between items-center">
        <div className="text-white text-lg font-bold">B2B SaaS Application</div>
        <div className="flex space-x-4">
          <Link href="/home">
            <a className="text-white">Home</a>
          </Link>
          <Link href="/insights">
            <a className="text-white">Insights</a>
          </Link>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
