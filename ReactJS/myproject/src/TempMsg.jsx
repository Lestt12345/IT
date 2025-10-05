import { useEffect, useState } from "react";
import { Link } from "react-router-dom";

function TempMsg() {
    const [showMsg, setShowMsg] = useState(false);

    useEffect(() => {
        if (showMsg) {
            setTimeout(() => {
                setShowMsg(false);
            }, 3000);
        }
        return () => clearTimeout();
    }, [showMsg]);

    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <button onClick={() => setShowMsg(true)} className="text-white text-4xl border-2 p-5 rounded-xl transition duration-150">Confirm</button>
                {showMsg && <div id ="tempMsg" className="animate-fade-in bg-green-400 text-white shadow-xl absolute bottom-8 shadow-green-400 text-4xl border-4 border-green-600 p-5 rounded-xl">Дякуємо!</div>}
            </div>
        </>
    );
}

export default TempMsg;
