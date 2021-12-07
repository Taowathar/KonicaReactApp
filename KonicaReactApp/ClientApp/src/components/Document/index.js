import React from 'react';
import { TableRow, TableData } from './DocumentElements';

const Document = ({ document }) => {
    return (
        <TableRow>
            <TableData>{document.id}</TableData>
            <TableData>{document.title}</TableData>
            <TableData>{document.extension}</TableData>
            <TableData>{document.mainId}</TableData>
            <TableData>{document.source}</TableData>
        </TableRow>
    );
}

export default Document;