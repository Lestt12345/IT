import { useState } from "react";

function UserForm({ onSubmit }) {
    const [name, setName] = useState('')
    const [email, setEmail] = useState('')
    const [nameError, setNameError] = useState('')

    const handleSubmit = (e) => {
        e.preventDefault()
        if (name.trim() === '') {
            setNameError('Name cannot be empty')
            return
        }
        setNameError('')
        onSubmit({ name: name.trim(), email })
    }

    return (
        <div>
            <form className="flex flex-col gap-2" onSubmit={handleSubmit}>
                <div>
                    <input 
                        value={name}
                        onChange={(e) => setName(e.target.value)} 
                        className="outline-none p-2 border-2 border-gray-400 rounded-lg w-full" 
                        type="text" 
                        placeholder="Name"
                    />
                    {nameError && <p className="text-red-500 text-sm mt-1">{nameError}</p>}
                </div>
                <input 
                    value={email}
                    onChange={(e) => setEmail(e.target.value)} 
                    className="outline-none p-2 border-2 border-gray-400 rounded-lg" 
                    type="email" 
                    placeholder="Email"
                />
                <button className="p-2 border-2 border-gray-400 rounded-lg bg-blue-500 hover:bg-blue-600 text-white transition-colors" id="modalAddUserButton" type="submit">Add User</button>
            </form>
        </div>
    )
}

export default UserForm
