import { useState, useEffect } from 'react';
import axios from "axios";
import { Link } from 'react-router-dom';

function Main() {
    const [users, setUsers] = useState([]);
    useEffect(() => {
        axios.get("https://jsonplaceholder.typicode.com/users").then((response) => {
            setUsers(response.data);
        });
    }, []);
    
    return (
        <div className="flex justify-center items-center w-full h-screen">
            <div className="flex flex-col gap-5 w-[350px] h-[350px] overflow-y-scroll custom-scrollbar bg-slate-500 rounded-lg p-5">
                {users.map((user) => (
                    <div className="mr-2">
                        <h1 className="text-xl font-bold">{user.name}</h1>
                        <Link className="text-gray-800 text-lg hover:text-gray-600" to={`user/${user.id}`}>Go to profile</Link>
                    </div>
                ))}
            </div>
        </div>
    );
}

export default Main
