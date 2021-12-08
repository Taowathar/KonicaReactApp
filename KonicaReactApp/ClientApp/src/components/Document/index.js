import React from 'react';
import { TableRow, TableData, DocumentLink } from './DocumentElements';

const Document = ({ document, setDocumentId }) => {

    const setId = () => {
        setDocumentId(document.id);
    }

    return (
        <TableRow>
            <TableData>{document.id}</TableData>
            <TableData><DocumentLink to={`/details/${document.id}`} onClick={setId}>{document.title}</DocumentLink></TableData>
            <TableData>{document.extension}</TableData>
            <TableData>{document.mainId}</TableData>
            <TableData>{document.source}</TableData>
            <TableData>{document.time}</TableData>
        </TableRow>
    );
}

export default Document;