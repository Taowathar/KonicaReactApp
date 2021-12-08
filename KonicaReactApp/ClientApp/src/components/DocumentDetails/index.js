import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { DetailsH1,TableContainer, EventTable, EventTableHead, EventTableHeader, EventHeaderCell, EventTableBody, ChildTable, ChildTableHead, ChildTableHeader, ChildHeaderCell, ChildTableBody} from './DocumentDetailsElements'
import EventDetail from '../EventDetail'
import ChildDetail from '../ChildDetail'

const DocumentDetails = ({ documentId }) => {
    let [title, setTitle] = useState(null);

    useEffect(() => {
        axios.get(`api/document/title/${documentId}`).then(response => {
            setTitle(response.data.title);
        });
    }, []);

    return (
        <>
        { title ? <DetailsH1>{title}</DetailsH1> : null }
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
                        <ChildHeaderCell>Id</ChildHeaderCell>
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