import * as React from 'react'
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Header from './Components/Header';
import Home from './Pages/Home'
import Criar from './Pages/Criar'
import Editar from './Pages/Editar'
import './App.css';

function App() {
  return (
    <div className="App">
      <Router>
        <Header />
        <Routes>
          <Route exact path='/' element={<Home />} />
          <Route path='/criar' element={<Criar />} />
          <Route path='/editar' element={<Editar />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;
