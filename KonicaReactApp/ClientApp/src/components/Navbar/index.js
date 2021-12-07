import React from 'react';
import { Nav, NavbarContainer, NavLogo, NavMenu, NavLinks, NavBtn, NavBtnLink } from './NavbarElements';



const Navbar = () => {

    return (
        <Nav>
            <NavbarContainer>
                <NavLogo to='/'>KonicaMinolta</NavLogo>
                <NavMenu>
                    <NavLinks to="/documents">Documents</NavLinks>
                </NavMenu>
                <NavBtn>
                    <NavBtnLink to="/signup">Sign Up</NavBtnLink>
                    <NavBtnLink to="/signin">Sign In</NavBtnLink>
                </NavBtn>
            </NavbarContainer>
        </Nav>
    );
}

export default Navbar;