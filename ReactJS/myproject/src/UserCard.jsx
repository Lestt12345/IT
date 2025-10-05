import { Link } from "react-router-dom";
import { useState } from "react";

function UserCard() {
    const [isOnline, setIsOnline] = useState(true);

    return (
        <div className="flex flex-col items-center justify-center w-screen h-screen gap-5">
            <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
            <div className="bg-gray-300 p-5 rounded-xl w-28 h-28 items-center justify-center flex flex-col gap-1 relative">
                <div className={`absolute top-1 right-1 w-3 h-3 ${isOnline ? 'bg-green-500' : 'bg-red-500'} rounded-full`}></div>
                <h1>John Doe</h1>
                <h2>Age: 25</h2>
            </div>
            <button onClick={() => setIsOnline(!isOnline)} className="text-gray-300 text-xl border-2 border-gray-300 p-2 rounded-xl">{isOnline ? 'Make offline' : 'Make online'}</button>
        </div>
    )
}

export default UserCard