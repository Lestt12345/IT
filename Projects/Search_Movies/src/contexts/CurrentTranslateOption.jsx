// ФІШКА ВІД МЕНЕ))

import { createContext, useContext, useReducer } from "react";

const CurrentTranslateOptionReducer = (state, action) => {
    switch (action.type) {
        case "toggle":
            if (state === "en") {
                localStorage.setItem("translate", "ua");
                return "ua";
            }
            else {
                localStorage.setItem("translate", "en");
                return "en";
            }
        default:
            return state;
    }
};

const defaultState = localStorage.getItem("translate") || "en";

const CurrentTranslateOptionContext = createContext({
    state: defaultState,
    dispatchState: () => {}
});

const CurrentTranslateOptionProvider = ({ children }) => {
    const [state, dispatchState] = useReducer(CurrentTranslateOptionReducer, defaultState);
    return (
        <CurrentTranslateOptionContext.Provider value={{ state, dispatchState }}>
            {children}
        </CurrentTranslateOptionContext.Provider>
    );
};

const useCurrentTranslateOption = () => {
    return useContext(CurrentTranslateOptionContext);
};

export { CurrentTranslateOptionProvider, useCurrentTranslateOption };
