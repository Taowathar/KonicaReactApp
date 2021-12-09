import styled from 'styled-components';
import { Link } from 'react-router-dom';

export const TableRow = styled.tr`
    height: 30px;

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

export const ChildLink = styled(Link)`

    &:hover {
        text-decoration: none;
    }
`;