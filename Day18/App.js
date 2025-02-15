import logo from './logo.svg';
import './App.css';
import {BrowserRouter as Router ,Routes,Route,Link} from 'react-router-dom';
import FuncCounter from './FuncCounter';
import { Employee } from './Employee';

function App() {
  return (
  
     <Router>
        <nav>
            <Link to="/">CounterusingUseStaeHook</Link> | <Link to="/Employee">Employee</Link>
        </nav>
      <Routes>
        <Route path="/" element={<FuncCounter/>}/>
        <Route path="/Employee" element={<Employee name="Wipro"/>}/>
      </Routes>
     </Router>
  );
}

export default App;
