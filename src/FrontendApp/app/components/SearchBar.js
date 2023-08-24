'use client';

import { AiOutlineSearch } from 'react-icons/ai';

function SearchBar() {

  return (
    <div className='flex items-center space-x-2'>
      <div className='bg-white rounded-md p-2 flex items-center'>
        <input
          type='text'
          placeholder='Search'
          className='outline-none border-none bg-transparent w-96'
        />
        <AiOutlineSearch className='text-gray-400'
        />
      </div>
    </div>
  );
}


export default SearchBar;
