import { Link } from "react-router-dom";

function ReactionForMood() {
    return (
        <>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <Link to="/" className="text-gray-300 text-xl border-2 border-gray-300 absolute right-3 top-3 p-2 rounded-xl">Home</Link>
                <button className="bg-green-300 text-4xl border-4 border-green-400 p-5 rounded-xl hover:scale-110 transition" onClick={() => alert('Happy')}>😄</button>
                <button className="bg-blue-300 text-4xl border-4 border-blue-400 p-5 rounded-xl hover:scale-110 transition" onClick={() => alert('Neutral')}>😐</button>
                <button className="bg-gray-300 text-4xl border-4 border-gray-400 p-5 rounded-xl hover:scale-110 transition" onClick={() => alert('Sad')}>😢</button>
            </div>
        </>
    )
}

export default ReactionForMood