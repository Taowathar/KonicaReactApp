import React from 'react';
import { TableRow, TableData, DocumentLink } from './DocumentElements';

const Document = ({ document }) => {
    return (
        <TableRow>
            <TableData>{document.id}</TableData>
            <TableData><DocumentLink to={`/document/${document.id}`}>{document.title}</DocumentLink></TableData>
            <TableData>{document.extension}</TableData>
            <TableData>{document.mainId}</TableData>
            <TableData>{document.source}</TableData>
        </TableRow>
    );
}

export default Document;