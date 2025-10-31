import { Link } from "react-router-dom"

function NavBar() {
    return (
        <nav className="fixed flex justify-center w-screen p-2 align-center bg-zinc-900">
            <ul className="flex justify-around w-1/2">
                <li className="text-2xl font-bold text-white"><Link to="/task3/news">News</Link></li>
                <li className="text-2xl font-bold text-white"><Link to="/task3/galery">Galery</Link></li>
                <li className="text-2xl font-bold text-white"><Link to="/task3/faq">FAQ</Link></li>
            </ul>
        </nav>
    )
}

export default NavBar
