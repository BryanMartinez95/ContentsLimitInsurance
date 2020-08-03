import React, { Fragment } from 'react';



const Layout = ( props ) => (
    <Fragment>
        <header>HEADER</header>
        <main>
            {props.children}
        </main>
    </Fragment>
);
export default Layout;