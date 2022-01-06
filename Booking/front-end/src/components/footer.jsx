import React, { Component } from "react";
import { Fragment } from "react/cjs/react.production.min";
import "./footer.css";
import { Link } from "react-router-dom";

class Footer extends Component {
  render() {
    return (
      <Fragment>
        <div className="footer">
          <div className="footer-title">Visit our social media</div>
          <div className="social-container">
            <a href="#" class="sm-link"><i class="fab fa-twitter"></i></a>
            <a href="#" class="sm-link"><i class="fab fa-facebook-square"></i></a>
            <a href="#" class="sm-link"><i class="fab fa-instagram"></i></a>
            <a href="#" class="sm-link"><i class="fab fa-pinterest"></i></a>
          </div>

        </div>
      </Fragment >
    );
  }
}
export default Footer;
