import React from 'react';
import Navbar from '../components/Navbar'
import DocumentDetails from '../components/DocumentDetails'

const DetailsPage = ({ user, loggedIn, documentId, setDocumentId }) => {
    return (
        <>
            <Navbar user={user} loggedIn={loggedIn} />
            <DocumentDetails documentId={documentId} setDocumentId={setDocumentId}/>
        </>
    );
}

export default DetailsPage;