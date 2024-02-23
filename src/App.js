import './App.css';
import { UserAuthContextProvider } from './Context/UserAuthContextProvider';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import SignUp from './MyComponents/SignUp';
import SignIn from './MyComponents/SignIn';
import Home from './MyComponents/Home';
import Header from './MyComponents/Header';
import LogSheet from './MyComponents/LogSheet';
import CourseModule from './MyComponents/CourseModule';



function App() {
  return (
    <UserAuthContextProvider>
      <Header/>
    <Router>
      <Routes>
        <Route path='/' element={<Home/>}/>
        <Route path='/signup' element={<SignUp/>}/>
        <Route path='/signin' element={<SignIn/>}/>
        <Route path='/logsheet' element={<LogSheet/>}/>
        <Route path='/courseModule' element={<CourseModule/>}/>

     </Routes>
    </Router>
    </UserAuthContextProvider>
  );
}


export default App;
