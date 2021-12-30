import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import "../../pages/home.css"
import "../main.css"

class Hero extends Component {
    render() {
        return (
            <Fragment>
                <section class="hero">
                    <div class="container">
                        <div class="main-heading">
                            <h1 class="title">Discover</h1>
                            <h2 class="subtitle">Luxury resort</h2>
                        </div>
                    </div>
                </section>
            </Fragment>
        );
    }
}

export default Hero
