import React from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import '../../pages/home.css';
import '../main.css';
import '../reponsive.css';
import axios from 'axios';
import validateCheckIn from '../validate/validate-checkin';
import { useEffect } from 'react';
import { useState } from 'react';
import validateCheckOut from '../validate/validate-checkout';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import validateID from '../validate/validate-id';
import validateName from '../validate/validate-name';
import validatePhone from '../validate/validate-phone';

toast.configure();

function Booking() {
	var error = '';
	const [rooms, setRooms] = useState([]);
	const [roomIndex, setRoomIndex] = useState(0);
	const [roomPrice, setRoomPrice] = useState();
	const [roomTypeID, setRoomTypeID] = useState();
	const [dateCheckIn, setDateCheckIn] = useState();
	const [dateCheckOut, setDateCheckOut] = useState();
	const [roomTypeCount, setRoomTypeCount] = useState(0);
	const [cusName, setCusName] = useState();
	const [phone, setPhone] = useState();
	const [idCard, setIDCard] = useState();
	var errorCount = 0;
	const handleBooking = () => {
		if (roomTypeCount === 0) {
			toast.error('There is no room available, comeback at later time', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
			return;
		}
		if (!validateCheckIn(dateCheckIn)) {
			toast.error('Date check-in must be greater than today\r\n', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
			errorCount++;
		}
		var errorCode = validateCheckOut(dateCheckIn, dateCheckOut);
		switch (errorCode) {
			case 1:
				toast.error(
					'The checkout date cannot be more than 30 days before the check-in date\r\n',
					{
						position: 'top-right',
						autoClose: 5000,
						hideProgressBar: false,
						closeOnClick: true,
						pauseOnHover: true,
						draggable: true,
						progress: undefined,
					}
				);
				errorCount++;

				break;
			case 2:
				toast.error('Checkout date must not be less than Check-in date\r\n', {
					position: 'top-right',
					autoClose: 5000,
					hideProgressBar: false,
					closeOnClick: true,
					pauseOnHover: true,
					draggable: true,
					progress: undefined,
				});
				errorCount++;

				break;
			case 3:
				toast.error('Checkout date must be greater than today\r\n', {
					position: 'top-right',
					autoClose: 5000,
					hideProgressBar: false,
					closeOnClick: true,
					pauseOnHover: true,
					draggable: true,
					progress: undefined,
				});
				errorCount++;

				break;
			case 4:
				toast.error('Checkout date must not be empty\r\n', {
					position: 'top-right',
					autoClose: 5000,
					hideProgressBar: false,
					closeOnClick: true,
					pauseOnHover: true,
					draggable: true,
					progress: undefined,
				});
				errorCount++;
				break;
			default:
		}
		if (!validateID(idCard)) {
			toast.error(
				'ID Card must be 9 or 12 length and contains number only\r\n',
				{
					position: 'top-right',
					autoClose: 5000,
					hideProgressBar: false,
					closeOnClick: true,
					pauseOnHover: true,
					draggable: true,
					progress: undefined,
				}
			);
			errorCount++;
		}
		if (!validateName(cusName)) {
			toast.error('Name must not be empty\r\n', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
			errorCount++;
		}
		if (!validatePhone(phone)) {
			toast.error('Phone must be number-only and contains 10 character\r\n', {
				position: 'top-right',
				autoClose: 5000,
				hideProgressBar: false,
				closeOnClick: true,
				pauseOnHover: true,
				draggable: true,
				progress: undefined,
			});
			errorCount++;
		}

		if (errorCount > 0) {
			return;
		}

		axios
			.post(`${process.env.REACT_APP_API_URL}/api/v1/customer/`, {
				cusName: cusName,
				cusIDcard: idCard,
				cusPhone: phone,
			})
			.then(
				axios
					.get(`${process.env.REACT_APP_API_URL}/api/v1/customer/${idCard}`)
					.then((resultCustomer) =>
						axios
							.get(`${process.env.REACT_APP_API_URL}/api/v1/room/${roomTypeID}`)
							.then((resultRoom) =>
								axios
									.post(`${process.env.REACT_APP_API_URL}/api/v1/book`, {
										cusID: resultCustomer.data.id,
										roomID: resultRoom.data.id,
										dateCheckIn: dateCheckIn,
										dateCheckOut: dateCheckOut,
									})
									.then(toast('Book successfully'))
							)
					)
			);
	};
	useEffect(() => {
		axios
			.get(`${process.env.REACT_APP_API_URL}/api/v1/roomType/available`)
			.then((res) => {
				console.log(res.data);
				setRooms(res.data);
				setRoomTypeCount(res.data.length);
				if (roomTypeCount === 0) {
					return;
				}
				setRoomPrice(res.data[0].roomPrice);
				setRoomTypeID(res.data[0].id);
			})
			.catch(console.log('Error getting data'));
	}, []);
	return (
		<Fragment>
			<section class="booking">
				<div class="container flex-column">
					<form action="" class="form">
						<div class="input input-group">
							<label for="name" class="input-label">
								Name
							</label>
							<input
								onChange={(e) => setCusName(e.target.value)}
								type="text"
								class="input"
								id="name"
								required
							></input>
						</div>
						<div class="input input-group">
							<label for="phone" class="input-label">
								Telephone
							</label>
							<input
								onChange={(e) => setPhone(e.target.value)}
								type="text"
								class="input"
								id="phone"
								required
							></input>
						</div>
						<div class="input input-group">
							<label for="check-out" class="input-label">
								ID card
							</label>
							<input
								onChange={(e) => setIDCard(e.target.value)}
								type="text"
								class="input"
								id="check-out"
								required
							></input>
						</div>
					</form>
					<form action="" class="form">
						<div class="input input-group w-25">
							<label for="check-in" class="input-label">
								Check in
							</label>
							<input
								onChange={(e) => (
									setDateCheckIn(e.target.value),
									console.log(validateCheckIn(e.target.value))
								)}
								type="date"
								class="input"
								id="check-in"
							></input>
						</div>
						<div class="input input-group w-25">
							<label for="check-out" class="input-label">
								Check out
							</label>
							<input
								onChange={(e) => (
									setDateCheckOut(e.target.value),
									console.log(validateCheckOut(dateCheckIn, e.target.value))
								)}
								type="date"
								class="input"
								id="check-out"
							></input>
						</div>

						<div class="input input-group w-25">
							<label for="room" class="input-label">
								Room Type
							</label>
							<select
								onChange={(e) => {
									setRoomIndex(e.target.value);
									setRoomPrice(rooms[e.target.value].roomPrice);
									setRoomTypeID(rooms[e.target.value].id);
								}}
								name=""
								id="room"
								class="options"
							>
								{rooms.map((value, index) => {
									return (
										<option value={index} key={value.id}>
											{value.roomType}
										</option>
									);
								})}
							</select>
						</div>
						<div class="input input-group w-25">
							<label for="nor" class="input-label">
								Price
							</label>
							<div className="options price-show">{roomPrice}</div>
						</div>
					</form>
					<button
						onClick={handleBooking}
						class="btn form-btn btn-orange booking-btn"
					>
						Booking
					</button>
				</div>
			</section>
		</Fragment>
	);
}

export default Booking;
