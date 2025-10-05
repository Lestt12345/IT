import { useState } from "react";
import { Link } from "react-router-dom";
function FormWithHoversFocuses() {
    return (
        <div className="flex items-center justify-center w-screen h-screen">
            <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
            <form action="" className="flex flex-col items-center gap-5 w-72 border-2 border-gray-300 p-5 rounded-xl bg-gray-600">
                <div className="flex justify-between w-full items-center">
                    <label htmlFor="email" className="text-gray-300">Email</label>
                    <input type="email" name="email" id="email" className="border-2 border-gray-300 rounded-xl w-2/3 focus:border-blue-400 focus:outline-none transition-colors duration-300" />
                </div>
                <div className="flex justify-between w-full items-center">
                    <label htmlFor="password" className="text-gray-300">Password</label>
                    <input type="password" name="password" id="password" className="border-2 border-gray-300 rounded-xl w-2/3 focus:border-blue-400 focus:outline-none transition-colors duration-300" />
                </div>
                <button type="submit" className="text-white text-xl border-2 border-white p-1 rounded-xl w-2/3 bg-transparent hover:bg-blue-400 hover:border-blue-400 transition-all duration-300 shadow-md shadow-black hover:shadow-lg hover:shadow-black">Submit</button>
            </form>
        </div>
    )
}

export default FormWithHoversFocuses
