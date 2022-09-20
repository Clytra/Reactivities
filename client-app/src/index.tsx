import React from "react";
import ReactDOM from "react-dom/client";
import "./app/layout/styles.css";
import App from "./app/layout/App";
import reportWebVitals from "./reportWebVitals";
import { store, StoreContext } from "./app/stores/store";
import { Router } from "react-router-dom";
import "react-calendar/dist/Calendar.css";
import "react-toastify/dist/ReacyToastify.min.css";
import { createBrowserHistory } from "history";

export const history = createBrowserHistory();

ReactDOM.createRoot(document.getElementById("root")!).render(
  <StoreContext.Provider value={store}>
    <Router location={history.location} navigator={history}>
      <App />
    </Router>
  </StoreContext.Provider>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
