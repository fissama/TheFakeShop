import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "jquery/dist/jquery.min.js";
import "popper.js/dist/umd/popper.min.js";
import $ from "jquery";
import "./App.css";
import Home from "./pages/home";


function App() {
  React.useEffect(() => {
    $("#menu-toggle").click(function (e) {
      e.preventDefault();
      $("#wrapper").toggleClass("toggled");
    });
  }, []);

  return (
    <div>
      <Home />
    </div>
  );
}

export default App;
