import React from 'react';
import { TableRow, TableData } from './EventDetailElements';

const EventDetail = ({ event }) => {
    return (
        <TableRow>
            <TableData>{event.title}</TableData>
            <TableData>{event.time}</TableData>
        </TableRow>
    );
}

export default EventDetail;