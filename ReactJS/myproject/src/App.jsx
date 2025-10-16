import { useState, useEffect } from 'react'
import axios from 'axios'
import UserForm from './UserForm'
import UserList from './UserList'
import SearchBar from './SearchBar'

function ChoiceTask() {
    const [ users, setUsers ] = useState([])
    const [ isLoading, setIsLoading ] = useState(true)
    const [ search, setSearch ] = useState('')
    
    useEffect(() => {
        setTimeout(() => {
            axios.get('https://jsonplaceholder.typicode.com/users')
                .then(response => {
                    const localUsers = localStorage.getItem('users')
                    const parsedLocalUsers = localUsers ? JSON.parse(localUsers) : []
                    const filteredApiUsers = response.data.map(user => ({
                        name: user.name,
                        email: user.email
                    }))
                    const allUsers = [...filteredApiUsers, ...parsedLocalUsers]
                    setUsers(allUsers)
                    setIsLoading(false)
                })
                .catch(error => {
                    alert(error)
                })
        }, 2000) // хай буде
    }, [])

    const [showModal, setShowModal] = useState(false);
    
    const handleAddUser = (user) => {
        if (user.email === "") {
            user.email = "No email"
        }
        const updatedUsers = [...users, user]
        localStorage.setItem('users', JSON.stringify(updatedUsers))
        setUsers(updatedUsers)
        document.getElementById('modalAddUserButton').disabled = true
        document.getElementById('modalCloseButton').style.display = 'none'
        document.getElementById('modalAddUserButton').innerHTML = 'Adding...'
        document.getElementById('modalAddUserButton').style.backgroundColor = 'gray'
        setTimeout(() => {
            document.getElementById('modalAddUserButton').disabled = false
            document.getElementById('modalCloseButton').style.display = 'block'
            document.getElementById('modalAddUserButton').innerHTML = 'Add user'
            document.getElementById('modalAddUserButton').style.backgroundColor = 'blue'
            setShowModal(false)
        }, 1000)
    }

    return (
        <div className="flex items-center justify-center w-screen h-screen gap-5">
            {showModal && (
                <div id="modalAddUser" className="modal fixed inset-0 bg-black bg-opacity-35 flex items-center justify-center z-50">
                    <div className="modal-content w-72 p-3 bg-slate-600 rounded-lg shadow-xl shadow-black relative">
                        <span id="modalCloseButton" className="close-button text-red-500 hover:text-red-700 transition-colors duration-300 text-3xl right-3 top-1 absolute cursor-pointer" onClick={() => {setShowModal(false)}}>&times;</span>
                        <h2 className="text-2xl font-bold mb-4 text-white">Add User</h2>
                        <UserForm onSubmit={handleAddUser} />
                    </div>
                </div>
            )}
            <div className="w-[400px] border-2 border-gray-400 rounded-lg pb-3">
                <div className="flex items-center gap-3 justify-between w-full p-3">
                    <SearchBar setSearch={setSearch} />
                    <button onClick={() => {setShowModal(true)}} className="bg-gray-400 hover:bg-gray-500 transition-colors duration-300 border-2 border-gray-500 text-white px-2 py-1 rounded-lg w-32">Add user</button>
                </div>
                {isLoading ? (
                    <UserList skeleton />
                ) : (
                    users.length > 0 ? (
                        <UserList users={search === '' ? users : users.filter(user => user.name.toLowerCase().includes(search.toLowerCase()))} />
                    ) : (
                        <p className="text-white text-xl">No users found...</p>
                    )
                )}
            </div>
        </div>
    )
}

export default ChoiceTask
