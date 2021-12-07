import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Home from './pages';
import SignInPage from './pages/signin';
import SignUpPage from './pages/signup';

import './custom.css'

  const App = () => {

      return (
          <Router>
              <Switch>
                    <Route path="/" component={Home} exact />
                    <Route path="/signin" exact render={() => <SignInPage />} />
                    <Route path="/signup" component={SignUpPage} exact />
                </Switch>
            </Router>
      );
  }

  export default App;
