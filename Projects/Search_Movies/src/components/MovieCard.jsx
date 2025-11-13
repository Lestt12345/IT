import { useState, Fragment, useEffect } from 'react';
import { Dialog, Transition } from '@headlessui/react';

const IMAGE_BASE_URL = 'https://image.tmdb.org/t/p/w500';
const API_KEY = 'a28aac2ad517c600c3253936d9943ead';
const API_URL = 'https://api.themoviedb.org/3';

function MovieCard({ movie, state, theme }) {
  const [isOpen, setIsOpen] = useState(false);
  const [isOverviewAvailableOnUA, setIsOverviewAvailableOnUA] = useState(true);

  useEffect(() => {
  function isEnglish(text) {
    // A simple check for English text - looks for common English words and characters
    if (!text) return false;
    const englishCommonWords = ['the', 'and', 'to', 'of', 'a', 'in', 'that', 'it', 'is', 'was', 'for', 'on', 'with', 'as', 'at', 'by', 'from'];
    const textLower = text.toLowerCase();
    return englishCommonWords.some(word => textLower.includes(` ${word} `) || 
                                         textLower.startsWith(`${word} `) || 
                                         textLower.endsWith(` ${word}`));
  }

  async function fetchEnglishIfMissing() {
    if (movie.overview && isEnglish(movie.overview) && state === "ua") {
      setIsOverviewAvailableOnUA(false);
    }
    if (movie.overview && movie.overview.trim().length > 0) return;

    try {
      const res = await fetch(`${API_URL}/movie/${movie.id}?language=en-US&api_key=${API_KEY}`);
      const data = await res.json();

      if (!movie.overview && state === "ua") {
        movie.overview = data.overview;
        setIsOverviewAvailableOnUA(false);
      }
    } catch (error) {
      console.error("Error fetching English overview:", error);
    }
  }

  fetchEnglishIfMissing();
}, [movie]);


  const posterUrl = movie.poster_path
    ? `${IMAGE_BASE_URL}${movie.poster_path}`
    : null;

  const closeModal = () => setIsOpen(false);
  const openModal = () => setIsOpen(true);

  return (
    <>
      <div className={`${theme === "dark" ? "bg-gray-800" : "bg-gray-100"} rounded-lg shadow-md overflow-hidden hover:shadow-lg transition-colors duration-200 border border-gray-700 flex flex-col justify-between ${theme === "dark" ? "bg-gray-800" : "bg-gray-100"}`}>
        {posterUrl ? (
          <img
            src={posterUrl}
            alt={movie.title}
            className="w-full h-64 object-cover"
          />
        ) : (
          <div className={`w-full h-64 ${theme === "dark" ? "bg-gray-800" : "bg-gray-100"} flex items-center justify-center`}>
            {state === "en" ? "No Image Available" : "Немає зображення"}
          </div>
        )}

        <div className={`p-4`}>
          <h3 className={`text-lg font-semibold mb-2 ${theme === "dark" ? "text-white" : "text-gray-900"}`}>
            {movie.title}
          </h3>
          <p className={`text-sm ${theme === "dark" ? "text-gray-400" : "text-gray-900"}`}>
            {movie.release_date ? movie.release_date.split('-')[0] : ''}
          </p>
        </div>
        <button className={`bg-blue-600 text-white px-4 py-2 rounded-lg hover:bg-blue-700 transition-colors m-4 ${theme === "dark" ? "bg-blue-600" : "bg-blue-600"}`} onClick={openModal}>{state === "en" ? "View Details" : "Переглянути деталі"}</button>
      </div>

      <Transition appear show={isOpen} as={Fragment}>
        <Dialog as="div" className="relative z-50" onClose={closeModal}>
          <Transition.Child
            as={Fragment}
            enter="ease-out duration-300"
            enterFrom="opacity-0"
            enterTo="opacity-100"
            leave="ease-in duration-200"
            leaveFrom="opacity-100"
            leaveTo="opacity-0"
          >
            <div className="fixed inset-0 bg-black bg-opacity-75" />
          </Transition.Child>

          <div className="fixed inset-0 overflow-y-auto">
            <div className="flex min-h-full items-center justify-center p-4 text-center">
              <Transition.Child
                as={Fragment}
                enter="ease-out duration-300"
                enterFrom="opacity-0 scale-95"
                enterTo="opacity-100 scale-100"
                leave="ease-in duration-200"
                leaveFrom="opacity-100 scale-100"
                leaveTo="opacity-0 scale-95"
              >
                <Dialog.Panel className={`w-full max-w-3xl transform overflow-hidden rounded-2xl ${theme === "dark" ? "bg-gray-800" : "bg-gray-100"} p-6 text-left align-middle shadow-xl transition-all ${theme === "dark" ? "bg-gray-800" : "bg-gray-100"}`}>
                  <div className="flex flex-col md:flex-row gap-6">
                    <div className="w-full md:w-1/3">
                      {posterUrl ? (
                        <img
                          src={posterUrl}
                          alt={movie.title}
                          className="w-full h-full object-contain max-h-[70vh] mx-auto"
                        />
                      ) : (
                        <div className={`w-full h-full ${theme === "dark" ? "bg-gray-800" : "bg-gray-100"} flex items-center justify-center`}>
                          {state === "en" ? "No Image Available" : "Немає зображення"}
                        </div>
                      )}
                    </div>
                    <div className="flex-1">
                      <Dialog.Title
                        as="h3"
                        className={`text-2xl font-bold leading-6 mb-2 ${theme === "dark" ? "text-white" : "text-gray-900"}`}
                      >
                        {movie.title}{' '}
                        {movie.release_date && (
                          <span className={`ml-2 ${theme === "dark" ? "text-white" : "text-gray-900"}`}>
                            ({movie.release_date.split('-')[0]})
                          </span>
                        )}
                      </Dialog.Title>

                      {movie.overview && (
                        <div className="mt-4">
                          <h4 className={`text-lg font-semibold mb-2 ${theme === "dark" ? "text-white" : "text-gray-900"}`}>
                            {state === "en" ? "Overview" : "Огляд"}
                          </h4>
                          <p className={`text-gray-300 ${theme === "dark" ? "text-white" : "text-gray-900"}`}>{movie.overview ? movie.overview : state === "en" ? "No overview available" : "Немає огляду"}</p>
                        </div>
                      )}

                      {!isOverviewAvailableOnUA && state === "ua" && (
                        <div className={`mt-4 rounded-lg ${theme === "dark" ? "bg-red-900/30" : "bg-red-100"} border-l-4 border-red-500 ${theme === "dark" ? "text-red-200" : "text-red-400"} p-2 mb-6`}>
                          <p>Огляд не доступний на українську мові</p>
                        </div>
                      )}

                      <div className="mt-6 flex flex-wrap gap-4">
                        {movie.id && (
                          <a
                            href={`https://www.themoviedb.org/movie/${movie.id}`}
                            target="_blank"
                            rel="noopener noreferrer"
                            className={`inline-flex items-center px-4 py-2 bg-blue-600 text-white rounded-md hover:bg-blue-700 transition-colors ${theme === "dark" ? "bg-blue-600" : "bg-blue-600"}`}
                          >
                            {state === "en" ? "View on TMDB" : "Переглянути на TMDB"}
                          </a>
                        )}
                      </div>
                    </div>
                  </div>

                  <div className="mt-6 flex justify-end">
                    <button
                      type="button"
                      className={`px-4 py-2 text-sm font-medium text-white bg-gray-700 border border-transparent rounded-md hover:bg-gray-600 focus:outline-none ${theme === "dark" ? "bg-gray-700" : "bg-gray-600"}`}
                      onClick={closeModal}
                    >
                      {state === "en" ? "Close" : "Закрити"}
                    </button>
                  </div>
                </Dialog.Panel>
              </Transition.Child>
            </div>
          </div>
        </Dialog>
      </Transition>
    </>
  );
}

export default MovieCard;
