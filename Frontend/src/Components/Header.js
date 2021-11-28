import * as React from 'react';
import { Navbar, Container, Nav } from 'react-bootstrap';
import { Link } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
import './Header.css'

export default function Header() {
  return (
    <>
      <div className="header">
        <Navbar bg="light" expand="lg">
          <Container>
            <Navbar.Brand>Teste</Navbar.Brand>
            <Navbar.Toggle aria-controls="basic-navbar-nav" />
            <Navbar.Collapse id="basic-navbar-nav">
              <Nav className="mr-auto">
                <Nav.Link>
                  <Link to="/">Home</Link>
                </Nav.Link>
                <Nav.Link>
                  <Link to="/criar">Criar</Link>
                </Nav.Link>
                <Nav.Link>
                  <Link to="/editar">Editar</Link>
                </Nav.Link>
              </Nav>
            </Navbar.Collapse>
          </Container>
        </Navbar>
      </div>
    </>
  )
}