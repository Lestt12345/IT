import { useState } from "react";
import '../../App.css';
import '../SignUp/SignUp.css';
import './Login.css';
import logosm from '../../assets/logosm.png';
import bannerImg from '../../assets/banner_img1.png';
import { Link } from "react-router-dom";

function Login() {
    const handleSubmit = (e) => {
        e.preventDefault();
        const form = e.target;
        if (form.username.value === '') {
            alert("Please type your username!");
            form.username.focus();
            return false;
        }
        if (form.password.value === '') {
            alert("Please type your password!");
            form.password.focus();
            return false;
        }
        alert("Login successful");
        form.reset();
    };

    return (
        <div className="login_bg">
            <div className="container_">
                <div className="log_group">
                    <div className="log_item">
                        <div className="log_top">
                            <img src={bannerImg} alt="banner_bg" className="banner_img img-fluid" />
                        </div>
                    </div>
                    <div className="log_form">
                        <form method="post" name="mainform" onSubmit={handleSubmit}>

                            <span className="w-full flex justify-center items-center">
                                <Link to="/">
                                    <div className="flex items-center">
                                        <div className="foot_logo">
                                            <img src={logosm} alt="logo" className="w-[40px] img-fluid" />
                                        </div>
                                        <span style={{ marginLeft: '5px', fontSize: '30px', display: 'block', color: '#F98F21', marginTop: '10px', fontWeight: '600' }}>
                                            GFL<span style={{ color: 'black', marginLeft: '3px' }}>Holdings</span>
                                        </span>
                                    </div>
                                </Link>
                            </span>

                            <div className="log_text_top w-full">
                                <h2>Create An Account</h2>
                                <h6>
                                    Don't have an Account <Link to="/signup"><span className="link"> Register Now!</span></Link>
                                </h6>
                            </div>

                            <div className="form_item">
                                <input type="text" name="username" className="inpts" size="30" autoFocus required />
                                <label>Username*</label>
                            </div>

                            <div className="form_item">
                                <input type="password" name="password" className="inpts" size="30" required />
                                <label>Password*</label>
                            </div>

                            <Link to="/forgot_password" className="forget underline">Remember your login information?</Link>

                            <div className="form_but">
                                <input type="submit" value="Login" className="sbmt" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Login;
