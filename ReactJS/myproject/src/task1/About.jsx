import Navbar from "./NavBar"

function About() {
    return (
        <>
            <Navbar />
            <div className="flex justify-center items-center w-screen h-screen">
                <h1 className="text-4xl font-bold text-white">About</h1>
            </div>
        </>
    )
}

export default About