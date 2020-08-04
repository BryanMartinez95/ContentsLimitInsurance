import React, { Fragment } from "react";

const Layout = (props) => (
  <Fragment>
    <section className="hero is-small is-dark">
      <div className="hero-body">
        <div className="container">
          <h1 className="title">Contents Limit Insurance App</h1>
        </div>
      </div>
    </section>
    <main className="section">
      <div className="container">{props.children}</div>
    </main>
  </Fragment>
);
export default Layout;
