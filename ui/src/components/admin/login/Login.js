
import { useEffect, useState, map } from "react";
import { Button, ButtonGroup, Col, Container, Form, Row } from "react-bootstrap";
import axios from "axios";
import "./Login.css";
import { Route, Routers, Redirect } from "react-router-dom";
import {Navigate} from "react-router-dom";

export default function Login() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [navigate, setNavigate] = useState(false);
   
    const data = {
        email,
        password
    }
    const loginData = async(e) => {
        e.preventDefault();

        const response = await fetch('https://localhost:7056/api/login', {
            method: 'POST',
            headers: { 
              'Accept':'application/json',
              'Content-Type':'application/json'
              },
            credentials: 'include',
            body: JSON.stringify(data)
          });
          const content = await response.json();
          console.log(response)
        const txt = "Invalid credentials";
        if(content === txt){
            alert(content);
            setNavigate(false);
          }
          else{
            setNavigate(true);
          }
    }

    if(navigate){
        return '<h1>test</h1>'
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