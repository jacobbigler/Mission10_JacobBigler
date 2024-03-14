import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowlers';

function App() {
  return (
    <div className="App">
      <Header title="Split Happens Bowling League" />
      <br />
      <BowlerList />
    </div>
  );
}

export default App;
