import React from "react";
import { Router, Switch, Route, Link } from "react-router-dom";
import {
  LIST_CATEGORY,
  MODIFIED_CATEGORY,
  CREATE_CATEGORY,
  LIST_USER,
  LIST_PRODUCT,
  MODIFIED_PRODUCT,
  CREATE_PRODUCT,
  HOME_PAGE,
} from "../constants/page";
import ListCategory from "./Category/ListCategory";
import ListUser from "./User/ListUser";
import ListProduct from "./Product/ListProduct";
import CategorySubmitForm from "./Category/CategorySubmitForm";
import ProductSubmitForm from "./Product/ProductSubmitForm";
import history from "../helpers/history";
import { IDENTITY_SERVER_URL } from "../constants/connection";
import LoginButton from "../components/LoginButton";

const sidebar = () => {
  return (
    <Router history={history}>
      <div>
        <div className="d-flex" id="wrapper">
          <div className="bg-light border-right" id="sidebar-wrapper">
            <div className="sidebar-heading">TheFakeAdmin </div>
            <div className="list-group list-group-flush">
              <Link
                to={HOME_PAGE}
                className="list-group-item list-group-item-action bg-light"
              >
                Dashboard
              </Link>
              <Link
                to={LIST_USER}
                className="list-group-item list-group-item-action bg-light"
              >
                Users
              </Link>
              <Link
                to={LIST_CATEGORY}
                className="list-group-item list-group-item-action bg-light"
              >
                Categories
              </Link>
              <Link
                to={LIST_PRODUCT}
                className="list-group-item list-group-item-action bg-light"
              >
                Products
              </Link>
              <Link
                to={HOME_PAGE}
                className="list-group-item list-group-item-action bg-light"
              >
                Settings
              </Link>
            </div>
          </div>
          <div id="page-content-wrapper">
            <nav className="navbar navbar-expand-lg navbar-light bg-light border-bottom">
              <button className="btn btn-primary" id="menu-toggle">
                Toggle Menu
              </button>
              <button
                className="navbar-toggler"
                type="button"
                data-toggle="collapse"
                data-target="#navbarSupportedContent"
                aria-controls="navbarSupportedContent"
                aria-expanded="false"
                aria-label="Toggle navigation"
              >
                <span className="navbar-toggler-icon"></span>
              </button>
              <div
                className="collapse navbar-collapse"
                id="navbarSupportedContent"
              >
                <ul className="navbar-nav ml-auto mt-2 mt-lg-0">
                  <li className="nav-item">
                    <Link to={HOME_PAGE}>Welcome, admin!</Link>
                    <LoginButton></LoginButton>
                  </li>
                </ul>
              </div>
            </nav>
            <div>
              {" "}
              <Switch>
                <Route exact path={HOME_PAGE}>
                  <h2>Welcome back, my admin!</h2>
                </Route>
                <Route path={LIST_CATEGORY}>
                  <ListCategory />
                </Route>
                <Route path={MODIFIED_CATEGORY}>
                  <CategorySubmitForm />
                </Route>
                <Route path={CREATE_CATEGORY}>
                  <CategorySubmitForm />
                </Route>
                <Route path={LIST_USER}>
                  <ListUser />
                </Route>
                <Route path={LIST_PRODUCT}>
                  <ListProduct />
                </Route>
                <Route path={MODIFIED_PRODUCT}>
                  <ProductSubmitForm />
                </Route>
                <Route path={CREATE_PRODUCT}>
                  <ProductSubmitForm />
                </Route>
              </Switch>
            </div>
          </div>
        </div>
      </div>
    </Router>
  );
};

export default sidebar;
