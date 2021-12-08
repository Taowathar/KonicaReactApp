import React from 'react';
import Navbar from '../components/Navbar'
import DocumentDetails from '../components/DocumentDetails'

const DetailsPage = ({ user, loggedIn, documentId }) => {
    return (
        <>
            <Navbar user={user} loggedIn={loggedIn} />
            <DocumentDetails documentId={documentId} />
        </>
    );
}

export default DetailsPage;