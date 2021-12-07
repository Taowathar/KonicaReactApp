﻿import styled from 'styled-components'

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