import React from 'react';
import SignIn from '../components/SignIn'

const SignInPage = ({ setUser, setLoggedIn, loggedIn }) => {
    return (
        <>
            <SignIn setUser={setUser} setLoggedIn={setLoggedIn} loggedIn={loggedIn} />
        </>
    );
}

export default SignInPage;