import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { TableContainer, DocumentsTable, TableHead, TableHeader, HeaderCell, TableBody } from './DocumentListElements'
import Document from '../Document';

const DocumentList = ({ loggedIn }) => {
    let [documents, setDocuments] = useState(null);

    useEffect(() => {
        axios.get("api/document/0").then(response => {
            setDocuments(response.data);
        });
    }, []);

    return (
        <TableContainer>
            { documents && loggedIn ?
                <DocumentsTable>
                    <TableHead>
                        <TableHeader>
                            <HeaderCell>Id</HeaderCell>
                            <HeaderCell>Title</HeaderCell>
                            <HeaderCell>Extension</HeaderCell>
                            <HeaderCell>MainId</HeaderCell>
                            <HeaderCell>Source</HeaderCell>
                            <HeaderCell>Time</HeaderCell>
                        </TableHeader>
                    </TableHead>
                    <TableBody>
                        {documents.map((document) => (
                            <Document key={document.id} document={document} />
                        ))}
                    </TableBody>
                </DocumentsTable>
                : null}
        </TableContainer>
    );
}

export default DocumentList;