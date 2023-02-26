import { Navbar, Container, Nav, Col } from "react-bootstrap";
import { useEffect, useState } from "react";
import axios from "axios";
import { BoxArrowInRight } from "react-bootstrap-icons";
import { Link } from "react-router-dom";
import logo from '../../logo_transparent.png';


function NavElements() {
    const [navList, setNavList] = useState([]);

    const getData = () => {
        axios.get('https://localhost:7056/api/Navigation')
            .then((res) => {
                setNavList(res.data);
            }).catch((error) => console.log('error', error))
    }
    useEffect(() => {
        getData()
    }, []);
    return (
        <Navbar bg="transparent" expand="lg">
            <Container>
                <div className="navbar-brand">
                    <Link to="/"><img src={logo} alt="Journery Platform" /></Link>
                </div>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="ms-auto">
                        {navList.map(item => {
                            return (
                                <Link to={item.link} className="nav-link" key={item.id}>{item.title}</Link>
                            );
                        })}
                    </Nav>
                </Navbar.Collapse>
            </Container>
        </Navbar>
    );
}
export default NavElements;