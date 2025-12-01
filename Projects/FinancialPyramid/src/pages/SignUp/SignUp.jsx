import { useState } from "react";
import '../../App.css'
import './SignUp.css'
import logosm from '../../assets/logosm.png'
import signup from '../../assets/signup.png'
import { Link } from "react-router-dom";

function SignUp() {
    const regform = document.querySelector('form')
    function checkform() {
        if (regform.fullname.value == '') {
            alert("Please enter your full name!");
            regform.fullname.focus();
            return false;
        }

        if (regform.username.value == '') {
            alert("Please enter your username!");
            regform.username.focus();
            return false;
        }
        if (!regform.username.value.match(/^[A-Za-z0-9_\-]+$/)) {
            alert("For username you should use English letters and digits only!");
            regform.username.focus();
            return false;
        }
        if (regform.password.value == '') {
            alert("Please enter your password!");
            regform.password.focus();
            return false;
        }
        if (regform.password.value != regform.password2.value) {
            alert("Please check your password!");
            regform.password2.focus();
            return false;
        }

        if (regform.email.value == '') {
            alert("Please enter your e-mail address!");
            regform.email.focus();
            return false;
        }
        if (regform.email.value != regform.email1.value) {
            alert("Please retype your e-mail!");
            regform.email.focus();
            return false;
        }

        for (i in regform.elements) {
            f = regform.elements[i];
            if (f.name && f.name.match(/^pay_account/)) {
                if (f.value == '') continue;
                var notice = f.getAttribute('data-validate-notice');
                var invalid = 0;
                if (f.getAttribute('data-validate') == 'regexp') {
                    var re = new RegExp(f.getAttribute('data-validate-regexp'));
                    if (!f.value.match(re)) {
                        invalid = 1;
                    }
                } else if (f.getAttribute('data-validate') == 'email') {
                    var re = /^[^\@]+\@[^\@]+\.\w{2,4}$/;
                    if (!f.value.match(re)) {
                        invalid = 1;
                    }
                }
                if (invalid) {
                    alert('Invalid account format. Expected ' + notice);
                    f.focus();
                    return false;
                }
            }
        }

        if (regform.agree.checked == false) {
            alert("You have to agree with the Terms and Conditions!");
            return false;
        }

        return true;
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        if (checkform()) {
            alert('Done');
            regform.reset();
        }
    };

    function IsNumeric(sText) {
        var ValidChars = "0123456789";
        var IsNumber = true;
        var Char;
        if (sText == '') return false;
        for (i = 0; i < sText.length && IsNumber == true; i++) {
            Char = sText.charAt(i);
            if (ValidChars.indexOf(Char) == -1) {
                IsNumber = false;
            }
        }
        return IsNumber;
    }

    return (
        <div className="login_bg signup_bg">
            <div className="container_">
                <div className="log_group">
                    <div className="log_item">
                        <div className="log_top">
                            <img src={signup} alt="banner_bg" className="banner_img img-fluid" />
                        </div>
                    </div>
                    <div className="log_form">
                        <form method="post" onSubmit={handleSubmit} name="regform">
                            <div className="row">
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
                                    <p className="signup-bonus">
                                        <i className="fa-brands fa-btc btc-icon"></i>
                                        🎁 Register receive <span className="btc-text"> Bitcoin reward</span>💰
                                    </p>
                                    <h6>
                                        Already have an account <Link to="/login"><span href="?a=login" className="link"> Login Now!</span></Link>
                                    </h6>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="text" name="fullname" className="inpts" size="30" required />
                                        <label> Full Name</label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="text" name="username" className="inpts" size="30" required />
                                        <label> Your Username </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="password" name="password" className="inpts" size="30" required />
                                        <label> Define Password </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="password" name="password2" className="inpts" size="30" required />
                                        <label> Retype Password </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="text" name="email" className="inpts" size="30" required />
                                        <label> E-mail Address  </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="form_item">
                                        <input type="text" name="email1" className="inpts" size="30" required />
                                        <label> Retype Your E-mail  </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <h4 className="form_itemH4"> Someone invite you? </h4>
                                    <div className="form_item">
                                        <input type="text" name="inviterLogin" className="inpts" size="30" required />
                                        <label> Inviter Login </label>
                                    </div>
                                </div>

                                <div className="col-lg-6 col-md-6 col-sm-6">
                                    <div className="recaptcha">
                                        <h4> </h4>
                                    </div>
                                </div>
                            </div>

                            <h4 className="rem_text">
                                <input type="checkbox" name="agree" value="1" /> I agree the <Link className="text-[#F98F21] underline" to="#">terms</Link> and conditions
                            </h4>

                            <div className="form_but">
                                <input type="submit" value="Register" className="sbmt" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default SignUp;
