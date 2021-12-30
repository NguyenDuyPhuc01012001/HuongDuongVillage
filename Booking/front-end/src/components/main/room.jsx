import React from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import "../../pages/home.css"
import "../main.css"
import "../main/room.css"
import Img_room1 from "./../../assests/room_1.jpg"
import Img_room2 from "./../../assests/room_2.jpg"
import Img_room3 from "./../../assests/room_3.jpg"
import Img_room4 from "./../../assests/room_4.jpg"
import Img_room5 from "./../../assests/room_5.jpg"
import Img_room6 from "./../../assests/room_6.jpg"
import axios from 'axios'
import { useEffect } from 'react';
import { useState } from 'react';

function Rooms() {
    const [listRoom, setListRoom] = useState();
    useEffect((() => {
        axios
            .get(`${process.env.REACT_APP_API_URL}/api/v1/roomType/all`)
            .then(
                res => {
                    console.log(res.data);
                    setListRoom(res.data);
                }
            )
    }), [])
    return (
        <Fragment>
            <section class="rooms bg-main-grey">
                <div class="container">
                    <h5 class="section-head">
                        <span class="heading">Luxurious</span>
                        <span class="sub-heading">Affordable</span>
                    </h5>
                    <div class="grid rooms-grid">
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img src={Img_room1} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[0]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[0]["roomPrice"])} <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>

                            </div>
                        </div>
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img src={Img_room2} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[1]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[1]["roomPrice"])} <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>
                            </div>
                        </div>
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img src={Img_room3} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[2]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[2]["roomPrice"])} <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>

                            </div>
                        </div>
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img src={Img_room4} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[3]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[3]["roomPrice"])}  <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>

                            </div>
                        </div>
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img className="room" src={Img_room5} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[4]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[4]["roomPrice"])}  <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>

                            </div>
                        </div>
                        <div class="grid-item featured-rooms">
                            <div class="image-wrap">
                                <img src={Img_room6} alt="" class="room-image"></img>
                                <div class="room-name">{listRoom && listRoom[5]["roomType"]}</div>
                            </div>
                            <div class="room-info-wrap">
                                <span class="room-price">{listRoom && ("$" + listRoom[5]["roomPrice"])}  <span class="per-night">Per night</span></span>
                                <p class="paragraph">
                                    Lorem ipsum dolor sit amet consectetur, adipisicing elit.
                                </p>

                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </Fragment>
    );
}

export default Rooms
