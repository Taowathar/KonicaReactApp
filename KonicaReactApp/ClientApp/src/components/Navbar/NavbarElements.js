import styled from 'styled-components'
import { Link  } from 'react-router-dom'

export const Nav = styled.nav`
    background: black;
    height: 80px;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 1rem;
    position: sticky;
    top: 0;
    z-index: 10;
`;

export const NavbarContainer = styled.div`
    display:flex;
    justify-content: space-between;
    height: 80px;
    z-index: 1;
    width: 100%;
    padding: 0 24px;
`;

export const NavLogo = styled(Link)`
    color: #01bf71;
    justify-self: flex-start;
    cursor: pointer;
    font-size: 1.5rem;
    display: flex;
    align-items: center;
    margin-left: 24px;
    font-weight: bold;
    text-decoration: none;

    &:hover {
        text-decoration: none;
        color: cadetblue;
    }
`;

export const NavMenu = styled.div`
    display: flex;
    align-items: center;
    margin-right: -22px;
`;

export const NavLinks = styled(Link)`
    color: #fff;
    font-size: 20px;
    display: flex;
    align-items: center;
    text-decoration: none;
    padding: 0 1rem;
    height: 100%;
    cursor: pointer;

    &:hover {
        color: #01bf71;
        text-decoration: none;
    }
`;

export const NavBtn = styled.nav`
    display: flex;
    align-items: center;
`;

export const NavBtnLink = styled(Link)`
    border-radius: 50px;
    background: #01bf71;
    white-space: nowrap;
    margin: 0 10px;
    padding: 10px 22px;
    color: #010606;
    font-size: 16px;
    outline: none;
    border: none;
    cursor: pointer;
    transition: all 0.2s ease-in-out;
    text-decoration: none;

    &:hover {
        transition: all 0.2s ease-in-out;
        background: cadetblue;
        color: #010606;
        text-decoration: none;
    }
`;

export const UserContainer = styled.div`
    margin-top: 18px;
`;

export const NavUser = styled.p`
    color: #01bf71;
    font-size: 20px;
    font-weight: 700;
    margin-right: 20px;

`