
import { useEffect, useState, map } from "react";
import { Button, ButtonGroup, Col, Container, Form, Row } from "react-bootstrap";
import axios from "axios";
import "./Login.css";
import { Route } from "react-router-dom";
//import {redirect} from "react-router";

export default function Login() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [redirect, setRedirect] = useState(false);
   
    function loginData(e) {

        const postData = {
            email,
            password,
        };

        axios.post('https://localhost:7056/api/login', postData).then((response) => {
            alert("User loged in successfully!");
        }).catch(error => {
            console.log(error.message)
        });

        if(redirect){
            return <Route push to="/admin/dashboard" />
          }
    }

    return (
        <div className="bg-white admin-auth">
            <Container>
            
                <Row className="justify-content-center">
                    <Col xl={5}>
                        <Form onSubmit={loginData}>
                            <h4 className="text-center mb-4">Sign In</h4>
                            <Form.Group className="mb-3" controlId="formBasicEmail">
                                <Form.Label>Username or E-Mail</Form.Label>
                                <Form.Control type="email" onChange={e => setEmail(e.target.value)}/>
                            </Form.Group>

                            <Form.Group className="mb-3" controlId="formBasicPassword">
                                <Form.Label>Password</Form.Label>
                                <Form.Control type="password" placeholder="" onChange={e => setPassword(e.target.value)} />
                            </Form.Group>
                            <Form.Group className="mb-3" controlId="formBasicCheckbox">
                                <Form.Check type="checkbox" label="Remember Me" />
                            </Form.Group>
                            <Button type="submit" className="main-btn">
                                Login
                            </Button>
                        </Form>
                    </Col>
                </Row>

            </Container>
        </div>
    );
}