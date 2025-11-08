import { Globe } from "lucide-react";

function LanguageSwitch({ theme, state, dispatchState }) {
  const isEnglish = state === "en";

  return (
    <button
      onClick={() => dispatchState({ type: "toggle" })}
      className={`flex items-center gap-2 px-3 py-[7px] rounded-full border ${theme === "dark" ? "border-gray-500" : "border-gray-400"} ${theme === "dark" ? "text-white" : "text-gray-800"} text-sm font-medium transition-all duration-300 hover:bg-blue-600 hover:text-white ${theme === "dark" ? "bg-gray-900" : "bg-white"}`}
    >
      <Globe size={12} />
      <span className="text-xs">{isEnglish ? "EN" : "UA"}</span>
    </button>
  );
}

export default LanguageSwitch;
