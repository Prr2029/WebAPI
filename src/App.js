import './App.css';
import { UserAuthContextProvider } from './Context/UserAuthContextProvider';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import SignUp from './MyComponents/SignUp';
import Login from './MyComponents/Login';
import Home from './MyComponents/Home';

function App() {
  return (
    <UserAuthContextProvider>
    <Router>
      <Routes>
    {/* <Header title="EMSDashboard" /> */}
        <Route path='/' element={<Home/>}/>
        <Route path='/signup' element={<SignUp/>}/>
        <Route path='/signin' element={<Login/>}/>
     </Routes>
    </Router>
    </UserAuthContextProvider>
  );
}


export default App;
