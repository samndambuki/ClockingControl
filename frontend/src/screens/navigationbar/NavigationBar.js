import React from 'react'
import Navbar from 'react-bootstrap/Navbar'
import Nav from 'react-bootstrap/Nav'
import { navigationlinks } from '../../helpers/navigationlinks'
import './navigation.css'


function createLinks(){
 return navigationlinks.map((e,idx)=>(
  <Nav.Link key={idx} href={e.ref}>{e.name}</Nav.Link>
 ))
}

function NavigationBar() {
  return (
    <div id="home">
    <Navbar className='navigation_container'
    style={{zIndex:'2',position:'fixed',top:'0',width:'100%'}}
    collapseOnSelect
     expand="md">
     <Navbar.Brand style={{marginLeft:'1rem'}} href="#home">CLOCKING CONTROL</Navbar.Brand>
     <Navbar.Toggle aria-controls="basic-navbar-nav" />
    
     <Navbar.Collapse style={{justifyContent:'flex-end',marginRight:"1rem",borderColor:"none"}}>
       <Nav className='links' style={{margin:"0 1rem"}}>
       {createLinks()}
     </Nav>
     </Navbar.Collapse>
    </Navbar>
    </div>
  )
}

export default NavigationBar