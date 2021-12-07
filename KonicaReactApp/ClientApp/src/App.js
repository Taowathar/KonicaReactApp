import React, { useState } from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Logout from "./components/Logout";
import Home from './pages';
import SignInPage from './pages/signin';
import SignUpPage from './pages/signup';

import './custom.css'

const App = () => {
    let [user, setUser] = useState();
    let [loggedIn, setLoggedIn] = useState(false);

      return (
          <Router>
              <Switch>
                  <Route path="/" exact render={() => <Home user={user} loggedIn={loggedIn} />} />
                  <Route path="/signin" exact render={() => <SignInPage setUser={setUser} setLoggedIn={setLoggedIn} loggedIn={loggedIn} />} />
                  <Route path="/signup" component={SignUpPage} exact />
                  <Route path="/logout" exact render={() => <Logout setUser={setUser} setLoggedIn={setLoggedIn} />} />
                </Switch>
            </Router>
      );
  }

  export default App;
