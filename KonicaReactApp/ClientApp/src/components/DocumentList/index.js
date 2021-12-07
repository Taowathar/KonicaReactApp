import React from 'react';
import { TableContainer, DocumentsTable, TableHead, TableHeader, HeaderCell } from './DocumentListElements'

const DocumentList = () => {
    return (
        <TableContainer>
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
            </DocumentsTable>
        </TableContainer>
    );
}

export default DocumentList;