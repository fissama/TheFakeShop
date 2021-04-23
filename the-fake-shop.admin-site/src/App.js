import React from "react";
import ListCategory from "./components/Category/ListCategory";
import { Route, BrowserRouter, Switch } from "react-router-dom";
import { LIST_CATEGORY, MODIFIED_CATEGORY, CREATE_CATEGORY } from "./constants/page";
import "bootstrap/dist/css/bootstrap.min.css";
import CategorySubmitForm from "./components/Category/CategorySubmitForm";

function App() {
  return (
    <BrowserRouter>
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
      </Switch>
    </BrowserRouter>
  );
}

export default App;
