import { Link } from "react-router-dom";
import { useState } from "react";

function LikeDislike() {
    const [rate, setRate] = useState(0);

    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <button onClick={() => rate === 1 ? setRate(0) : setRate(1)} className={`${rate === 1 ? 'border-white' : 'border-transparent'} text-4xl border-2 px-3 pt-2 pb-5 rounded-xl`}>👍</button>
                <button onClick={() => rate === -1 ? setRate(0) : setRate(-1)} className={`${rate === -1 ? 'border-white' : 'border-transparent'} text-4xl border-2 px-3 pt-3 pb-4 rounded-xl`}>👎</button>
            </div>
        </>
    );
}

export default LikeDislike