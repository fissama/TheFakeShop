import React from "react";
import ListCategory from "./pages/Category/ListCategory";
import ListUser from './pages/User/ListUser';
import ListProduct from './pages/Product/ListProduct';
import { Route, Router, Switch } from "react-router-dom";
import { LIST_CATEGORY, MODIFIED_CATEGORY, CREATE_CATEGORY, LIST_USER, LIST_PRODUCT } from "./constants/page";
import "bootstrap/dist/css/bootstrap.min.css";
import CategorySubmitForm from "./pages/Category/CategorySubmitForm";
import history from './helpers/history';

function App() {
  return (
    <Router history={history}>
      <Switch>
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
      </Switch>
    </Router>
  );
}

export default App;
