import NavlinkStruct from "../../components/NavlinkStruct/NavlinkStruct"
import { useState } from "react"
import '../../App.css'
import './Contacts.css'
import { Link } from "react-router-dom"

function Contacts() {
    const [form, setForm] = useState({
        name: "",
        email: "",
        message: ""
    });

    function handleChange(e) {
        setForm({ ...form, [e.target.name]: e.target.value });
    }

    function handleSubmit(e) {
        e.preventDefault();

        if (!form.name.trim()) {
            alert("Please type your full name!");
            return;
        }
        if (!form.email.trim()) {
            alert("Please enter your e-mail address!");
            return;
        }
        if (!form.message.trim()) {
            alert("Please type your message!");
            return;
        }

        console.log("Form submitted:", form);
        // тут можешь отправлять запрос на сервер
    }

    return (
        <NavlinkStruct back_text="Support" text1="Contact And" text2="Support" >
            <div className="support_bg">
                <div className="container_">
                    <div className="row">

                        {/* LEFT SIDE */}
                        <div className="col-lg-6">
                            <div className="support_txt_group">
                                <div className="head_ mb-5">
                                    <p>
                                        <span className="font-bold">GFL Holdings</span> always takes care of its clients.
                                        Your convenience, comfort, and safety when working with the <span className="font-bold mr-1">GFL Holdings</span>
                                        platform are our priority. Our support team works 24/7 and is always happy
                                        to answer your questions.
                                    </p>
                                    <p>
                                        We’d love to hear from you! If you have any questions or feedback, contact us
                                        anytime. You can reach us by phone, email, or using the form below. We respond as
                                        quickly as possible.
                                    </p>
                                </div>

                                <ul className="conatct_text flex justify-center items-start flex-wrap">
                                    <li className="min-w-[162px]">
                                        <div className="contact_item">
                                            <h3>
                                                <i className="fa-solid fa-at"></i> Support e-mail:
                                                <span> support@bitbullpro.net</span>
                                            </h3>
                                        </div>
                                    </li>

                                    <li className="min-w-[162px]">
                                        <div className="contact_item">
                                            <h3>
                                                <i className="fa-solid fa-location-dot"></i> Company Location:
                                                <span> 139 Junction Road, London, England, N19 5PX</span>
                                            </h3>
                                        </div>
                                    </li>
                                </ul>

                                <div className="faq_box">
                                    <h3>Have some questions?</h3>
                                    <p>
                                        Visit our FAQ page or write your question to our support team.
                                    </p>
                                    <Link to="#" className="but4">Question</Link>
                                </div>
                            </div>
                        </div>

                        {/* RIGHT SIDE — FORM */}
                        <div className="col-lg-6">
                            <div className="form1">

                                <h3>Contact Or Subscribe</h3>
                                <p>you can reach us anytime</p>

                                <form onSubmit={handleSubmit}>
                                    <div className="row">
                                        <div className="col-lg-6">
                                            <div className="form_item">
                                                <input
                                                    type="text"
                                                    name="name"
                                                    placeholder="Username*"
                                                    value={form.name}
                                                    onChange={handleChange}
                                                    className="inpts"
                                                />
                                            </div>
                                        </div>

                                        <div className="col-lg-6">
                                            <div className="form_item">
                                                <input
                                                    type="text"
                                                    name="email"
                                                    placeholder="Email*"
                                                    value={form.email}
                                                    onChange={handleChange}
                                                    className="inpts"
                                                />
                                            </div>
                                        </div>
                                    </div>

                                    <div className="form_item">
                                        <textarea
                                            name="message"
                                            placeholder="your comments*"
                                            value={form.message}
                                            onChange={handleChange}
                                            className="inpts min-h-[100px] max-h-[300px]"
                                            rows="4"
                                        ></textarea>
                                    </div>

                                    <div className="form_but">
                                        <button type="submit" className="sbmt">
                                            Send
                                        </button>
                                    </div>

                                    <Link to="#" className="message_text">
                                        *By submitting the form you agree to our Privacy Policy
                                    </Link>
                                </form>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </NavlinkStruct>
    )
}

export default Contacts