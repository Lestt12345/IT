import { Link } from 'react-router-dom'

function ChoiceTask() {
    return (
        <>
            <h1 className="absolute whitespace-nowrap italic top-10 left-1/2 transform -translate-x-1/2 text-4xl font-bold text-white text-center">
                Press <span className="text-blue-400 not-italic">Alt + Q</span> anywhere to return to this page.
            </h1>
            <div className="flex items-center justify-center w-screen h-screen gap-5">
                <div className="w-2/4 flex flex-wrap gap-5 justify-center">
                    <Link to="/task1" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Task 1</Link>
                    <Link to="/task2" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Task 2</Link>
                    <Link to="/task3" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Task 3</Link>
                    <Link to="/task4" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Task 4</Link>
                    <Link to="/task5" className="text-white text-4xl border-2 border-white p-5 rounded-xl">Task 5</Link>
                </div>
            </div>
        </>
    )
}

export default ChoiceTask
