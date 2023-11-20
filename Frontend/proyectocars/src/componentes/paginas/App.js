import './App.css';
import Header from '../Templates/Header';
import Body from '../Templates/Body';
import Footer from '../Templates/Footer';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Header/>
      </header>
      <body>
        <Body/>
      </body>
      <footer>
        <Footer/>
      </footer>
    </div>
  );
}

export default App;
