import React from 'react';
import { Container, FormWrap, Icon, FormContent, Form, FormH1, FormLabel, FormInput, FormButton } from '../SignIn/SignInElements';

const SignUp = () => {

    return (
        <>
            <Container>
                <FormWrap>
                    <Icon to="/">KonicaMinolta</Icon>
                    <FormContent>
                        <Form>
                            <FormH1>Create account</FormH1>
                            <FormLabel htmlFor='for'>Name:</FormLabel>
                            <FormInput type='text' name="UserName" placeholder='User Name' required />
                            <FormLabel htmlFor='for'>Password:</FormLabel>
                            <FormInput type='password' name="Password" placeholder='Password' required />
                            <FormButton type='submit'>Continue</FormButton>
                        </Form>
                    </FormContent>
                </FormWrap>
            </Container>
        </>
    );
}

export default SignUp;