import { FaHouseUser } from "react-icons/fa";
import Search from "./Search";
import LoginButton from "./LoginButton";

const Header = () => {
  return (
    <nav className="sticky top-0 z-50 flex items-center justify-between py-5 px-10 max-h-24 shadow-md">
      <div className="flex items-center gap-4 font-semibold">
        <FaHouseUser size={34} />
        <p>דירה להשכיר</p>
      </div>
      <Search />
      <LoginButton />
    </nav>
  );
};

export default Header;
