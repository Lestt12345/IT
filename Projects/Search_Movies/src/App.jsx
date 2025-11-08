import { useState, useMemo } from 'react';
import useFetch from './hooks/useFetch';
import MovieCard from './components/MovieCard';
import { useCurrentTranslateOption } from './contexts/CurrentTranslateOption';
import { useTheme } from './contexts/Theme';
import { IoCloseSharp } from 'react-icons/io5';
import ThemeSwitch from './components/ThemeSwitch';
import LanguageSwitch from './components/LanguageSwitch';

const API_URL = '/api'; // Vite proxy к TMDB

function App() {
  const [searchTerm, setSearchTerm] = useState('');
  const [query, setQuery] = useState('');
  const [page, setPage] = useState(1);
  const { state, dispatchState } = useCurrentTranslateOption();
  const { theme, dispatchTheme } = useTheme();

  const { data, loading, error } = useFetch(
    query
      ? `${API_URL}/search/movie?query=${encodeURIComponent(query)}&api_key=a28aac2ad517c600c3253936d9943ead`
      : `${API_URL}/movie/popular?language=${state === "en" ? "en-US" : "uk-UA"}&page=${page}&api_key=a28aac2ad517c600c3253936d9943ead`,
    useMemo(() => ({
      method: 'GET',
      headers: {
        Authorization: `Bearer ${import.meta.env.VITE_TMDB_API_TOKEN}`,
      },
    }), [query, page])
  );

  const handleSubmit = (e) => {
    e.preventDefault();
    if (searchTerm.trim()) {
      setQuery(searchTerm);
      setPage(1);
    }
    window.scrollTo({ top: 0, behavior: 'smooth' });
  };

  const handleClearInput = (e) => {
    e.preventDefault();
    setSearchTerm("");
    setQuery("");
    setPage(1);
  };
    
  const results = useMemo(() => data?.results || [], [data]);

  return (
    <>
      <div className='absolute top-2 right-2 flex gap-2 justify-center items-center'>
        <ThemeSwitch theme={theme} dispatchTheme={dispatchTheme} />
        <LanguageSwitch theme={theme} state={state} dispatchState={dispatchState} />
      </div>
      <div className={`min-h-screen ${theme === "dark" ? "bg-gray-900" : "bg-gray-100"} py-8 px-4 transition-colors duration-200`}>
        <div className="max-w-7xl mx-auto">
            <h1 className={`text-4xl font-bold text-center sm:pt-0 pt-2 mb-8 ${theme === "dark" ? "text-white" : "text-gray-900"}`}>
            {state === "en" ? "Movie Search" : "Пошук фільмів"}
            </h1>

            <form onSubmit={handleSubmit} className="mb-8 max-w-2xl mx-auto">
            <div className="flex gap-2 relative">
                <div className="relative w-full">
                    <input
                        type="text"
                        value={searchTerm}
                        onChange={(e) => setSearchTerm(e.target.value)}
                        placeholder={state === "en" ? "Enter a movie title..." : "Введіть назву фільму..."}
                        className={`transition-colors duration-200 w-full outline-none flex-1 px-4 py-2 pr-10 border border-gray-700 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-transparent ${
                        theme === "dark" ? "bg-gray-800 text-white" : "bg-gray-100 text-gray-900"
                        }`}
                    />

                    {searchTerm && (
                        <button
                            type="button"
                            onClick={handleClearInput}
                            className={`w-10 h-10 flex items-center justify-center ${theme === "dark" ? "bg-gray-700" : "bg-gray-100"} rounded-r-lg absolute right-[1px] top-1/2 -translate-y-1/2 hover:text-gray-500 transition-colors transition-100 ${theme === "dark" ? "text-white" : "text-black"}`}
                            disabled={loading}
                            >
                            <IoCloseSharp size={20} />
                        </button>
                    )}
                  </div>

                  <button
                      type="submit"
                      className={`outline-none bg-blue-600 text-white px-6 py-2 rounded-lg hover:bg-blue-700 transition-colors ${theme === "dark" ? "bg-blue-600" : "bg-blue-600"}`}
                      disabled={loading}
                      >
                      {loading ? (state === "en" ? "Searching..." : "Пошук...") : (state === "en" ? "Search" : "Пошук")}
                  </button>
              </div>
            </form>

            {error && (
            <div className={`bg-red-900/30 border-l-4 border-red-500 text-red-200 p-4 mb-6 rounded ${theme === "dark" ? "bg-red-900/30" : "bg-red-100"}`}>
                <p>{error}</p>
            </div>
            )}

            {loading && (
            <div className={`flex justify-center items-center py-12 ${theme === "dark" ? "bg-gray-900" : "bg-gray-100"}`}>
                <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-blue-500"></div>
            </div>
            )}

            {results.length > 0 ? (
            <div className={`grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 transition-colors duration-200 gap-6 ${theme === "dark" ? "bg-gray-900" : "bg-gray-100"}`}>
                {results.map((movie) => (
                    <MovieCard key={movie.id} movie={movie} state={state} theme={theme} />
                ))}
            </div>
            ) : (
            !loading &&
            !error &&
            query && (
                <div className={`text-center py-12 ${theme === "dark" ? "bg-gray-900" : "bg-gray-100"}`}>
                <p className="text-gray-400 text-lg">
                    {state === "en" ? "No movies found. Try another search." : "Фільми не знайдено. Спробуйте інший пошук."}
                </p>
                </div>
            )
            )}
        </div>
      </div>
    </>
  );
}

export default App;
