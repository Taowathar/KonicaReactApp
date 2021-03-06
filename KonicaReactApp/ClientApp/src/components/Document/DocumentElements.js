import styled from 'styled-components';
import { Link } from 'react-router-dom';

export const TableRow = styled.tr`
    height: 40px;

    &:nth-child(even) {
        background: aliceblue;
    }

    &:nth-child(odd) {
        background: antiquewhite;
    }
`;

export const TableData = styled.td`
    text-align: center;
    border: 1px solid #01bf71;
`;

export const DocumentLink = styled(Link)`

    &:hover {
        text-decoration: none;
    }
`;