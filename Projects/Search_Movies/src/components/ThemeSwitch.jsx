import { useEffect } from "react";
import { Sun, Moon } from "lucide-react";

function ThemeSwitch({ theme, dispatchTheme }) {
  const darkMode = theme === "dark";

  useEffect(() => {
    document.documentElement.classList.toggle("dark", darkMode);
  }, [darkMode]);

  return (
    <button
      onClick={() => dispatchTheme({ type: "toggle" })}
      className={`relative w-16 h-8 flex items-center rounded-full transition-all duration-300 outline-none ${
        darkMode ? "bg-gray-900 border border-gray-500" : "bg-white border border-gray-400"
      }`}
    >
      <div
        className={`absolute left-1 w-6 h-6 rounded-full flex items-center justify-center transition-all duration-300 ${
          darkMode
            ? "translate-x-8 bg-blue-600 text-white"
            : "translate-x-0 bg-blue-600 text-white"
        }`}
      >
        {darkMode ? <Moon size={16} /> : <Sun size={16} />}
      </div>
      <div className="flex justify-between w-full px-2 text-gray-400">
        <Sun size={14} />
        <Moon size={14} />
      </div>
    </button>
  );
}

export default ThemeSwitch;
