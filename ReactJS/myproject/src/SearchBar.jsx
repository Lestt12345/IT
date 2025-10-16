function SearchBar({ setSearch }) {
    return (
        <input className="w-full py-1 px-3 border-2 bg-gray-200 border-gray-400 rounded-lg outline-none" type="text" placeholder="Search..." onChange={(e) => setSearch(e.target.value)} />
    )
}

export default SearchBar