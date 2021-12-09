import React, { useState } from 'react';
import axios from 'axios';
import { Redirect } from 'react-router'
import { Container, FormWrap, Icon, FormContent, Form, FormH1, FormLabel, FormInput, FormButton } from '../SignIn/SignInElements';

const SignUp = () => {
    let [success, setSuccess] = useState(false);
    const [userData, setUserData] = useState({ UserName: "", Password: "" });

    const registration = (e) => {
        e.preventDefault();
        axios.post("/api/user", userData);
        setSuccess(true);
    }

    const onChange = (e) => {
        e.persist();
        setUserData({ ...userData, [e.target.name]: e.target.value });
    }

    if (success) return <Redirect to="/signin" />;


    return (
        <>
            <Container>
                <FormWrap>
                    <Icon to="/">KonicaMinolta</Icon>
                    <FormContent>
                        <Form onSubmit={registration}>
                            <FormH1>Create account</FormH1>
                            <FormLabel htmlFor='for'>Name:</FormLabel>
                            <FormInput type='text' name="UserName" onChange={onChange} value={userData.UserName} placeholder='User Name' required />
                            <FormLabel htmlFor='for'>Password:</FormLabel>
                            <FormInput type='password' name="Password" onChange={onChange} value={userData.Password} placeholder='Password' required />
                            <FormButton type='submit'>Continue</FormButton>
                        </Form>
                    </FormContent>
                </FormWrap>
            </Container>
        </>
    );
}

export default SignUp;