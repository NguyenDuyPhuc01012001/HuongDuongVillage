import React, {Component} from 'react';
import { Fragment } from 'react/cjs/react.production.min';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Header from '../components/header'
import Footer from '../components/footer'
import './home.css'
const Main = React.lazy(() => import('../components/main.jsx'));

class Home extends Component {
    render() {
        return (
            <Fragment>                
                <Header></Header>
                <Router>
                    <Switch>
                        <Route exact path="/home" component={Main}/>
                    </Switch>
                </Router>

                <Footer></Footer>
            </Fragment>
          );
    }
}

export default Home;
