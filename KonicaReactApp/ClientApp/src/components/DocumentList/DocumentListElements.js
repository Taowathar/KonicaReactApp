import styled from 'styled-components';


export const TableContainer = styled.div`
    display: flex;
    justify-content: center;
    width: 90%;
    margin-left: auto;
    margin-right: auto;
`;

export const DocumentsTable = styled.table`
    margin-top: 50px;
    width: 90%;
    font-size: 25px;
`;

export const TableHead = styled.thead`
    text-align: center;
    background: #000;
    color: #fff;
`;

export const TableHeader = styled.tr`
    height: 40px;
`;

export const HeaderCell = styled.th`
    border: 1px solid #01bf71;
`;

export const TableBody = styled.tbody`

`;

export const SearchFormContainer = styled.div`
    width: 50%;
    max-width: 500px;
    margin-top: 30px;
    margin-left: auto;
    margin-right: auto;
    font-size: 20px;
    border: 1px solid #000;
    border-radius: 5px;
    background: burlywood;
`;

export const Form = styled.form`
    margin: 10px;
    height: 50px;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
`;

export const FormLabel = styled.label`
    margin-bottom: 0;
    font-weight: 700;
    font-size: 30px;
`;

export const FormInput = styled.input`
    height: 50px;
    border-radius: 5px;
    text-align: center;
`;

export const FormButton = styled.button`
    display: flex;
    justify-content: center;
    align-items: center;
    background: #01bf71;
    padding: 8px;
    border-radius: 4px;
    color: #fff;
    font-size: 20px;
    cursor: pointer;

    &:hover {
        text-decoration: none;
        background: #fff;
        color: #000;
    }
`;