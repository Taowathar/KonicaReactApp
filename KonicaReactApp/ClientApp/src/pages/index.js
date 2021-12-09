import React from 'react';
import Navbar from '../components/Navbar'


const Home = ({ user, loggedIn }) => {

    return (
        <>
            <Navbar user={user} loggedIn={loggedIn} />
        </>
    );
}

export default Home;