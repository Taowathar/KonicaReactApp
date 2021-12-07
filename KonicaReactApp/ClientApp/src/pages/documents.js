import React from 'react';
import Navbar from '../components/Navbar'
import DocumentList from '../components/DocumentList'

const DocumentListPage = ({ user, loggedIn }) => {
    return (
        <>
            <Navbar user={user} loggedIn={loggedIn} />
            <DocumentList />
        </>
    );
}

export default DocumentListPage;