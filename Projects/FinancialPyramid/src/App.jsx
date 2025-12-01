import { useEffect, useState } from 'react'
import './App.css'
import Header from './components/Header/Header'
import Footer from './components/Footer/Footer'
import useWindowWidth from './hooks/useWindowWidth'
import head_img from './assets/head_img.png'
import head_img1 from './assets/head_img1.png'
import banner_pic1 from './assets/banner_pic1.png'
import banner_pic2 from './assets/banner_pic2.png'
import fix_arrow from './assets/fix_arrow.png'
import { FaChevronDown } from "react-icons/fa";
import './styles/scrollbar.css'
import plan_icon from './assets/plan_icon.png'
import plan_icon1 from './assets/plan_icon1.png'
import plan_icon2 from './assets/plan_icon2.png'
import vector_icon from './assets/vector_icon.png'
import refer_video_img from './assets/refer_video_img.jpg'
import stat_img1 from './assets/stat_img1.png'
import stat_img2 from './assets/stat_img2.png'
import stat_img3 from './assets/stat_img3.png'
import stat_img4 from './assets/stat_img4.png'
import secu_icon1 from './assets/secu_icon1.png'
import secu_icon2 from './assets/secu_icon2.png'
import secu_icon3 from './assets/secu_icon3.png'
import { useRef } from 'react';
import { Link } from 'react-router-dom';
import cert_icon from './assets/cert_icon.png'
import cert_img from './assets/cert_img.png'
import { Fancybox } from "@fancyapps/ui";
import "@fancyapps/ui/dist/fancybox/fancybox.css";
import ScrollUpBtn from './components/ScrollUpBtn/ScrollUpBtn'
import useSmoothScroll from './hooks/useSmoothScroll'
import Bitcoin from './assets/Bitcoin.png'
import Dash from './assets/Dash.png'
import Dogecoin from './assets/Dogecoin.png'
import EPayCore from './assets/EPayCore.png'
import Etherium from './assets/Etherium.png'
import Litecoin from './assets/Litecoin.png'
import Ripple from './assets/Ripple.png'
import Stellar from './assets/Stellar.png'
import Tether from './assets/Tether.png'
import Tron from './assets/Tron.png'
import trans_vector_img from './assets/trans_vector_img.png'
import PaymentCarousel from './components/PaymentCarousel/PaymentCarousel'
import instantValueImg from './assets/instantValue.png'
import noLimitsImg from './assets/noLimits.jpg'
import _30daysCreditingImg from './assets/30dayCrediting.jpg'
import { FaCheck } from "react-icons/fa6";

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

function BounceButton({text, startTextColor, endTextColor, componentBefore, componentAfter, isKick}) {
  const [hovered, setHovered] = useState(false);

  return (
    <button
      className="relative overflow-hidden"
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
    >
      <span
        className={`relative transition-colors duration-200 ease-in-out gap-2 flex items-center px-[23px] py-[8px] overflow-hidden border ${!isKick ? 'border-2 border-t-[#B1BEFF] border-b-[#9EE7FF] border-x-gradient' : ''} rounded-md bg-gradient-to-r ${!isKick ? 'from-transparent to-transparent' : 'from-[#12C5FF] to-[#4565FF]'}`}
        style={{ color: hovered ? endTextColor : startTextColor }}
      >
        <span className="gap-1 flex items-center relative z-10">
          {componentBefore}
          {text}
          {componentAfter}
        </span>
        <span
            className={`absolute inset-0 scale-x-0 bg-gradient-to-r ${!isKick ? 'from-[#10C5FF] to-[#4564FF] ml-[2px]' : 'from-[#FFDC77] to-[#FFB95E]'}`}
            style={{
            transformOrigin: "left",
            animation: hovered ? (isKick ? "fill-bounce-kick 0.8s forwards" : "fill-bounce 0.5s forwards") : "none",
            }}
        ></span>
      </span>
    </button>
  );
}

function PaymentIcon({ paymentMethod }) {
  const iconMap = {
    "Bitcoin": Bitcoin,
    "Dash": Dash,
    "Dogecoin": Dogecoin,
    "EPayCore": EPayCore,
    "Etherium": Etherium,
    "Litecoin": Litecoin,
    "Ripple": Ripple,
    "Stellar": Stellar,
    "Tether": Tether,
    "Tron": Tron
  };

  const iconSrc = iconMap[paymentMethod];
  return iconSrc ? (
    <img src={iconSrc} className="pay_img img-fluid" alt={paymentMethod} />
  ) : null;
}

function App() {
  const windowWidth = useWindowWidth();
  //const scrollHook = windowWidth > 576 ? useSmoothScroll(0.8, 0.2) : null;
  //const scrollTo = scrollHook?.scrollTo;
  const [ username, setUsername ] = useState(localStorage.getItem('Username') || '');
  const [password, setPassword ] = useState(localStorage.getItem('Password') || '');
  const [selectedPlan, setSelectedPlan] = useState('STARTER');
  const [investmentAmount, setInvestmentAmount] = useState('');
  const [totalAccounts, setTotalAccounts] = useState(365011);
  const [runningDays, setRunningDays] = useState(640);
  const [totalDeposit, setTotalDeposit] = useState(193687920);
  const [totalWithdrawl, setTotalWithdrawl] = useState(885657107);
  const totalAccountsRef = useRef(null);
  const runningDaysRef = useRef(null);
  const totalDepositRef = useRef(null);
  const totalWithdrawlRef = useRef(null);
  const [lastestDeposit, setLastestDeposit] = useState([]);
  const [lastestWithdrawal, setLastestWithdrawal] = useState([]);
  const [isLastestDeposit, setIsLastestDeposit] = useState(true);
  
  useEffect(() => {
    switchPlansInfo("none");

    Fancybox.bind("[data-fancybox='gallery']", {});
    
    setLastestDeposit([
      {
        Name: "John Doe",
        Amount: "10.1",
        Date: "Nov-22-2025 06:15:13 AM",
        Payment: "Bitcoin",
      },
      {
        Name: "Jane Smith",
        Amount: "15.78",
        Date: "Oct-15-2025 10:30:15 PM",
        Payment: "Etherium",
      },
      {
        Name: "Alice Johnson",
        Amount: "5.25",
        Date: "Sep-01-2025 02:45:30 AM",
        Payment: "Tether",
      },
      {
        Name: "Bob Johnson",
        Amount: "3.14",
        Date: "Aug-15-2025 09:15:30 PM",
        Payment: "Dogecoin",
      },
      {
        Name: "Mike Johnson",
        Amount: "19.99",
        Date: "Jul-01-2025 05:30:15 PM",
        Payment: "Stellar",
      }
    ]);
    setLastestWithdrawal([
      {
        Name: "CryptoWolf",
        Amount: "7.84",
        Date: "Nov-22-2025 07:42:11 AM",
        Payment: "Bitcoin",
      },
      {
        Name: "LunaTrader",
        Amount: "12.55",
        Date: "Nov-21-2025 11:09:23 PM",
        Payment: "Etherium",
      },
      {
        Name: "ShadowMint",
        Amount: "4.32",
        Date: "Nov-21-2025 04:57:45 PM",
        Payment: "Tether",
      },
      {
        Name: "OceanBreeze",
        Amount: "9.10",
        Date: "Nov-20-2025 08:14:29 AM",
        Payment: "Litecoin",
      },
      {
        Name: "PixelNova",
        Amount: "22.88",
        Date: "Nov-19-2025 01:37:55 PM",
        Payment: "Dogecoin",
      }
    ]);
    
    const target = document.getElementById('counter');
    if (!target) return;
    const observer = new IntersectionObserver(
      ([entry]) => {
        if (entry.isIntersecting) {
          animateCounter(totalAccountsRef, totalAccounts);
          animateCounter(runningDaysRef, runningDays);
          animateCounter(totalDepositRef, totalDeposit);
          animateCounter(totalWithdrawlRef, totalWithdrawl);
          observer.unobserve(target);
        }
      },
      {
        root: null,
        threshold: 0.25
      }
    );
    observer.observe(target);
    return () => observer.disconnect(), document.removeEventListener('resize', () => {
      windowWidth > 576 ? enable() : disable();
    });
  }, []);

  function animateCounter(ref, target, duration = 3000) {
    if (!ref.current) return;

    const startTime = performance.now();

    function update(currentTime) {
      const progress = Math.min((currentTime - startTime) / duration, 1);
      const value = Math.floor(progress * target);

      ref.current.innerText = value;

      if (progress < 1) requestAnimationFrame(update);
    }

    requestAnimationFrame(update);
  }

  const scrollToTopHandler = () => {
    //windowWidth > 576 ? scrollTo(0) : window.scrollTo({ top: 0, behavior: 'smooth' });
    window.scrollTo({ top: 0, behavior: 'smooth' })
  };

  const switchPlansInfo = (plan) => {
    if (plan !== "none" && document.getElementById(`planInfo-${plan}`).style.maxHeight > "0px") {
      document.getElementById(`planInfo-${plan}`).style.maxHeight = "0px";
      return;
    }
    const starterInfo = document.getElementById(`planInfo-STARTER`);
    const premiumInfo = document.getElementById(`planInfo-PREMIUM`);
    const exclusiveInfo = document.getElementById(`planInfo-EXCLUSIVE`);
    const vipInfo = document.getElementById(`planInfo-VIP`);
    
    // Add smooth transition for all plan info elements
    [starterInfo, premiumInfo, exclusiveInfo, vipInfo].forEach(element => {
      element.style.transition = "max-height 0.3s ease-in-out";
      element.style.overflow = "hidden";
      element.style.maxHeight = "0px";
    });

    switch (plan) {
      case "STARTER":
        starterInfo.style.maxHeight = starterInfo.scrollHeight + "px";
        break;
      case "PREMIUM":
        premiumInfo.style.maxHeight = premiumInfo.scrollHeight + "px";
        break;
      case "EXCLUSIVE":
        exclusiveInfo.style.maxHeight = exclusiveInfo.scrollHeight + "px";
        break;
      case "VIP":
        vipInfo.style.maxHeight = vipInfo.scrollHeight + "px";
        break;
      case "none":
        break;
    }
  }

  const dailyProfitCalc = (plan, amount) => {
    switch (plan) {
      case "STARTER":
        if (amount < 10) {
          return "Min: $10";
        }
        else if (amount > 699) {
          return "Max: $699";
        }
        else {
          return (amount * 0.1).toFixed(2);
        }
        break;
      case "PREMIUM":
        if (amount < 700) {
          return "Min: $700";
        }
        else if (amount > 1999) {
          return "Max: $1999";
        }
        else {
          return (amount * 0.17).toFixed(2);
        }
        break;
      case "EXCLUSIVE":
        if (amount < 2000) {
          return "Min: $2000";
        }
        else if (amount > 4999) {
          return "Max: $4999";
        }
        else {
          return (amount * 3).toFixed(2);
        }
        break;
      case "VIP":
        if (amount < 5000) {
          return "Min: $5000";
        }
        else if (amount > 100000) {
          return "Max: $100000";
        }
        else {
          return (amount * 4.5).toFixed(2);
        }
        break;
    }
  }

  const totalProfitCalc = (plan, amount) => {
    switch (plan) {
      case "STARTER":
        if (amount < 10) {
          return "Min: $10";
        }
        else if (amount > 699) {
          return "Max: $699";
        }
        else {
          return (amount * 1.2).toFixed(2);
        }
        break;
      case "PREMIUM":
        if (amount < 700) {
          return "Min: $700";
        }
        else if (amount > 1999) {
          return "Max: $1999";
        }
        else {
          return (amount * 1.7).toFixed(2);
        }
        break;
      case "EXCLUSIVE":
        if (amount < 2000) {
          return "Min: $2000";
        }
        else if (amount > 4999) {
          return "Max: $4999";
        }
        else {
          return (amount * 3).toFixed(2);
        }
        break;
      case "VIP":
        if (amount < 5000) {
          return "Min: $5000";
        }
        else if (amount > 100000) {
          return "Max: $100000";
        }
        else {
          return (amount * 4.5).toFixed(2);
        }
        break;
    }
  }

  return (
    <>
      <div className="w-full flex flex-col justify-center items-center">
        <div className={`bg-[#01092E] w-full flex flex-col justify-center items-center relative overflow-x-hidden ${windowWidth < 992 ? 'text-center' : ''}`}>
          <div className="contentWidth z-[2] relative overflow-hidden">
            <Header />
            <div className="banner-text mt-16">
              <h5 className={`flex items-center ${windowWidth < 992 ? 'justify-center' : ''}`}><img src={head_img} alt="" /><span className="text-white text-sm ml-[-5px] mb-[-2px]">WELCOME TO Groundfloor Holding</span></h5>
              <h1 className="text-white font-bold text-[45px] leading-[1.2]">Passive Income Backed by Real Estate</h1>
              <p className="text-white text-sm mt-2 leading-[2]">Alternative investing shouldn't be reserved for the wealthy. With GFL Holdings, anyone can invest in short-term real estate loans that deliver steady returns without buying property or managing tenants.</p>
              <p className="text-white text-sm mt-2 leading-[2]">It’s a simple, hands-off way to grow your money outside the stock market.</p>
              {/* {windowWidth >= 992 ? <div className="col-lg-6_"><img src={logosm} alt="" className="banner_image" /></div> : null} */}
            </div>
            <div onClick={() => /*windowWidth > 576 ? scrollTo(document.getElementById('team').offsetTop) : */window.scrollTo({ top: document.getElementById('team').offsetTop, behavior: 'smooth' })} className="w-full flex justify-center pt-3 align-center relative cursor-pointer"><img className="fa-chevron-down-img" src={fix_arrow} alt="" /><span className={`absolute top-1/2 left-1/2 transform -translate-x-1/2 ${windowWidth < 992 ? '-translate-y-3' : '-translate-y-4'}`}><FaChevronDown /></span></div>
          </div>
          {/* <img src={banner_pic2} alt="" className="ban_pic2" />
          <img src={banner_pic1} alt="" className="ban_pic1" /> */}
        </div>
      </div>
      <div id='team'></div>
      <section className="video_section" style={{fontFamily: "degular-variable, sans-serif"}}>
        <div className="container_ relative flex flex-col justify-center items-center">

          {/* <div className="line_part">
            <svg width="5px" height="600px" className="svg_line">
              <path d="M3,2 L3,420" className="dotted-line"></path>
            </svg>

            <svg width="100px" height="100px" className="svg_line_hori">
              <path d="M0,100 L200,100" className="dotted-line"></path>
            </svg>
          </div> */}

          <div className="live_widget_part w-full">
            <div className="tradingview-widget-container w-full h-[106px]">

              <iframe
                htmlscrolling="no"
                allowtransparency="true"
                frameBorder="0"
                title="ticker tape TradingView widget"
                lang="en"
                className="select-none box-border block h-[74px] w-full"
                src="https://www.tradingview-widget.com/embed-widget/ticker-tape/?locale=en#%7B%22symbols%22%3A%5B%7B%22description%22%3A%22BTC%22%2C%22proName%22%3A%22BITSTAMP%3ABTCUSD%22%7D%2C%7B%22description%22%3A%22ETH%22%2C%22proName%22%3A%22BITSTAMP%3AETHUSD%22%7D%2C%7B%22description%22%3A%22USDT%22%2C%22proName%22%3A%22CRYPTOCAP%3AUSDT%22%7D%2C%7B%22description%22%3A%22MSFT%22%2C%22proName%22%3A%22NASDAQ%3AMSFT%22%7D%2C%7B%22description%22%3A%22APPL%22%2C%22proName%22%3A%22NASDAQ%3AAAPL%22%7D%2C%7B%22description%22%3A%22TSLA%22%2C%22proName%22%3A%22NASDAQ%3ATSLA%22%7D%5D%2C%22showSymbolLogo%22%3Atrue%2C%22isTransparent%22%3Afalse%2C%22displayMode%22%3A%22compact%22%2C%22colorTheme%22%3A%22light%22%2C%22width%22%3A%22100%25%22%2C%22height%22%3A106%2C%22utm_source%22%3A%22bitbullpro.net%22%2C%22utm_medium%22%3A%22widget_new%22%2C%22utm_campaign%22%3A%22ticker-tape%22%2C%22page-uri%22%3A%22bitbullpro.net%2F%3Fref%3Dupayhyip%22%7D"
              ></iframe>

              <div className="tradingview-widget-copyright text-center text-sm leading-8">
                <a
                  href="https://www.tradingview.com/?utm_source=bitbullpro.net&utm_medium=widget_new&utm_campaign=ticker-tape"
                  target="_blank"
                  rel="noopener noreferrer"
                  className="no-underline text-gray-400"
                >
                  <span className="blue-text"></span>
                </a>
              </div>

            </div>
          </div>

          <div className={`w-full flex justify-between items-center ${windowWidth < 992 ? 'flex-col' : 'gap-10'}`}>
            <div className="content_section">
              <div className="head_">
                <h3 className="font-semibold">How Real Estate Debt Investing Works</h3>
              </div>

              <h2 className="fade_text">what Who</h2>

              <div className="text_part">
                <p style={{fontFamily: "degular-variable, sans-serif"}}>
                  GFL Holdings lets you start investing with as little as $10.
                  <br /><br />
                  You can choose from a variety of real estate-based investment products or opt for an automated, diversified portfolio. As borrowers repay their loans, you earn interest. When projects are completed, you can withdraw your funds or reinvest in new opportunities.
                </p>
              </div>
            </div>

            <div className="banner_video pt-6">
              <iframe
                width="1060"
                height="360"
                src="https://www.youtube.com/embed/rR5VAqF-s4c?si=BEVC9QLaOCzjDqsl"
                title="YouTube video player"
                frameBorder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
                referrerPolicy="strict-origin-when-cross-origin"
                allowFullScreen
              ></iframe>
            </div>
          </div>

          {/* <img
            src={vector_icon}
            alt="vector_icon"
            className="vector_icon max-w-full h-auto"
          /> */}

        </div>
      </section>
      <div className="w-full trans_bg">
        <ol className={`container_ list-none p-0 w-full flex justify-between flex-wrap gap-5 text-3xl`}>
          <li className={`p-3 ${windowWidth < 768 ? 'mx-5 w-full' : 'w-[300px]'} secu_item_bg rounded-md relative flex flex-col justify-center h-[100px]`}>
            <p className='text-xl'><b>Fund Renovations</b></p>
            <p className='text-lg'>Invest in real estate products with low minimums.</p>
            <span className='absolute top-1 right-1 text-[14px] text-white bg-[#63a6ff] h-[25px] w-[25px] flex items-center justify-center rounded-lg font-bold'>#1</span>
          </li>
          <li className={`p-3 ${windowWidth < 768 ? 'mx-5 w-full' : 'w-[300px]'} secu_item_bg rounded-md relative flex flex-col justify-center h-[100px]`}>
            <p className='text-xl'><b>Earn Interest</b></p>
            <p className='text-lg'>Grow your investments with interest.</p>
            <span className='absolute top-1 right-1 text-[14px] text-white bg-[#63a6ff] h-[25px] w-[25px] flex items-center justify-center rounded-lg font-bold'>#2</span>
          </li>
          <li className={`p-3 ${windowWidth < 768 ? 'mx-5 w-full' : 'w-[300px]'} secu_item_bg rounded-md relative flex flex-col justify-center h-[100px]`}>
            <p className='text-xl'><b>Get Repaid</b></p>
            <p className='text-lg'>Repaid loans return money to you.</p>
            <span className='absolute top-1 right-1 text-[14px] text-white bg-[#63a6ff] h-[25px] w-[25px] flex items-center justify-center rounded-lg font-bold'>#3</span>
          </li>
        </ol>
      </div>
      <div className='w-full flex justify-center items-center bg-[#F8FAFE]'>
        <div className="contentWidth pt-[50px] pb-[20px]">
          <div className={`${windowWidth < 768 ? 'px-7' : ''}`}>
            <div className='heading'>
              <div className='head'>
                <h2 className='leading-[1.2]'>Grow Your Portfolio with GFL Holdings</h2>
                <h5 className={`flex items-center`}><img src={head_img1} alt="" /><span className="text-black text-[16px] mt-[1px]">PRICING PLAN</span></h5>
              </div>
              <div className="head">
                {username.length > 0 && password.length > 0 ? null : (
                    <>
                      <p>Real estate investing used to be reserved for big banks and the wealthy. We’ve opened the door with four ways to grow your money:</p>
                      <Link to={username.length > 0 && password.length > 0 ? "/signup" : "/signup"}><BounceButton text={username.length > 0 && password.length > 0 ? "Account" : "Create Account"} startTextColor="white" endTextColor="white" isKick={true} /></Link>
                    </>
                )}
              </div>
            </div>
            <div className="flex flex-col justify-center w-full">
              <div className="accordion-item w-full">
                <h2 className="accordion-header cursor-pointer w-full bg-[#F4FAFC] border-[#95DFE1] border-[1px] rounded-md p-3">
                  <div className="accordion-button collapsed w-full">
                    <div className="plan_item">
                      <div className="plan_right">
                        <img src={plan_icon} alt="plan_icon" className="plan_icon img-fluid" />
                        <h4>STARTER</h4>
                        <h2><b>10%</b> <span> daily for 12 days </span></h2>
                      </div>
                      <div className="plan_left">
                        <i className="ri-money-dollar-circle-line"></i>
                        <h3>minimum-Deopsit <span>$ 10-699</span> </h3>
                        <div onClick={() => switchPlansInfo("STARTER")}><BounceButton text="Details" startTextColor="black" endTextColor="white" isKick={false} /></div>
                      </div>
                    </div>
                  </div>
                </h2>
                <div id="planInfo-STARTER" className="accordion-collapse">
                  <div className="accordion-body">
                    <div className="plan_body_top">
                      <div className="right_text">
                        <h3 className='pr-5'><i className="ri-line-chart-fill"></i>Total Interest <span>100%</span></h3>
                        <h3 className='pr-5'><i className="ri-wallet-3-line"></i> <span>Monday to Sunday </span></h3>  
                      </div>  
                      <div className="left_text">
                        <h3><i className="fa-solid fa-check-double"></i> Easy Withdraw  </h3>
                        <h3><i className="fa-solid fa-check-double"></i> High Profit </h3>  
                        <h3><i className="fa-solid fa-check-double"></i> 24/7 Customer Support</h3>  
                      </div>
                    </div> 
                  </div>
                  <hr />     
                </div>
              </div>
              <div className="accordion-item w-full">
                <h2 className="accordion-header cursor-pointer w-full bg-[#F4FAFC] border-[#95DFE1] border-[1px] rounded-md p-3">
                  <div className="accordion-button collapsed w-full">
                    <div className="plan_item">
                      <div className="plan_right">
                        <img src={plan_icon} alt="plan_icon" className="plan_icon img-fluid" />
                        <h4>PREMIUM</h4>
                        <h2><b>17%</b> <span> daily for 10 days </span></h2>
                      </div>
                      <div className="plan_left">
                        <i className="ri-money-dollar-circle-line"></i>
                        <h3>minimum-Deopsit <span>$ 700-1999</span> </h3>
                        <div onClick={() => switchPlansInfo("PREMIUM")}><BounceButton text="Details" startTextColor="black" endTextColor="white" isKick={false} /></div>
                      </div>
                    </div>
                  </div>
                </h2>
                <div id="planInfo-PREMIUM" className="accordion-collapse">
                  <div className="accordion-body">
                    <div className="plan_body_top">
                      <div className="right_text">
                        <h3 className='pr-5'><i className="ri-line-chart-fill"></i>Total Interest <span>100%</span></h3>
                        <h3 className='pr-5'><i className="ri-wallet-3-line"></i> <span>Monday to Sunday </span></h3>  
                      </div>  
                      <div className="left_text">
                        <h3><i className="fa-solid fa-check-double"></i> Easy Withdraw  </h3>
                        <h3><i className="fa-solid fa-check-double"></i> High Profit </h3>  
                        <h3><i className="fa-solid fa-check-double"></i> 24/7 Customer Support</h3>  
                      </div>
                    </div> 
                  </div>
                  <hr />     
                </div>
              </div>
              <div className="accordion-item w-full">
                <h2 className="accordion-header cursor-pointer w-full bg-[#F4FAFC] border-[#95DFE1] border-[1px] rounded-md p-3">
                  <div className="accordion-button collapsed w-full">
                    <div className="plan_item">
                      <div className="plan_right">
                        <img src={plan_icon} className="plan_icon img-fluid" />
                        <h4>EXCLUSIVE</h4>
                        <h2><b>300%</b> <span> daily for 10 days </span></h2>
                      </div>
                      <div className="plan_left">
                        <i className="ri-money-dollar-circle-line"></i>
                        <h3>minimum-Deopsit <span>$ 2000-4999</span> </h3>
                        <div onClick={() => switchPlansInfo("EXCLUSIVE")}><BounceButton text="Details" startTextColor="black" endTextColor="white" isKick={false} /></div>
                      </div>
                    </div>
                  </div>
                </h2>
                <div id="planInfo-EXCLUSIVE" className="accordion-collapse">
                  <div className="accordion-body">
                    <div className="plan_body_top">
                      <div className="right_text">
                        <h3 className='pr-5'><i className="ri-line-chart-fill"></i>Total Interest <span>100%</span></h3>
                        <h3 className='pr-5'><i className="ri-wallet-3-line"></i> <span>Monday to Sunday </span></h3>  
                      </div>  
                      <div className="left_text">
                        <h3><i className="fa-solid fa-check-double"></i> Easy Withdraw  </h3>
                        <h3><i className="fa-solid fa-check-double"></i> High Profit </h3>  
                        <h3><i className="fa-solid fa-check-double"></i> 24/7 Customer Support</h3>  
                      </div>
                    </div> 
                  </div>
                  <hr />     
                </div>
              </div>
              <div className="accordion-item w-full">
                <h2 className="accordion-header cursor-pointer w-full bg-[#F4FAFC] border-[#95DFE1] border-[1px] rounded-md p-3">
                  <div className="accordion-button collapsed w-full">
                    <div className="plan_item">
                      <div className="plan_right">
                        <img src={plan_icon} alt="plan_icon" className="plan_icon img-fluid" />
                        <h4>VIP</h4>
                        <h2 className='gap-2'><b>450%</b> <span> daily for 10 days </span></h2>
                      </div>
                      <div className="plan_left">
                        <i className="ri-money-dollar-circle-line"></i>
                        <h3>minimum-Deopsit <span>$ 5000-100000</span> </h3>
                        <div onClick={() => switchPlansInfo("VIP")}><BounceButton text="Details" startTextColor="black" endTextColor="white" isKick={false} /></div>
                      </div>
                    </div>
                  </div>
                </h2>
                <div id="planInfo-VIP" className="accordion-collapse">
                  <div className="accordion-body">
                    <div className="plan_body_top">
                      <div className="right_text">
                        <h3 className='pr-5'><i className="ri-line-chart-fill"></i>Total Interest <span>100%</span></h3>
                        <h3 className='pr-5'><i className="ri-wallet-3-line"></i> <span>Monday to Sunday </span></h3>  
                      </div>  
                      <div className="left_text">
                        <h3><i className="fa-solid fa-check-double"></i> Easy Withdraw  </h3>
                        <h3><i className="fa-solid fa-check-double"></i> High Profit </h3>  
                        <h3><i className="fa-solid fa-check-double"></i> 24/7 Customer Support</h3>  
                      </div>
                    </div> 
                  </div>
                  <hr />     
                </div>
              </div>
              <div className="plan_boby_bottom">
                <div className="right_text">
                  <h4>You can calculate the return on your investment</h4>
                  <div className="cal_group">
                    <h5>Select your Plan
                      <select id="selectCalcPlan" className="inpts1" value={selectedPlan} onChange={(e) => setSelectedPlan(e.target.value)}>
                        <option value="STARTER"> Starter Plan </option>
                        <option value="PREMIUM"> Premium Plan </option>
                        <option value="EXCLUSIVE"> Exclusive Plan </option>
                        <option value="VIP"> Vip Plan </option>
                      </select>
                    </h5>
                    <h5>Enter Your Amount 
                      <input type="number" className="inpts1" placeholder={`${selectedPlan === "STARTER" ? "$10" :
                        selectedPlan === "PREMIUM" ? "$700" :
                        selectedPlan === "EXCLUSIVE" ? "$2000" :
                        selectedPlan === "VIP" ? "$5000" :
                          ""}`} value={investmentAmount} onChange={(e) => setInvestmentAmount(e.target.value)} /> 
                    </h5> 
                  </div>
                </div>
                <div className="left_text">
                  <h4 className={`${windowWidth < 1200 ? "text-start" : "text-end"}`}>With this amount of investment you will receive:</h4>
                  <h5> <div className={`flex w-full justify-end items-center ${windowWidth < 992 ? "justify-center" : "justify-end"}`}><img src={plan_icon1} className="plan_icon1 me-2 w-[14px] h-[16px]" /> Daily Profit</div> <span id="profitDaily">{dailyProfitCalc(selectedPlan, investmentAmount)}</span> </h5>
                  <h5> <div className={`flex w-full justify-end items-center ${windowWidth < 992 ? "justify-center" : "justify-end"}`}><img src={plan_icon2} className="plan_icon1 me-2 w-[14px] h-[16px]" /> Total Profit</div> <span id="profitTotal">{totalProfitCalc(selectedPlan, investmentAmount)}</span> </h5>
                </div>
              </div>
              <div className={`w-full calc-btn items-center`}><BounceButton text="Get Started" startTextColor="white" endTextColor="white" isKick={true} /></div>
            </div>
          </div>
        </div>
      </div>
      <section className="referal_section bg-[#F4F4F4]">
        <div className={`container_ flex justify-between ${windowWidth < 992 ? "flex-col gap-10" : "flex-row"}`}>
            <div className="col-lg-6 flex flex-col justify-center" style={{ minHeight: 'fit-content' }}>
              <h2 className="text-3xl font-bold mb-6 text-gray-800">High-Yield Real Estate Investing</h2>
              <p className="text-lg text-gray-600 mb-8">
                Discover a smarter, more reliable way to grow your wealth through short-term, high-yield real-estate loans backed by real properties. Start with as little as $10 and earn passive income without the guesswork.
              </p>
              
              <h3 className="text-2xl font-semibold mb-4 text-gray-800">Why Investors Choose Us</h3>
              <ul className="space-y-3 mb-8 pl-3">
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>Earn weekly payouts as loans are repaid</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>We handle the investing — you enjoy the returns</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>Build long-term wealth passively: set it and forget it</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>Proven positive returns every quarter for 10+ years</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>Trusted by over 250,000 investors</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>More than $2.2 billion invested through our platform</span>
                </li>
                <li className="flex items-center">
                  <span className="text-[#6A5CA4] mr-2 text-2xl"><FaCheck /></span>
                  <span>Recognized by leading financial publications</span>
                </li>
              </ul>

              <div className="bg-[#444444] p-6 rounded-lg">
                <h3 className="text-xl font-semibold mb-3 text-white">Proven Trust & Results</h3>
                <p className="text-white">
                  We've delivered strong, consistent performance year after year — and more people discover the results every day.
                </p>
              </div>

              <div className="referal_video">
                  <img src={refer_video_img} alt="refer_video_img" className="refer_video_img img-fluid" />
                  <a href="#" className="hvr-bounce-out">  <i className="ri-play-fill"></i>  </a>
              </div>
            </div>
            <div className="col-lg-6" id="instantValueCol">
              <div className="flex">
                <div className='w-1/2 exp-item'>
                  <h2>1</h2>
                  <h3>Instant Value</h3>
                  <p>Your friend gets a 100% boost on their first real estate loan investment. You get $50 to grow your portfolio. Both win immediately.</p>
                </div>
                <div className='w-1/2'>
                  <img className='h-full object-cover' src={instantValueImg} alt="" />
                </div>
              </div>
              <div className="flex">
                <div className='w-1/2'>
                  <img className='h-full object-cover' src={noLimitsImg} alt="" />
                </div>
                <div className='w-1/2'>
                  <div className='w-full h-1/2 exp-item'>
                    <h2>2</h2>
                    <h3>No Limits</h3>
                    <p>Refer as many friends as you want. There's no cap on how much you can earn or how many people you can introduce to real estate loan investing.</p>
                  </div>
                  <div className='w-full h-1/2 exp-item'>
                    <h2>3</h2>
                    <h3>Track Everything</h3>
                    <p>See your referrals, pending rewards, and earnings all in one dashboard. Total transparency from invitation to payout.</p>
                  </div>
                </div>
              </div>
              <div className="flex">
                <div className='w-1/2 exp-item'>
                  <h2>4</h2>
                  <h3>30-Day Crediting</h3>
                  <p>Both rewards are automatically credited within 30 days after your friend's qualifying investment. No forms to fill out. No hoops to jump through.</p>
                </div>
                <div className='w-1/2'>
                  <img className='h-full object-cover' src={_30daysCreditingImg} alt="" />
                </div>
              </div>
            </div>
        </div>
      </section>
      <div className="w-full bg-[#f6f6f6]">
        <div className='container_ flex justify-center items-center'>
          <h1 className='text-3xl font-bold p-6 text-gray-800'>A Real Estate Portfolio Built for Stability</h1>
        </div>
      </div>
      <section className="stat_section">
        <div className="container_" style={{ position: 'relative' }}>
            <div className="head_">
              <h2 className="fade_text"> Statistics</h2>
              <h2>Our <span>Statistics</span></h2>
            </div>
            <div className="stat_group" id="counter">      
              <div className="stat_item">
                <img src={stat_img1} alt="stat_img1" className="stat_img1 img-fluid" />
                <h3>Total Accounts <span className="counter-value" ref={totalAccountsRef}>0</span></h3>
              </div>
                      
              <div className="stat_item">
                <img src={stat_img2} alt="stat_img2" className="stat_img1 img-fluid" />
                <h3>Running Days <span className="counter-value" ref={runningDaysRef}>0</span></h3>
              </div>
                          
              <div className="stat_item">
                <img src={stat_img3} alt="stat_img3" className="stat_img1 img-fluid" />
                <h3>Total Desposit <span className="counter-value" ref={totalDepositRef}>0</span></h3>
              </div>
                          
              <div className="stat_item">
                <img src={stat_img4} alt="stat_img4" className="stat_img1 img-fluid" />
                <h3>Total Withdrawal <span className="counter-value" ref={totalWithdrawlRef}>0</span></h3>
              </div>
            </div>
        </div>
    </section>
    <section className="Security_section">
      <div className="container_">
          <div className="head_">
            <h2>Personal <span>Security</span></h2>
          </div>
          <div className="row">
            <div className="col-lg-6">
              <div className="head_">
                <p>All personal data you provide to the company is stored in strict confidentiality and is protected by the law on the protection of personal data. All your personal data may be used by the company solely to optimize the work of BITBULL PRO with the investor and improve the quality of the services provided.</p>
              </div>
            </div>
            <div className="col-lg-6">
              <div className="head_">
                <p>We do not share your personal data with third parties under any circumstances, keeping the details of your personal data and financial transactions secret from third parties. All data that is collected and/or may be collected by the company is carefully protected from potential acquisition by third parties.</p>
              </div>
            </div>
          </div>
          <div className="security_group">
            <div className="secu_item">
              <img src={secu_icon1} alt="secu_icon1" className="secu_icon1 img-fluid" /> 
              <h3>Confidential data</h3>
              <p><b>GFL Holding</b> stores your personal data and does not transfer it to third parties. An exception may be the cases where an official request was received from law enforcement agencies under the current legislation. You always have the right to request the deletion of your account with your personal data.</p>
            </div>
            <div className="secu_item">
              <img src={secu_icon2} alt="secu_icon2" className="secu_icon1 img-fluid" /> 
              <h3>Non-disclosure agreement</h3>
              <p>Using the <b>GFLHolding.com</b> website, you agree to non-disclosure of all protected and confidential data, compliance with the company's copyright on the posted materials and content posted on the website.</p>
            </div>
            <div className="secu_item">
              <img src={secu_icon3} alt="secu_icon3" className="secu_icon1 img-fluid" /> 
              <h3>Electronic consent</h3>
              <p>After registering on the <b>GFLHolding.com</b> website, you agree to our Terms and Conditions. If you are not satisfied with the Terms and Conditions of <b>GFL Holding</b>, stop using our services and finish working with the website.</p>
            </div>
          </div>
        </div>
      </section>
      <section className="certifi_secction">
        <div className="container_">
          <div className="row">
            <div className="col-lg-6">
              <div className="head_">
                <h2>Company security principles</h2>
                <p>All web services and data exchange take place over channels protected by the SSL protocol (https). Wallets are stored using PGP encryption. No one has direct access to client funds, and regular financial and security audits ensure that funds are always safe and fully accounted for.</p>
                <p className="bold_text">All our personnel is trained in security issues and required to comply with the company's security policy.</p>
                <div className={windowWidth < 992 ? "w-full flex justify-center mt-[-10px]" : ""}>
                  <BounceButton text="Security" startTextColor="white" endTextColor="white" isKick={true} componentBefore={<i className="ri-shield-line"></i>} />
                </div>
              </div>
            </div>
            <div className="col-lg-6 cert_group">
              <div className="cert_img">
                <a href={cert_img} data-fancybox="gallery">
                <img
                  src={cert_img}
                  alt="cert_img"
                  className="certi_img img-fluid"
                />
              </a>
              </div>
              <div className="cert_info">
                <h3> Private company<span> Incorporation</span> </h3>
                <p><span>16407835</span> Company Number </p>
                <p>Company Location: <span>139 Junction Road, London, England, N19 5PX</span> </p>
                <a href="https://find-and-update.company-information.service.gov.uk/company/16407835" target="_blank" className="but1 hvr-rectangle-out"><BounceButton text="Check Company" startTextColor="black" endTextColor="white" isKick={false} componentAfter={<img src={cert_icon} alt="cert_icon" className="cert_icon img-fluid" />} /></a>
              </div>
            </div>
          </div>
        </div>
      </section>
      <section className="trans_bg">
        <div className="container_">
          <div className="row">
            <div className="col-lg-6">
              <div className="tab-content">
                <div className="tab-pane fade active show">
                  <div className="table_group overflow-x-hidden">
                    <h2>{isLastestDeposit ? "Lastest Deposit" : "Lastest Withdrawal"}</h2>
                    <ul className="tab_body flex justify-between items-center min-w-[290px]">
                      <li><h3>Name</h3></li>
                      <li><h3>Amount</h3></li>
                      <li><h3>Date &amp; Time</h3></li>
                      <li><h3>Payment</h3></li>
                    </ul>
                    {isLastestDeposit
                      ? lastestDeposit.map((item, index) => (
                          <ul key={index} className="tab_body flex justify-between items-center min-w-[320px]">
                            <li><h5 className="text-ellipsis overflow-hidden whitespace-nowrap min-w-[73px]">{item.Name}</h5></li>
                            <li><h5>${(Number(item.Amount) || 0).toFixed(2)}</h5></li>
                            <li className="min-w-[100px]"><h5>{item.Date}</h5></li>
                            <li><h5 className="flex justify-center"><PaymentIcon paymentMethod={item.Payment} /></h5></li>
                          </ul>
                        ))
                      : lastestWithdrawal.map((item, index) => (
                          <ul key={index} className="tab_body flex justify-between items-center min-w-[320px]">
                            <li><h5 className="text-ellipsis overflow-hidden whitespace-nowrap min-w-[73px]">{item.Name}</h5></li>
                            <li><h5>${(Number(item.Amount) || 0).toFixed(2)}</h5></li>
                            <li className="min-w-[100px]"><h5>{item.Date}</h5></li>
                            <li><h5 className="flex justify-center"><PaymentIcon paymentMethod={item.Payment} /></h5></li>
                          </ul>
                        ))
                    }
                  </div>
                </div>
              </div>
            </div>
            <div className="col-lg-6">
              <div className="head_" style={{ position: "relative", zIndex: 1 }}>
                {/* <img src={trans_vector_img} className="trans_vector_img img-fluid" alt="trans_vector_img" /> */}
                <h2 className="fade_text pt-10">Transaction</h2>
              </div>
              <div className="trans_head">
                <h2>Latest Transaction</h2>
                <p>
                  Stay updated with the latest transactions processed in real-time.
                  Our team ensures every trade is executed securely and efficiently for your benefit.
                </p>
              </div>
              <nav>
                <div className="nav nav-tabs">
                  <button onClick={() => setIsLastestDeposit(true)} className={`nav-link ${isLastestDeposit ? "activeNavLink" : ""}`}>LASTEST DEPOSIT</button>
                  <button onClick={() => setIsLastestDeposit(false)} className={`nav-link ${isLastestDeposit ? "" : "activeNavLink"}`}>LASTEST WITHDRAWAL</button>
                </div>
              </nav>
            </div>
          </div>
        </div>
      </section>
      <section className="pay_section">
        <div className="container_">
          <div className="payments">
            <div className="head_">
              <h2 className='whitespace-nowrap'>
                We <span style={{ display: "inline" }}>Accepts</span>
              </h2>
            </div>

            <div className="payment_group"><PaymentCarousel /></div>
          </div>
        </div>
      </section>
      <Footer />

      <ScrollUpBtn handler={scrollToTopHandler} />
    </>
  )
}

export default App
