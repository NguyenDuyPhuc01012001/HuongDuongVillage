import React, { Component } from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BiRightArrowAlt } from 'react-icons/fa';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import "../../pages/home.css"
import "../main.css"

class ExchangeRate extends Component {
    render() {
        return (
            <Fragment>
                <section class="exchangeRate">
                    <div class="container">
                        <h5 class="section-head">
                            <span class="heading">Exchange Rate Table</span>
                        </h5>
                        <iframe frameborder="0" width="100%" height="700px" src="https://webtygia.com/api/tygia?bgheader=d44912&colorheader=ffffff&padding=5&fontsize=13&hienthi=VietinBank,BIDV,Vietcombank&"></iframe>
                    </div>
                </section>
            </Fragment>
        );
    }
}

export default ExchangeRate
