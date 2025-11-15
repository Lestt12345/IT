import { useState } from 'react'
import './App.css'
import Header from './components/Header'
import useWindowWidth from './hooks/useWindowWidth'
import { FaUser } from "react-icons/fa";
import head_img from './assets/head_img.png'
import head_img1 from './assets/head_img1.png'
import banner_img from './assets/banner_img.png'
import banner_pic1 from './assets/banner_pic1.png'
import banner_pic2 from './assets/banner_pic2.png'
import fix_arrow from './assets/fix_arrow.png'
import { FaChevronDown } from "react-icons/fa";
import './styles/scrollbar.css'

function BounceButtonBanner({text, startTextColor, endTextColor, componentBefore}) {
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

function BounceButton({text, startTextColor, endTextColor, componentBefore, isKick}) {
  const [hovered, setHovered] = useState(false);

  return (
    <button
      className="relative overflow-hidden"
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
    >
      <span
        className={`relative transition-colors duration-200 ease-in-out gap-2 flex items-center px-[23px] py-[8px] overflow-hidden border ${isKick ? 'border-2 border-t-[#B1BEFF] border-b-[#9EE7FF] border-x-gradient' : ''} rounded-md bg-gradient-to-r ${isKick ? 'from-transparent to-transparent' : 'from-[#12C5FF] to-[#4565FF]'}`}
        style={{ color: hovered ? endTextColor : startTextColor }}
      >
        <span className="gap-1 flex items-center relative z-10">{componentBefore}
        {text}</span>
        <span
            className={`absolute inset-0 scale-x-0 bg-gradient-to-r ${isKick ? 'from-[#10C5FF] to-[#4564FF]' : 'from-[#FFDC77] to-[#FFB95E]'}`}
            style={{
            transformOrigin: "left",
            animation: hovered ? (isKick ? "fill-bounce-kick 0.8s forwards" : "fill-bounce 0.5s forwards") : "none",
            }}
        ></span>
      </span>
    </button>
  );
}

function App() {
  const windowWidth = useWindowWidth();

  return (
    <>
      <div className="w-full flex flex-col justify-center items-center">
        <div className={`bg-[#01092E] w-full flex flex-col justify-center items-center relative overflow-x-hidden ${windowWidth < 992 ? 'text-center' : ''}`}>
          <div className="contentWidth z-[2] relative overflow-hidden">
            <Header />
            <div className="banner-text mt-16">
              <h5 className={`flex items-center ${windowWidth < 992 ? 'justify-center' : ''}`}><img src={head_img} alt="" /><span className="text-white text-sm ml-[-5px]">WELCOME TO BitBullMining</span></h5>
              <h1 className="text-white font-bold text-[45px] leading-[1.2]">Powerful AI Mining Solutions Skyrocketing Earnings in</h1>
              <p className="text-white text-sm mt-2 leading-[2]">BitBullMining, established in 2022, is dedicated to delivering world-class cloud mining solutions. The company is officially registered in the United Kingdom under registration With a strong emphasis on technological innovation, transparency, and reliability, we have achieved rapid global expansion.</p>
              <p className="underline_">----------</p>
              <button className="banner_link">[Sign Up] Start Mining Doge Coin Now</button>
              <p className="h-[35px]"></p>
              <BounceButtonBanner text="Sign Up" startTextColor="white" endTextColor="white" componentBefore={<FaUser />} isKick={true} />
              {windowWidth >= 992 ? <div className="col-lg-6"><img src={banner_img} alt="" className="banner_image" /></div> : null}
            </div>
            <div onClick={() => window.scrollTo({ top: document.getElementById('plan').offsetTop, behavior: 'smooth' })} className="w-full flex justify-center pt-3 align-center relative cursor-pointer"><img className="fa-chevron-down-img" src={fix_arrow} alt="" /><span className={`absolute top-1/2 left-1/2 transform -translate-x-1/2 ${windowWidth < 992 ? '-translate-y-3' : '-translate-y-4'}`}><FaChevronDown /></span></div>
          </div>
          <img src={banner_pic2} alt="" className="ban_pic2" />
          <img src={banner_pic1} alt="" className="ban_pic1" />
        </div>
        <div id="plan" className="contentWidth h-[100vh] pt-[50px] pb-[20px]">
          <div className="heading">
            <div className='head'>
              <h5 className={`flex items-center ${windowWidth < 992 ? 'justify-center' : ''}`}><img src={head_img1} alt="" /><span className="text-black text-[16px]">COMPANY PLANS</span></h5>
              <h2 className='leading-[1.2]'>Investment Offers</h2>
            </div>
            <div className="head">
              <p>You can sit back and relax while BTCSmartMine AI does the work to mine Dogecoin for you</p>
              <BounceButton text="Create Account" startTextColor="white" endTextColor="white" isKick={false} />
            </div>
          </div>
        </div>
      </div>
      
    </>
  )
}

export default App
