import './Header.css'
import { Link } from 'react-router-dom';
import useWindowWidth from '../hooks/useWindowWidth';
import { useState } from 'react';
import { FaUser } from "react-icons/fa";
import { FaRightFromBracket } from "react-icons/fa6";
import { RxHamburgerMenu } from "react-icons/rx";
import logo from '../assets/headd.png'

function BounceButton({text, startTextColor, endTextColor, componentBefore}) {
  const [hovered, setHovered] = useState(false);

  return (
    <button
      className="relative overflow-hidden"
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
    >
      <span
        className="relative transition-colors duration-200 ease-in-out gap-2 flex items-center px-[16px] py-[6px] overflow-hidden border rounded-md bg-gradient-to-t from-[#FDD15A] to-[#FDB04F]"
        style={{ color: hovered ? endTextColor : startTextColor }}
      >
        <span className="gap-1 flex items-center relative z-10">{componentBefore}
        {text}</span>
        <span
            className="absolute inset-0 bg-blue-400 scale-x-0 bg-gradient-to-r from-[#11C5FF] to-[#4465FF]"
            style={{
            transformOrigin: "left",
            animation: hovered ? "fill-bounce-header 0.8s forwards" : "none",
            }}
        ></span>
      </span>
    </button>
  );
}

function BounceButtonNav({text}) {
  const [hovered, setHovered] = useState(false);
  const isMobile = useWindowWidth() < 992;

  return (
    <button
      className="relative overflow-hidden"
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
    >
      <span
        className={`relative transition-colors duration-200 ease-in-out gap-2 flex items-center text-white ${isMobile ? 'py-[8px] text-sm' : 'py-[8px] px-[13px]'}`}
      >
        <span className="gap-1 flex items-center relative z-10">{text}</span>
        <span
            className="h-[2px] mt-[33px] absolute inset-0 bg-blue-400 scale-x-0 bg-gradient-to-r from-[#11C5FF] to-[#4465FF]"
            style={{
            transformOrigin: "left",
            animation: hovered ? "fill-bounce-nav 0.3s forwards" : "none",
            }}
        ></span>
      </span>
    </button>
  );
}

function Header() {
    const windowWidth = useWindowWidth();
    const [isLogined, setIsLogined] = useState(localStorage.getItem('isLogined') || false);
    const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);

    return (
        <header className="pt-[22px]">
            {windowWidth >= 992 ? 
            <div className="w-full flex items-start justify-between p-3">
                <Link to="/"><img src={logo} alt="logo" style={{width: '150px'}} /></Link>
                <nav className="flex items-center">
                    <Link to="#"><BounceButtonNav text="Home" /></Link>
                    <Link to="#"><BounceButtonNav text="About" /></Link>
                    <Link to="#"><BounceButtonNav text="Bonus" /></Link>
                    <Link to="#"><BounceButtonNav text="Faq" /></Link>
                    <Link to="#"><BounceButtonNav text="How to Start" /></Link>
                    <Link to="#"><BounceButtonNav text="Terms" /></Link>
                    <Link to="#"><BounceButtonNav text="Contact" /></Link>
                    {isLogined ? (
                        <div className="flex items-center bg-[#24A3FF] rounded-lg px-[14px] py-[8px] gap-3">
                            <Link to="#"><BounceButton text="Account" startTextColor="black" endTextColor="white" componentBefore={<FaUser />} /></Link>
                            <Link className="text-white gap-2 flex items-center hover:text-black" to="#"><FaRightFromBracket /> Log out</Link>
                            
                        </div>
                    ) : (
                        <div className="flex items-center bg-[#24A3FF] rounded-lg px-[14px] py-[8px] gap-3">
                            <Link to="#"><BounceButton text="Sign up" startTextColor="black" endTextColor="white" componentBefore={<FaUser />} /></Link>
                            <Link className="text-white gap-1 flex items-center hover:text-black" to="#"><FaRightFromBracket /> Log in</Link>
                            
                        </div>
                    )}
                </nav>
                
            </div> : 
            <div className={`w-full ${windowWidth < 768 ? 'px-6' : ''}`}>
                <div className="flex items-start justify-between">
                    <Link to="/"><img src={logo} alt="logo" style={{width: '90px'}} /></Link>
                    <button className="px-[10px] py-[8px] focus:px-[8px] focus:py-[6px] bg-white rounded-md focus:border-2 transition-colors duration-500 focus:border-yellow-500" onClick={() => setIsMobileMenuOpen(!isMobileMenuOpen)}><RxHamburgerMenu className="text-gray-500 w-[22px] h-[22px]" /></button>
                </div>
                <div 
                    className={`overflow-hidden transition-[max-height,opacity,transform] duration-500 ease-out transform origin-top ${isMobileMenuOpen ? 'max-h-[500px] opacity-100 scale-y-100' : 'max-h-0 opacity-0 scale-y-0'}`}
                    >
                    <nav className="flex flex-col items-center w-full">
                        <Link to="#"><BounceButtonNav text="Home" /></Link>
                        <Link to="#"><BounceButtonNav text="About" /></Link>
                        <Link to="#"><BounceButtonNav text="Bonus" /></Link>
                        <Link to="#"><BounceButtonNav text="Faq" /></Link>
                        <Link to="#"><BounceButtonNav text="How to Start" /></Link>
                        <Link to="#"><BounceButtonNav text="Terms" /></Link>
                        <Link to="#"><BounceButtonNav text="Contact" /></Link>

                        {isLogined ? (
                        <div className="flex w-full justify-between items-center bg-[#24A3FF] rounded-lg px-[14px] py-[8px] gap-3 mt-2">
                            <Link to="#"><BounceButton text="Account" startTextColor="black" endTextColor="white" componentBefore={<FaUser />} /></Link>
                            <Link className="text-white gap-2 flex items-center hover:text-black" to="#"><FaRightFromBracket /> Log out</Link>
                        </div>
                        ) : (
                        <div className="flex w-full justify-between items-center bg-[#24A3FF] rounded-lg px-[14px] py-[8px] gap-3 mt-2">
                            <Link to="#"><BounceButton text="Sign up" startTextColor="black" endTextColor="white" componentBefore={<FaUser />} /></Link>
                            <Link className="text-white gap-1 flex items-center hover:text-black" to="#"><FaRightFromBracket className="text-white " /> Log in</Link>
                        </div>
                        )}
                    </nav>
                    </div>

            </div>}
        </header>
    )
}

export default Header
