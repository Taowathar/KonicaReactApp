import React from 'react';
import Navbar from '../components/Navbar'
import DocumentList from '../components/DocumentList'

const DocumentListPage = ({ user, loggedIn, setDocumentId }) => {
    return (
        <>
            <Navbar user={user} loggedIn={loggedIn} />
            <DocumentList loggedIn={loggedIn} setDocumentId={setDocumentId} />
        </>
    );
}

export default DocumentListPage;