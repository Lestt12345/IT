import { useState } from "react";
import { Link } from "react-router-dom";

function Count() {
    const [count, setCount] = useState(0);

    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <button onClick={() => setCount(count + 1)} className="bg-blue-500 text-white text-4xl border-2 border-blue-500 p-5 rounded-xl transition duration-150 active:scale-95 hover:bg-blue-600">Count: {count}</button>
            </div>
        </>
    );
}

export default Count