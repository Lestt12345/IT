import { Routes, Route } from "react-router-dom";
import Main from "./_Main";
import About from "./About";
import Contacts from "./Contacts";

function App() {
    return (
        <Routes>
            <Route index element={<Main />} />
            <Route path="about" element={<About />} />
            <Route path="contacts" element={<Contacts />} />
        </Routes>
    );
}

export default App
