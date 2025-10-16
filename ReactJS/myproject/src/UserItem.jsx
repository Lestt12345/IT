import { useState } from "react";

function UserItem({ user }) {
    
    return (
        <div className="flex flex-col gap-2 border-2 bg-gray-700 border-gray-400 rounded-lg p-2">
            <p className="text-white">Name: {user.name}</p>
            <p className={user.email === "No email" ? "text-red-500" : "text-white"}>Email: {user.email}</p>
        </div>
    )
}

export default UserItem
