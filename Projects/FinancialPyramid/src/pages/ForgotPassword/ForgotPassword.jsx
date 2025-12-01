import { useState } from "react";
import '../../App.css';
import './ForgotPassword.css';
import logosm from '../../assets/logosm.png';
import { Link } from "react-router-dom";
import useWindowWidth from '../../hooks/useWindowWidth';

function ForgotPassword() {
    const windowWidth = useWindowWidth();
    const handleSubmit = (e) => {
        e.preventDefault();
        const form = e.target;
        if (form.email.value === '') {
            alert("Please type your username or email!");
            form.email.focus();
            return false;
        }
        alert("Password reset instructions sent!");
        form.reset();
    };

    return (
        <div className="forget_bg login_bg1">
            <div className="container_">
                <div className="forget_form">
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
                    <div className="log_head">
                        <h3>Can’t Remember Your Password</h3>
                        <p className="text mt-3">
                            Already have an account? <Link to="/login" className="footer_txt">Signin Here</Link>
                        </p>
                    </div>

                    <form method="post" name="forgotform" onSubmit={handleSubmit}>
                        <div className="form1">
                            <div className="form_item">
                                <input type="text" name="email" className="inpts" size="30" required />
                                <label>Type your username or e-mail*</label>
                            </div>

                            <div className="recaptcha"></div>

                            <div className="form_but">
                                <input type="submit" value="Forgot" className="sbmt" />
                            </div>

                            <h3 className="or_text">-OR-</h3>
                            <div className={`log_foot flex flex-wrap ${windowWidth < 490 ? 'gap-7' : ''}`}>
                                <Link to="#"><span className="whitespace-nowrap"> <i className="ri-send-plane-fill"></i> join with Telegram </span></Link>
                                <Link to="#"><span className="whitespace-nowrap"> <i className="ri-facebook-fill"></i> Join with Facebook </span></Link>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    );
}

export default ForgotPassword;
