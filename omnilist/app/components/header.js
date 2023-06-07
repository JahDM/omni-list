
import { AiOutlineSearch } from 'react-icons/ai';

function Header() {
  return (
    <section className="flex justify-between items-center h-14 bg-green px-4">
      <div className="flex items-center space-x-2">
        <div className="text-2xl cursor-pointer">&#9776;</div>
        <div className="text-lg cursor-pointer">Menu</div>
      </div>
      <div className="flex items-center space-x-2">
        <div className="bg-white rounded-md p-2 flex items-center">
          <input
            type="text"
            placeholder="Search"
            className="outline-none border-none bg-transparent w-96"
          />
          <AiOutlineSearch className="text-gray-400" />
        </div>
      </div>
    </section>
  );
}

export default Header;
