import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import "bootstrap-icons/font/bootstrap-icons.css";
import "../../pages/home.css"
import "../main.css"
import "./location.css"
class Location extends Component {
    render() {
        return (
            <Fragment>
                <div className="main-container">
                    <div className="self-center f-40 m-top-20 weight-700">LOCATION</div>
                    <div className="self-center f-17 f-courgette weight-100">Discover the place you will never forget</div>

                    <div class="location-container m-top-20">
                        <div className="m-left w-80">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3728.7956600776415!2d106.69807471485112!3d20.83995638610095!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x314a7aa26521f117%3A0x78a91f039dde2754!2zTMOgbmcgUXXhu5FjIHThur8gSMaw4bubbmcgRMawxqFuZw!5e0!3m2!1svi!2s!4v1637811037490!5m2!1svi!2s" className="map" allowfullscreen="" loading="lazy"></iframe>
                        </div>

                        <div class="location-heading w-half">
                            <div className="third-color f-26 weight-300">Hướng Dương Village</div>
                            <div className="vertical-middle m-top-8 flex-row">
                                <div className="bi bi-geo-alt-fill">
                                </div>
                                <div className="m-left-5 m-right-5 weight-300">35A Van Cao Street, Nga Nam urban area - Cat Bi Airport, Haiphong City, Vietnam</div>
                            </div>
                            <div className="m-top-8">
                                <a
                                    href="https://www.google.com/maps?ll=20.839956,106.700263&z=16&t=m&hl=vi&gl=US&mapclient=embed&cid=8694514656009398100"
                                    target="_blank"
                                    className="location-open third-color" rel="noreferrer"
                                >See on map</a>
                            </div>
                        </div>
                    </div>
                </div>


            </Fragment>
        );
    }
}

export default Location
