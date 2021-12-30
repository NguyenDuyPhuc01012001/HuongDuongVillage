import React, { Component } from "react";
import "./App.css";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect,
} from "react-router-dom";
const Contact = React.lazy(() => import("./components/main/contact"));
const Home = React.lazy(() => import("./pages/home.jsx"));
const Offer = React.lazy(() => import("../src/components/main/offer"));

class App extends Component {
  render() {
    return (
      <Router>
        <Switch>
          <React.Suspense fallback={<div>Loading....</div>}>
            <Route exact path="/home" component={Home} />
            <Route exact path="/">
              <Redirect to="/home" />
            </Route>
          </React.Suspense>
        </Switch>
      </Router>
    );
  }
}

export default App;
