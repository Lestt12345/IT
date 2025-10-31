import { useParams } from 'react-router-dom';
import axios from 'axios';
import { useState, useEffect } from 'react';

function UserProfile() {
    const { id } = useParams();
    console.log(id)
    const [user, setUser] = useState(null);
    const [posts, setPosts] = useState(null);
    useEffect(() => {
        axios.get(`https://jsonplaceholder.typicode.com/users/${id}`).then((response) => {
            setUser(response.data);
        });
        axios.get(`https://jsonplaceholder.typicode.com/posts?userId=${id}`).then((response) => {
            setPosts(response.data);
        });
    }, []); 
    
    return (
        <div className="flex justify-center items-center w-full h-screen">
            <div className="flex flex-col gap-5 w-[700px] h-[700px] bg-slate-500 rounded-lg p-5">
                <p className="text-xl font-bold">Name: {user?.name}</p>
                <p className="text-xl font-bold">Email: {user?.email}</p>
                <p className="text-xl font-bold">Company: {user?.company.name}</p>
                <p className="text-xl font-bold">Address: {user?.address.city}, {user?.address.street}</p>

                <p className="text-xl font-bold">Posts:</p>
                <div className="flex flex-col gap-5 w-full h-full overflow-y-scroll custom-scrollbarLight bg-gray-400 rounded-lg p-5">
                    {posts?.map((post) => (
                        <div>
                            <p className="text-xl font-bold">{post.title}</p>
                            <p className="text-xl">{post.body}</p>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
}

export default UserProfile
