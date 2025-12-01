import Header from "../Header/Header"
import Footer from "../Footer/Footer"
import '../../App.css'
import './NavlinkStruct.css'

function NavlinkStruct({back_text, text1, text2, children}) {
    return (
        <>
            <section className="banner_section1">
                <div className="w-full flex justify-center items-center">
                    <Header />
                </div>
                <div className="container_">
                    <div className="banner1">
                        <div className="head_">
                        <h2 className="fade_text">{back_text}</h2>
                            <h2 className="font_ flex w-full justify-center items-center">{text1}<span className="pt-2">{text2}</span> </h2>
                        </div>
                    </div>
                </div>
            </section>
            {children}
            <Footer />
        </>
    )
}

export default NavlinkStruct