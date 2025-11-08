// ТАКОЖ ФІШКА ВІД МЕНЕ))

import { createContext, useContext, useReducer } from "react";

const ThemeReducer = (theme, action) => {
    switch (action.type) {
        case "toggle":
            if (theme === "dark") {
                localStorage.setItem("theme", "light");
                return "light";
            }
            else {
                localStorage.setItem("theme", "dark");
                return "dark";
            }
        default:
            return theme;
    }
};

const defaultState = localStorage.getItem("theme") || "light";

const ThemeContext = createContext({
    theme: defaultState,
    dispatchTheme: () => {}
});

const ThemeProvider = ({ children }) => {
    const [theme, dispatchTheme] = useReducer(ThemeReducer, defaultState);
    return (
        <ThemeContext.Provider value={{ theme, dispatchTheme }}>
            {children}
        </ThemeContext.Provider>
    );
};

const useTheme = () => {
    return useContext(ThemeContext);
};

export { ThemeProvider, useTheme };
