import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { TableContainer, DocumentsTable, TableHead, TableHeader, HeaderCell, TableBody, SearchFormContainer, Form, FormLabel, FormInput, FormButton } from './DocumentListElements'
import Document from '../Document';

const DocumentList = ({ loggedIn, setDocumentId }) => {
    let [documents, setDocuments] = useState(null);
    let [searchString, setSearchString] = useState(null);

    useEffect(() => {
        axios.get("api/document/0").then(response => {
            setDocuments(response.data);
        });
    }, []);

    const search = (e) => {
        e.preventDefault();
        axios.get(`api/document/search/${searchString.search}`).then(response => {
            setDocuments(response.data);
        });
    };

    const onChange = (e) => {
        e.persist();
        setSearchString({ ...searchString, [e.target.name]: e.target.value });
    };

    return (
        <>
            {loggedIn ?
                <SearchFormContainer>
                    <Form onSubmit={search}>
                        <FormLabel htmlfor='for'>Search</FormLabel>
                        <FormInput type='text' name="search" placeholder='search' required onChange={onChange} />
                        <FormButton type='submit'>Search</FormButton>
                    </Form>
                </SearchFormContainer>
                : null}
            <TableContainer>
                {documents && loggedIn ?
                    <DocumentsTable>
                        <TableHead>
                            <TableHeader>
                                <HeaderCell>Id</HeaderCell>
                                <HeaderCell>Title</HeaderCell>
                                <HeaderCell>Extension</HeaderCell>
                                <HeaderCell>MainId</HeaderCell>
                                <HeaderCell>Source</HeaderCell>
                            </TableHeader>
                        </TableHead>
                        <TableBody>
                            {documents.map((document) => (
                                <Document key={document.id} document={document} setDocumentId={setDocumentId} />
                            ))}
                        </TableBody>
                    </DocumentsTable>
                    : null}
            </TableContainer>
        </>
    );
}

export default DocumentList;