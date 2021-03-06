import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import '../../pages/home.css';
import '../main.css';
import '../reponsive.css';
import Img_pic from './../../assests/traveler.png';
import axios from 'axios';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { useState } from 'react';
import { checkValidEmail } from '../validate/validate-email';

toast.configure();
function Contact() {
	const [isSendable, setIsSendable] = useState(false);
	const [name, setName] = useState();
	const [mail, setMail] = useState();
	const [subject, setSubject] = useState();
	const [content, setContent] = useState();
	const handleClick = () => {
		if (!name) {
			setIsSendable(false);
			toast.error('Name must not be empty', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
		}
		if (!checkValidEmail(mail)) {
			setIsSendable(false);
			toast.error('Your email is either empty or in the wrong format', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
		}
	};
	if (isSendable) {
		console.log('Send to database');
		axios
			.post(`${process.env.REACT_APP_API_URL}/api/v1/contact/`, {
				name: name,
				from: mail,
				subject: subject,
				content: content,
			})
			.then(
				toast.success('Email sent, we will contact you as soon as possible', {
					position: 'top-right',
					autoClose: 5000,
					hideProgressBar: false,
					closeOnClick: true,
					pauseOnHover: true,
					draggable: true,
					progress: undefined,
				})
			);
	}
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
						<form class="form contact-form">
							<div class="input-group-wrap">
								<div class="input-group">
									<input
										onChange={(e) => setName(e.target.value)}
										type="text"
										class="input"
										placeholder="Name"
									></input>
									<span class="bar"></span>
								</div>
								<div class="input-group">
									<input
										onChange={(e) => setMail(e.target.value)}
										type="email"
										class="input"
										placeholder="E-mail"
									></input>
									<span class="bar"></span>
								</div>
							</div>
							<div class="input-group">
								<input
									onChange={(e) => setSubject(e.target.value)}
									type="text"
									class="input"
									placeholder="Subject"
								></input>
								<span class="bar"></span>
							</div>
							<div class="input-group">
								<textarea
									onChange={(e) => setContent(e.target.value)}
									class="input"
									cols="30"
									rows="8"
									placeholder="Content"
								></textarea>
								<span class="bar"></span>
							</div>
							<button
								type="button"
								onClick={handleClick}
								class="btn form-btn btn-orange"
							>
								Send message
							</button>
						</form>
					</div>
				</div>
			</section>
		</Fragment>
	);
}
export default Contact;
