import React from "react";
import ListCategory from "./components/Category/ListCategory";
import { Route, BrowserRouter, Switch } from "react-router-dom";
import { LIST_CATEGORY } from "./constants/page";
import "bootstrap/dist/css/bootstrap.min.css";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route to={LIST_CATEGORY}>
          <ListCategory />
        </Route>
      </Switch>
    </BrowserRouter>
  );
}

export default App;
