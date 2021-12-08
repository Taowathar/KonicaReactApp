import React from 'react';
import { TableRow, TableData, ChildLink } from './ChildDetailElements';

const ChildDetail = ({ document, setDocumentId }) => {

    const setId = () => {
        setDocumentId(document.id);
    };

    return (
        <TableRow>
            <TableData>{document.id}</TableData>
            <TableData><ChildLink to={`/details/${document.id}`} onClick={setId}>{document.title}</ChildLink></TableData>
            <TableData>{document.source}</TableData>
        </TableRow>
    );
}

export default ChildDetail;