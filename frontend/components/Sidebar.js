import React from 'react';
import Link from 'next/link';

const Sidebar = () => {
  return (
    <div className="bg-gray-800 text-white w-64 min-h-screen p-4">
      <div className="text-lg font-bold mb-4">Menu</div>
      <ul>
        <li className="mb-2">
          <Link href="/home">
            <a className="text-white">Home</a>
          </Link>
        </li>
        <li className="mb-2">
          <Link href="/insights">
            <a className="text-white">Insights</a>
          </Link>
        </li>
      </ul>
    </div>
  );
};

export default Sidebar;
