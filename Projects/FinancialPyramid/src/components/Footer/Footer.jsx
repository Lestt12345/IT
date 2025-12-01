import './Footer.css'
import '../../App.css'
import logosm from '../../assets/logosm.png'
import { FaUser } from "react-icons/fa";
import { useState } from 'react';
import useWindowWidth from '../../hooks/useWindowWidth';
import { Link } from 'react-router-dom';

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
            animation: hovered ? "fill-bounce-footer 0.8s forwards" : "none",
            }}
        ></span>
      </span>
    </button>
  );
}

function Footer() {
    const windowWidth = useWindowWidth();
    const [ username, setUsername ] = useState(localStorage.getItem('Username') || '');
    const [ password, setPassword ] = useState(localStorage.getItem('Password') || '');
  
    return (
        <footer className="footer_section">
            <div className="container_">
                <div className={`${windowWidth < 992 ? 'w-full flex justify-center items-center gap-1' : ''} row`}>
                    <div className="col-lg-3 flex items-center">
                        <div className="foot_logo">
                            <img src={logosm} alt="logo" className="foot_logo img-fluid" />
                        </div>
                        <span style={{ marginLeft: '5px', fontSize: '30px', display: 'block', color: '#F98F21', marginTop: '10px', fontWeight: '600' }}>GFL<span style={{ color: 'black', marginLeft: '3px' }}>Holdings</span></span>
                    </div>
                    <div className="col-lg-6">
                        <p className="foot_text"> </p>
                    </div>
                    <div className="col-lg-3 flex items-center">
                        <Link to={username.length > 0 && password.length > 0 ? '/signup' : '/signup'}><BounceButton text={username.length > 0 && password.length > 0 ? 'Account' : 'Sign in'} startTextColor="black" endTextColor="white" componentBefore={<FaUser />} /></Link>
                    </div>
                </div>
                <div className="row footer_group">
                    <div className="col-lg-3 col-md-3 col-sm-6">
                        <div className="foot_item">
                            <h3 style={{ paddingLeft: '0px' }}>Company</h3>
                            <a style={{ marginLeft: '0px' }} href="?a=aboutus">About</a>
                            <a style={{ marginLeft: '0px' }} href="?a=faq">Faq</a>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-3 col-sm-6">
                        <div className="foot_item">
                            <h3>Quick Links</h3>
                        <a href="?a=news">News</a>
                        <a href="?a=bounty">Bounty</a>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-3 col-sm-6">
                        <div className="foot_item">
                            <h3>Help</h3>
                            <a href="?a=support">Support</a>
                            <a href="?a=top10">Top Investor</a>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-3 col-sm-6">
                        <div className="foot_item">
                            <h3>Legal</h3>
                        <a href="?a=rules">Terms &amp; Condition</a>
                        <a href="?a=login">Login</a>
                        </div>
                    </div>
                </div>
                <h3 className="copy_text">Copyrights © 2025 BitbullPro Limited. All rights reserved.</h3>
            </div>
        </footer>
    );
}

export default Footer;