import React, { useState } from 'react';
import { useAlert } from 'react-alert';
import { Redirect } from 'react-router';
import axios from 'axios';
import { Container, FormWrap, Icon, FormContent, Form, FormH1, FormLabel, FormInput, FormButton} from './SignInElements'

const SignIn = ({ setUser, setLoggedIn, loggedIn }) => {
    let [userData, setUserData] = useState({ UserName: "", Password: "" });
    const alert = useAlert();

    const login = (e) => {
        e.preventDefault();
        axios.get(`api/login/${userData.UserName}`).then(response => {
            if (response.data === "disabled") alert.show("Your account is disabled");
            else {
                axios.post("/api/user/login", userData).then(Response => {
                    if (Response.data.userName === "wrong") {
                        alert.show("Invalid User Name");
                        return;
                    }
                    if (Response.data === "") {
                        if (response.data === "last") {
                            axios.post("api/login", { LoginName: userData.UserName, EventId: 3 });
                            alert.show("Invalid Password - Account disabled");
                        }
                        else {
                            axios.post("api/login", { LoginName: userData.UserName, EventId: 2 });
                            alert.show("Invalid Password");
                        }
                        return;
                    } else {
                        axios.post("api/login", { LoginName: userData.UserName, EventId: 1 });
                        setUser(Response.data);
                        setLoggedIn(true);
                        return;
                    }
                });
            }
        });
    };

    const onChange = (e) => {
        e.persist();
        setUserData({ ...userData, [e.target.name]: e.target.value });
    };

    if (loggedIn) return <Redirect to="/" />;

    return (
        <>
            <Container>
                <FormWrap>
                    <Icon to="/">KonicaMinolta</Icon>
                    <FormContent>
                        <Form onSubmit={login}>
                            <FormH1>Sign in to your account</FormH1>
                            <FormLabel htmlFor='for'>User Name</FormLabel>
                            <FormInput type='text' name="UserName" value={userData.UserName} placeholder='User Name' required onChange={onChange} />
                            <FormLabel htmlFor='for'>Password</FormLabel>
                            <FormInput type='password' name="Password" value={userData.Password} placeholder='Password' required onChange={onChange} />
                            <FormButton type='submit'>Continue</FormButton>
                        </Form>
                    </FormContent>
                </FormWrap>
            </Container>
        </>
    );
}

export default SignIn;