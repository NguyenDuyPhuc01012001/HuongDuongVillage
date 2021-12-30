import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
//import '../../../node_modules/font-awesome/css/font-awesome.min.css'; 

import "../../pages/home.css"
import "../main.css"
import Img_ser1 from "./../../assests/service_restaurant.jpg"
import Img_ser2 from "./../../assests/service_spa.jpg"
import Img_ser3 from "./../../assests/service_fitness.jpg"
import Img_ser4 from "./../../assests/service_tennis.jpg"
import Img_ser5 from "./../../assests/service_pool.jpg"
import Img_ser6 from "./../../assests/service_laundry.jpg"

class Services extends Component {
    render() {
        return (
            <Fragment>
                <section class="service">
                    <div class="container">
                        <h5 class="section-head">
                            <span class="heading">Explore</span>
                            <span class="sub-heading">Our special services</span>
                        </h5>
                        <div class="grid">
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser1} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Restaurant</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>

                            </div>
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser2} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Spa</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>


                            </div>
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser3} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Fitness</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>


                            </div>
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser4} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Golf & Tennis</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>


                            </div>
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser5} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Pool</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>


                            </div>
                            <div class="grid-item featured-hotels">
                                <img src={Img_ser6} alt="" class="hotel-image"></img>
                                <h5 class="hotel-name">Laundry</h5>
                                <div class="hotel-rating">
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star rating"></i>
                                    <i class="fas fa-star-half rating"></i>
                                </div>

                            </div>
                        </div>
                    </div>
                </section>
            </Fragment>
        );
    }
}

export default Services
