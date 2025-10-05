import { Link } from "react-router-dom";
import { useState } from "react";

function InteractiveCard() {
    const [isDarkTheme, setIsDarkTheme] = useState(true);
    return (
        <div className="flex items-center justify-center w-screen h-screen flex-col gap-5">
            <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
            <div className={`${isDarkTheme ? "bg-gray-800" : "bg-white"} p-8 rounded-xl shadow-lg ${isDarkTheme ? "hover:bg-gray-700" : "hover:bg-blue-50"} transition-all duration-500 w-60 h-60 group flex flex-col items-center justify-center relative`}>
                <h2 className={`${isDarkTheme ? "text-gray-100" : "text-gray-800"} text-xl px-2 font-bold hover:shadow-black hover:shadow-md rounded-lg transition-all duration-300 absolute top-2 left-2`}>Interactive Card</h2>
                <button className={`${isDarkTheme ? "bg-blue-500" : "bg-blue-600"} ${isDarkTheme ? "hover:bg-blue-600" : "hover:bg-blue-500"} text-white px-6 py-2 rounded-lg focus:outline-none focus:ring-4 ${isDarkTheme ? "focus:ring-blue-500" : "focus:ring-blue-400"} transition-all duration-300 shadow-md hover:shadow-lg`}>Button</button>
            </div>

            <button onClick={() => setIsDarkTheme(!isDarkTheme)} className="text-white text-2xl border-2 border-white p-3 rounded-xl">Toggle {isDarkTheme ? "Light" : "Dark"} theme</button>
        </div>
    )
}

export default InteractiveCard
