import styled from 'styled-components';
import { Link } from 'react-router-dom';

export const Container = styled.div`
    min-height: 692px;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    top: 0;
    z-index: 0;
    overflow: hidden;
    background: linear-gradient(108deg, rgba(1, 147, 86, 1) 0%, rgba(10, 201, 122, 1) 100%);
`;

export const FormWrap = styled.div`
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
`;

export const Icon = styled(Link)`
    margin-left: 32px;
    margin-top: 32px;
    text-decoration: none;
    color: #fff;
    font-weight: 700;
    font-size 32px;
    width: 50px;

    &:hover {
        text-decoration: none;
        color: #000;
    }
`;

export const FormContent = styled.div`
    height: 100%;
    display: flex;
    flex-direction: column:
    justify-content: center;

`;

export const Form = styled.form`
    background: #010101;
    max-width: 600px;
    height: auto;
    width: 100%;
    z-index: 1;
    display: grid;
    margin: 100px auto;
    padding: 80px 32px;
    border-radius: 50px;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.9);

`;

export const FormH1 = styled.h1`
    margin-bottom: 40px;
    color: #fff;
    font-size: 30px;
    font-weight: 400;
    text-align: center;
`;

export const FormLabel = styled.label`
    margin-bottom: 8px;
    font-size: 25px;
    text-align: center;
    color: #fff;
`;

export const FormInput = styled.input`
    padding: 0px 16px;
    margin-bottom: 32px;
    border: none;
    border-radius: 4px;
    font-size: 20px;
    text-align: center;
`;

export const FormButton = styled.button`
    display: flex;
    justify-content: center;
    align-items: center;
    background: #01bf71;
    border: none;
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

