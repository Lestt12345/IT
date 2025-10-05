import { useState } from "react";
import { Link } from "react-router-dom";

function DispHideBlock() {
    const [show, setShow] = useState(false);

    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <div className="flex items-center justify-center gap-5 flex-col">
                    <button onClick={() => setShow(!show)} className="text-white text-4xl border-2 border-white p-5 rounded-xl">{show ? 'Hide' : 'Show'}</button>
                    {show && <div className="bg-gray-400 border-gray-400 text-2xl flex items-center justify-center border-2 rounded-xl p-5">Hide/Show Block</div>}
                </div>
            </div>
        </>
    );
}

export default DispHideBlock