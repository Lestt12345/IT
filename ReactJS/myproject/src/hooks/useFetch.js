import { useState, useEffect, useMemo } from 'react';

function useFetch(url, options = {}) {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const memoizedOptions = useMemo(() => ({
    ...options,
    headers: {
      accept: 'application/json',
      Authorization: `Bearer ${import.meta.env.VITE_TMDB_API_TOKEN}`
    }
  }), [JSON.stringify(options)]);

  useEffect(() => {
    if (!url) return;

    const controller = new AbortController();
    const { signal } = controller;
    let isMounted = true;

    const fetchData = async () => {
      if (!isMounted) return;
      
      setLoading(true);
      setError(null);
      
      try {
        const response = await fetch(url, {
          ...memoizedOptions,
          signal
        });

        if (!response.ok) {
          const errorText = await response.text();
          throw new Error(`TMDB request failed with status ${response.status}: ${errorText}`);
        }

        const json = await response.json();

        if (!isMounted) return;

        setData(json);
      } catch (err) {
        if (err.name === 'AbortError') return;
        console.error('TMDB Fetch error:', err);
        if (isMounted) {
          setError(err.message);
        }
      } finally {
        if (isMounted) {
          setLoading(false);
        }
      }
    };

    fetchData();

    return () => {
      isMounted = false;
      controller.abort();
    };
  }, [url, memoizedOptions]);

  return { data, loading, error };
}

export default useFetch;
