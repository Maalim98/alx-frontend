/* ================== variables for colors =====================*/
:root {
    --color-primary: #d73953;
    --color-black : #090909;
    --color-white : #ffffff;
    --color-light-grey: #f3f3f3;
    --color-dark-grey: #353535;
    --text-color: var(--color-black);

/* ================== variables for font family =====================*/
    --font-family-base: "Open Sans", "Helvetica Neue", Helvetica, Arial, sans-serif;
    --font-family-title: "Raleway", "Helvetica Neue", Helvetica, Arial, sans-serif;

/* ============== variables for fonts sizes =================*/
    --font-size-small: 1.2rem;
    --font-size-medium: 1.6rem;
    --font-size-large: 1.8rem;
    --font-size-x-large: 2.3rem;
    --font-size-xx-large: 4.8rem;

/* ================ variables for font-weight ======================= */
    --font-weight-regular: 400;
    --font-weight-bold: 700;
}

html {
    scroll-behavior: smooth;
    font-size: 62.5%;
}


body {
    background-color: var(--text-color); 
    font-family: var(--font-family-base);
    font-size: var(--font-size-medium);
    font-weight: var(--font-weight-regular);
}

h1, h2, h3, h4, h5, h6 {
    font-family: var(--font-family-title);
    font-weight: var(--font-weight-bold);
}

a {
    background-color: var(--text-color);
}

.visually-hidden {
    display: none;
}

.card-category {
    background-color: var(--color-primary);
}

.section-tagline {
    background-color: var(--color-primary);
}