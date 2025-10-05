import { useState } from 'react'
import { Link } from 'react-router-dom'


function ChoiceTask() {
    const [count, setCount] = useState(0)

    return (
        <div className="flex items-center justify-center w-screen h-screen gap-5">
            <div className='w-2/4 flex flex-wrap gap-5 justify-center'>
                <Link to="/count" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Counter</Link>
                <Link to="/theme" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Theme Changer</Link>
                <Link to="/dispHideBlock" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Display/Hide Block</Link>
                <Link to="/reactionForMood" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Reaction For Mood</Link>
                <Link to="/likeDislike" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Like/Dislike</Link>
                <Link to="/tempMsg" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Temporary Message</Link>
                <Link to="/progressBar" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Progress Bar</Link>
            </div>
        </div>
    )
}

export default ChoiceTask
