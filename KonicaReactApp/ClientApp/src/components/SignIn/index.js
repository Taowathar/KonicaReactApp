import React from 'react';

import { Container, FormWrap, Icon, FormContent, Form, FormH1, FormLabel, FormInput, FormButton} from './SignInElements'

const SignIn = () => {

    return (
        <>
            <Container>
                <FormWrap>
                    <Icon to="/">KonicaMinolta</Icon>
                    <FormContent>
                        <Form>
                            <FormH1>Sign in to your account</FormH1>
                            <FormLabel htmlFor='for'>User Name</FormLabel>
                            <FormInput type='text' placeholder='User Name' required />
                            <FormLabel htmlFor='for'>Password</FormLabel>
                            <FormInput type='password' placeholder='Password' required/>
                            <FormButton type='submit'>Continue</FormButton>
                        </Form>
                    </FormContent>
                </FormWrap>
            </Container>
        </>
    );
}

export default SignIn;