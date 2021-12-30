import React, { Component, useState } from "react";
import { Fragment } from "react/cjs/react.production.min";
import "./header.css";
import { Link } from "react-router-dom";
import Logo from "../assests/logo.png";

class Header extends Component {
    componentDidMount() {
        window.addEventListener('scroll', this.handleScroll);
        window.addEventListener('click', this.handleClick);
    }

    componentWillUnmount() {
        window.removeEventListener('scroll', this.handleScroll);
        window.removeEventListener('click', this.handleClick);
    }
    handleScroll(event) {
        let windowPosition = window.scrollY > 0;
        let header = document.querySelector('.header');
        header.classList.toggle('active', windowPosition);
    }
    render() {
        return (
            <Fragment>
                <div class="header active" onScroll={this.handleClick}>
                    <div class="container">
                        <nav class="nav">
                            <a href="#" class="logo">
                                <img src={Logo} alt=""></img>
                            </a>
                        </nav>
                    </div>
                </div>
            </Fragment>
        );
    }
}

export default Header;
