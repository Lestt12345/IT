import NavlinkStruct from "../../components/NavlinkStruct/NavlinkStruct"
import { useState } from "react"
import "../../App.css"
import "./Faq.css"
import { Link } from "react-router-dom"
import useWindowWidth from "../../hooks/useWindowWidth"
import ScrollUpBtn from "../../components/ScrollUpBtn/ScrollUpBtn"

function Faq() {
    const windowWidth = useWindowWidth();
    const scrollToTopHandler = () => {
        window.scrollTo({top: 0, behavior: 'smooth'});
    }    

    return (
        <NavlinkStruct back_text="Faq" text1="Main" text2="Questions">
            <div className="container_ font">
                <div className="row">
                    <div className={`${windowWidth < 992 ? (windowWidth < 577 ? "w-full pt-10 px-0" : "w-full pt-10") : "w-1/3"}`}>
                        <div className="stick">   
                            <div className="faq_tab" id="v-pills-tab" role="tablist" aria-orientation="vertical">
                                {faqData.map((block, index) => (
                                    <a key={index} onClick={() => window.scrollTo({top: document.getElementById(block.title).offsetTop, behavior: 'smooth'})} className="nav-link">{block.title}</a>
                                ))}
                                
                            </div> 
                            <div className="faq_text">
                                <h3>Need Help? We Are Here To Help You</h3>
                                <div className="faq_info_box">
                                    <h4>Need help!<span>+44 for VIP</span></h4>
                                    <hr />
                                    <h4>E-mail now<span className="">support@bitbullpro.net</span></h4>
                                </div>
                            </div>
                        </div>  
                    </div> 
                    <div className={`${windowWidth < 992 ? "w-full" : "w-2/3"}`}>   
                        {faqData.map((block, index) => (
                            <div className="head2" key={index} id={block.title}>
                                <h1>{block.title}</h1>
                                <div className="accordion">
                                    {block.questions.map((question, index) => (
                                        <AccordionItem key={index} question={question.question} answer={question.answer} />
                                    ))}
                                </div>
                            </div>
                        ))}
                            
                    </div>
                </div>
            </div>
            {windowWidth < 992 && <ScrollUpBtn handler={scrollToTopHandler} />}
        </NavlinkStruct>
        
    )
}

const faqData = [
    {
        title: "General Questions",
        questions : [
            {
                question: "Where is BitbullPro Limited registered?",
                answer: "Our company is headquartered at - 139 Junction Road, London, England, N19 5PX. BitbullPro company registration number:{type='a', href='https://find-and-update.company-information.service.gov.uk/company/16407835', text='16407835'}"
            },
            {
                question: " How can I invest with?",
                answer: "To make a investment you must first become a member of  . Once you are signed up, you can make your first deposit. All deposits must be made through the Members Area. You can login using the member username and password you receive when signup."
            },
            {
                question: "How do I open my   Account?",
                answer: "It's quite easy and convenient. Follow this {type='link', href='/signup', text='link'}, fill in the registration form and then press \"Register\""
            },
            {
                question: "How do you calculate the interest on my account?",
                answer: "Depending on each plan. Interest on your   account is acquired Daily, Weekly, Bi-Weekly, Monthly and Yearly and credited to your available balance at the end of each day."
            },
            {
                question: "May I open several accounts in your program?",
                answer: "No, creating multiple accounts is strictly prohibited. Any client can have only one account per IP/Family/Payment account. In the event of multiple registrations from your device we have rights to suspend all of your accounts."
            }
        ]
    },
    {
        title: "Investment Questions",
        questions : [
            {
                question: "Can I do a direct deposit from my account balance?",
                answer: "Yes! To make a deposit from your bitbullpro.net account balance. Simply login into your members account and click on Make Deposit ans select the Deposit from Account Balance Radio button."
            },
            {
                question: "How long does it take for my deposit to be added to my account?",
                answer: "Your account will be updated as fast, as you deposit."
            },
            {
                question: "I wish to invest with  but I don't have an any ecurrency account. What should I do?",
                answer: "You can open a free Epaycore account here: {type='a', href='https://epaycore.com/', text='www.epaycore.com'}\nYou can open a free Bitcoin account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}\nYou can open a free Litecoin account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}\nYou can open a free Ethereum account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}\nYou can open a free Dash account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}\nYou can open a free Bitcoin Cash account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}\nYou can open a free Dogecoin account here: {type='a', href='https://www.coinbase.com', text='www.coinbase.com'}"
            },
            {
                question: "Can I make an additional deposit to bitbullpro.net  account once it has been opened?",
                answer: "Yes, you can but all transactions are handled separately."
            }
        ]
    },
    {
        title: " Withdraw Questions",
        questions : [
            {
                question: "How can I withdraw funds?",
                answer: "Login to your account using your username and password and check the Withdraw section."
            },
            {
                question: "What is the Minimum withdrawals?",
                answer: "Minimum payout amount: 0.1 $ from Epaycore and Withdrawals from cryptocurrencies minimum are 10$\nMaximum payout: No limit."
            },
            {
                question: "After I Make A Withdrawal Request, When Will The Funds Be Available On My Ecurrency Account?",
                answer: "Withdrawals will be processed quickly within 24 hours, but if the withdraw meet payment processors issue, server or technical problem or some other issue, it can take up to 72 hours."
            },
            {
                question: "How can I make a spend?",
                answer: "To make a spend you must first become a member of bitbullpro.net . Once you are signed up, you can make your first spend. All spends must be made through the Member Area. You can login using the member username and password you received when signup."
            }
        ]
    },
    {
        title: "Promotions Questions",
        questions : [
            {
                question: "Does a daily profit paid directly to my currency account?",
                answer: "No, profits are gathered on your  account and you can withdraw them anytime."
            },
            {
                question: "Can I lose money?",
                answer: "There is a risk involved with investing in all high yield investment programs. However, there are a few simple ways that can help you to reduce the risk of losing more than you can afford to. First, align your investments with your financial goals, in other words, keep the money you may need for the short-term out of more aggressive investments, reserving those investment funds for the money you intend to raise over the long-term. It's very important for you to know that we are real traders and that we invest members' funds on major investments."
            },
            {
                question: "How can I change my e-mail address or password?",
                answer: "Log into your bitbullpro.net account and click on the \"Account Information\". You can change your e-mail address and password there."
            },
            {
                question: "What if I can't log into my account because I forgot my password?",
                answer: "Click {type='link', href='/forgot_password', text='forgot password'} link, type your username or e-mail and you'll receive your account information."
            }
        ]
    }
]

function AccordionItem({question, answer}) {
    const [isOpen, setIsOpen] = useState(false);

    return (
        <div className="accordion-item">
            <h2 
                className={`accordion-header cursor-pointer ${isOpen ? '' : 'bg-[#edf8f6]'}`} 
                onClick={() => setIsOpen(!isOpen)}
            >
                {question}
            </h2>
            <div 
                className="accordion-body overflow-hidden transition-all duration-300 ease-in-out" 
                style={{ 
                    maxHeight: isOpen ? `100%` : '0',
                    opacity: isOpen ? 1 : 0,
                    padding: isOpen ? '15px 15px' : '0 15px',
                    visibility: isOpen ? 'visible' : 'hidden',
                    whiteSpace: "pre-line"
                }}
            >
                {parseString(answer)}
            </div>
        </div>  
    )
}

function parseString(str) {
  const regex = /\{type='(link|a)', href='([^']+)', text='([^']+)'\}/g;
  const parts = [];
  let lastIndex = 0;

  let match;
  while ((match = regex.exec(str)) !== null) {
    if (match.index > lastIndex) {
      parts.push(str.slice(lastIndex, match.index));
    }

    const [full, type, href, text] = match;

    if (type === "link") {
      parts.push(<Link className="text-[#e0aa2f] hover:text-[#4CC5D5]" key={lastIndex} to={href}>{text}</Link>);
    } else {
      parts.push(<a className="text-[#e0aa2f] hover:text-[#4CC5D5]" key={lastIndex} href={href} target="_blank">{text}</a>);
    }

    lastIndex = match.index + full.length;
  }

  if (lastIndex < str.length) {
    parts.push(str.slice(lastIndex));
  }

  return parts;
}

export default Faq