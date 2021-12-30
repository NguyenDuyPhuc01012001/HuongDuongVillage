import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import '../../pages/home.css';
import '../main.css';
import '../reponsive.css';
import Img_pic from './../../assests/traveler.png';
class Contact extends Component {
	render() {
		return (
			<Fragment>
				<section class="contact">
					<div class="container">
						<h5 class="section-head">
							<span class="heading">Contact</span>
							<span class="sub-heading">Get in touch with us</span>
						</h5>
						<div class="contact-content">
							<div class="traveler-wrap">
								<img src={Img_pic} alt=""></img>
							</div>
							<form action="" class="form contact-form">
								<div class="input-group-wrap">
									<div class="input-group">
										<input
											type="text"
											class="input"
											placeholder="Name"
											required
										></input>
										<span class="bar"></span>
									</div>
									<div class="input-group">
										<input
											type="email"
											class="input"
											placeholder="E-mail"
											required
										></input>
										<span class="bar"></span>
									</div>
								</div>
								<div class="input-group">
									<input
										type="text"
										class="input"
										placeholder="Subject"
									></input>
									<span class="bar"></span>
								</div>
								<div class="input-group">
									<textarea
										class="input"
										cols="30"
										rows="8"
										placeholder="Content"
									></textarea>
									<span class="bar"></span>
								</div>
								<button type="submit" class="btn form-btn btn-orange">
									Send message
								</button>
							</form>
						</div>
					</div>
				</section>
			</Fragment>
		);
	}
}

export default Contact;
