import { useState } from "react";
import { Link } from "react-router-dom";

function CounterButton() {
    const [count, setCount] = useState(0);
    return (
        <div className="flex flex-col items-center justify-center w-screen h-screen">
            <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
            <button className="text-white text-4xl border-2 border-white p-5 rounded-xl" onClick={() => setCount(count + 1)}>Count: {count}</button>
        </div>
    )
}

export default CounterButton
