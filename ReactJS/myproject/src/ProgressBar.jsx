import { useState } from "react";
import { Link } from "react-router-dom";

function ProgressBar() {
    const [count, setCount] = useState(0);

    const handleClick = () => {
        if (count < 100) {
            setCount(count + 10);
        }
    }

    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5 flex-col">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <div className="flex items-center justify-between gap-5 w-80">
                    <div className="w-full bg-gray-400"><div className="h-8 bg-green-500 transition-all" style={{ width: `${count}%` }}></div></div>
                    <p className="text-4xl text-white">{count}%</p>
                </div>
                <button onClick={handleClick} className="text-white text-4xl border-2 p-5 rounded-xl">Increase progress</button>
            </div>
        </>
    )
}

export default ProgressBar