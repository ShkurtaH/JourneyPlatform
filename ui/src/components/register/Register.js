import { Button, ButtonGroup, Col, Container, Form, Row } from "react-bootstrap";
import axios from "axios";
import "./Register.css";
import Header from "../layout/Header";
import Footer from "../layout/Footer";
import React, { SyntheticEvent, useState } from 'react';
import { applyInitialState } from "@mui/x-data-grid/hooks/features/columns/gridColumnsUtils";

const Register = () => {
    //this is how we handle states in react,name:is variable, setName:is natural function that change name variable.
    const [input, setInput] = useState({});

    const handleChange = (e) => {
        const { name, value } = e.target;
        setInput({ ...input, [name]: value });
      };


    const submit = (e) => {
        e.preventDefault()
        axios.post("https://localhost:7056/api/Authenticate/register/",
            {
                ...input
            });
        console.log(input);
    }
    return (
        <div className="bg-white user-register">

            <Header />
            <Container>
                <Row className="justify-content-center">
                    <Col xl={5}>
                        <Form onSubmit={submit}>
                            <Form.Group className="mb-3">
                                <Form.Label>Name</Form.Label>
                                <Form.Control
                                    type="text"
                                    name="name"
                                    placeholder="Name"
                                    required
                                    onChange={handleChange}
                                />
                            </Form.Group>

                            <Form.Group className="mb-3">
                                <Form.Label>Email</Form.Label>
                                <Form.Control
                                    type="text"
                                    name="email"
                                    placeholder="Enter Email"
                                    required
                                    onChange={handleChange}
                                />
                            </Form.Group>

                            <Form.Group className="mb-3">
                                <Form.Label>Password</Form.Label>
                                <Form.Control
                                    type="password"
                                    name="password"
                                    placeholder="Password"
                                    required
                                    onChange={handleChange}
                                />
                            </Form.Group>

                            <Button
                                type="submit"
                                id="loginBtn"
                                className="btn btn-primary btn-block loginBtn"
                            >
                                Register
                            </Button>
                        </Form>
                    </Col>
                </Row>

            </Container>
            <Footer />
        </div>
    );
};

export default Register;