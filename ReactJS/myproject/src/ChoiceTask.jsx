import { Link } from 'react-router-dom'

function ChoiceTask() {

    return (
        <div className="flex items-center justify-center w-screen h-screen gap-5">
            <div className='w-2/4 flex flex-wrap gap-5 justify-center'>
                <Link to="/usercard" className="text-white text-4xl border-2 border-white p-5 rounded-xl">User Card</Link>
                <Link to="/counterbutton" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Counter Button</Link>
                <Link to="/formwithhoversfocuses" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Form With Hovers Focuses</Link>
                <Link to="/responsive" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Responsive Message</Link>
                <Link to="/interactivecard" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Interactive Card</Link>
            </div>
        </div>
    )
}

export default ChoiceTask
