
import HamburgerMenu from './HamburgerMenu';
import SearchBar from './SearchBar';
import LogIn from './LogIn';

function Header() {
  return (
    <section className="flex justify-between items-center h-14 bg-green px-4">
      <div className="flex items-center space-x-2">
        <HamburgerMenu/>
      </div>
    <SearchBar />
    <LogIn />
    </section>
  );
}

export default Header;
