import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import { transitions, positions, types, Provider as AlertProvider } from 'react-alert'
import AlertTemplate from 'react-alert-template-basic'
import App from './App';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

const options = {
    position: positions.MIDDLE,
    types: types.ERROR,
    timeout: 4000,
    transition: transitions.FADE
}

ReactDOM.render(
    <AlertProvider template={AlertTemplate}  {...options}>
        <BrowserRouter basename={baseUrl}>
            <App />
        </BrowserRouter>
    </AlertProvider>,
    rootElement);


