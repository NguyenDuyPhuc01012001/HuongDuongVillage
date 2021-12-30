import React, { Component } from "react";
import { Fragment } from "react/cjs/react.production.min";
import "./footer.css";
import { Link } from "react-router-dom";

class Footer extends Component {
  render() {
    return (
      <Fragment>
        <div className="footer">
          <div class="container">
            <div class="footer-content">
              <div class="footer-content-brand">
                <a href="index.htm;" class="logo">
                  <img src="./images/logo.png" alt="" class="logo-image"></img>
                </a>
                <div class="paragraph">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint temporibus laborum accusantium odit nobis excepturi libero.</div>
              </div>
              <div class="social-media-wrap">
                <h4 class="footer-heading"></h4>
                <div class="social-media">
                  <a href="#" class="sm-link"><i class="fab fa-twitter"></i></a>
                  <a href="#" class="sm-link"><i class="fab fa-facebook-square"></i></a>
                  <a href="#" class="sm-link"><i class="fab fa-instagram"></i></a>
                  <a href="#" class="sm-link"><i class="fab fa-pinterest"></i></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </Fragment>
    );
  }
}
export default Footer;
