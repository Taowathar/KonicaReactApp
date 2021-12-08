import React, { useState } from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Logout from "./components/Logout";
import Home from './pages';
import SignInPage from './pages/signin';
import SignUpPage from './pages/signup';
import DocumentListPage from './pages/documents';
import DetailsPage from './pages/details'

import './custom.css'

const App = () => {
    let [user, setUser] = useState();
    let [loggedIn, setLoggedIn] = useState(false);
    let [documentId, setDocumentId] = useState();

      return (
          <Router>
              <Switch>
                  <Route path="/" exact render={() => <Home user={user} loggedIn={loggedIn} />} />
                  <Route path="/signin" exact render={() => <SignInPage setUser={setUser} setLoggedIn={setLoggedIn} loggedIn={loggedIn} />} />
                  <Route path="/signup" component={SignUpPage} exact />
                  <Route path="/logout" exact render={() => <Logout setUser={setUser} setLoggedIn={setLoggedIn} />} />
                  <Route path="/documents" exact render={() => <DocumentListPage user={user} loggedIn={loggedIn} setDocumentId={setDocumentId} />} />
                  <Route path="/details/:documentId" exact render={() => <DetailsPage user={user} loggedIn={loggedIn} documentId={documentId} />} />
                </Switch>
            </Router>
      );
  }

  export default App;
