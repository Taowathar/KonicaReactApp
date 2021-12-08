import React from 'react';
import { DetailsH1,TableContainer, EventTable, EventTableHead, EventTableHeader, EventHeaderCell, EventTableBody, ChildTable, ChildTableHead, ChildTableHeader, ChildHeaderCell, ChildTableBody} from './DocumentDetailsElements'

const DocumentDetails = ({ documentId }) => {
    return (
        <>
        <DetailsH1>TITLE</DetailsH1>
        <TableContainer>
            <EventTable>
                <EventTableHead>
                    <EventTableHeader>
                        <EventHeaderCell>Event</EventHeaderCell>
                        <EventHeaderCell>Time</EventHeaderCell>
                    </EventTableHeader>
                </EventTableHead>
                <EventTableBody>
                    
                </EventTableBody>
            </EventTable>

            <ChildTable>
                <ChildTableHead>
                    <ChildTableHeader>
                        <ChildHeaderCell>Title</ChildHeaderCell>
                        <ChildHeaderCell>Source</ChildHeaderCell>
                        <ChildHeaderCell>Time</ChildHeaderCell>
                    </ChildTableHeader>
                </ChildTableHead>
                <ChildTableBody>

                </ChildTableBody>
            </ChildTable>
            </TableContainer>
        </>
    );
}

export default DocumentDetails;