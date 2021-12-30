import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Hero from './main/hero'
import Booking from './main/booking'
import Services from './main/service'
import Offers from './main/offer'
import ExchangeRate from './main/exchangeRate'
import Rooms from './main/room'
import Contact from './main/contact'
import './main.css'
import '../pages/home.css'
import Location from './main/location';

class Main extends Component {
    render() {
        return (
            <Fragment>
                <Hero></Hero>
                <Booking></Booking>
                <Services></Services>
                <Rooms></Rooms>
                <ExchangeRate></ExchangeRate>
                <Contact></Contact>
                <Location></Location>
                <script src="main.js"></script>
            </Fragment>
        );
    }
}

export default Main;