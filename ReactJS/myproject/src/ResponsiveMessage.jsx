import { Link } from "react-router-dom";

function ResponsiveMessage() {
    return (
        <div className="flex items-center justify-center w-screen h-screen">
            <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
            <div>
                <p className="block sm:hidden text-sm text-green-500 font-semibold">Ви використовуєте мобільний пристрій</p>
                <p className="hidden sm:block text-2xl text-blue-500 font-semibold">Ви використовуєте десктоп</p>
            </div>
        </div>
    )
}

export default ResponsiveMessage