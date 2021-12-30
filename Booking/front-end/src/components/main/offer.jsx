import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Header from "../header"
import "../../pages/home.css"
import "../main.css"

class Offers extends Component {
    render() {
        return (
            <Fragment>
                <Header/>
                <section class="offer">
                    <div class="container">
                        <div class="offer-content">
                            <div class="discount">40% off</div>
                            <h5 class="hotel-name">The Paradise</h5>
                            <div class="hotel-rating">
                                <i class="fas fa-star rating"></i>
                                <i class="fas fa-star rating"></i>
                                <i class="fas fa-star rating"></i>
                                <i class="fas fa-star rating"></i>
                                <i class="fas fa-star-half rating"></i>
                            </div>
                            <p class="paragraph">
                                Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nesciunt veniam sapiente maxime ab at
                                repudiandae ducimus, officiis vitae magni facere ea qui laboriosam sint nobis assumenda,
                                veritatis libero nulla iusto!
                            </p>
                            <a href="/" class="btn btn-gradient">Redeem offer
                                <span class="dots"><i class="fas fa-ellipsis-h"></i></span>
                            </a>
                        </div>
                    </div>
                </section>
            </Fragment>
        );
    }
}

export default Offers
