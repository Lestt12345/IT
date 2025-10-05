import { useState } from "react"
import { Link } from "react-router-dom"

function ThemeChange() {
    const [theme, setTheme] = useState('dark')

    return (
        <>
            <div className={`${theme === 'dark' ? 'bg-slate-800' : 'bg-white'} transition-colors duration-500 flex items-center justify-center w-screen h-screen gap-5`}>
                <Link to="/" className={`${theme === 'dark' ? 'text-gray-300' : 'text-gray-700'} ${theme === 'dark' ? 'border-gray-300' : 'border-gray-700'} text-xl border-2 absolute right-3 top-3 p-2 rounded-xl transition-all duration-500`}>Home</Link>
                <div className={`bg-gray-400 border-gray-400 flex items-center justify-center border-2 ${theme === 'dark' ? 'bg-slate-800' : 'bg-white'}  rounded-xl transition-all duration-500 overflow-hidden`}>
                    <div onClick={() => setTheme('dark')} className={`cursor-pointer text-slate-800' text-2xl p-1 pt-0 pb-0.5 ${theme === 'dark' ? 'bg-gray-600' : 'bg-transparent'} select-none transition-all duration-500`}>Dark</div>
                    <div onClick={() => setTheme('light')} className={`cursor-pointer text-white text-2xl p-1 pt-0 pb-0.5 ${theme === 'dark' ? 'bg-transparent' : 'bg-gray-600'} select-none transition-all duration-500`}>Light</div>
                </div>
            </div>
        </>
    )
}

export default ThemeChange
