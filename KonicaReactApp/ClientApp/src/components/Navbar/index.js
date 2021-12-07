import React from 'react';
import { Nav, NavbarContainer, NavLogo, NavMenu, NavLinks, NavBtn, NavBtnLink, UserContainer, NavUser } from './NavbarElements';



const Navbar = ({ user, loggedIn }) => {
    if (loggedIn) console.log(user);
    return (
        <Nav>
            <NavbarContainer>
                <NavLogo to='/'>KonicaMinolta</NavLogo>
                <NavMenu>
                    {loggedIn ? <NavLinks to="/documents">Documents</NavLinks>: null}
                </NavMenu>
                {!loggedIn ?
                    <NavBtn>
                        <NavBtnLink to="/signup">Sign Up</NavBtnLink>
                        <NavBtnLink to="/signin">Sign In</NavBtnLink>
                    </NavBtn> :
                    <NavBtn>
                        <NavBtnLink to="logout">Logout</NavBtnLink>
                    </NavBtn>}
            </NavbarContainer>
        </Nav>
    );
}

export default Navbar;