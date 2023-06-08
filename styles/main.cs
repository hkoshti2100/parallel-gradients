@font-face {
  font-family: "Oxanium";
  src: url("../resources/fonts/oxanium/Oxanium-Regular.eot");
  src: url("../resources/fonts/oxanium/Oxanium-Regular.eot?#iefix") format("embedded-opentype"), url("../resources/fonts/oxanium/Oxanium-Regular.woff2") format("woff2"), url("../resources/fonts/oxanium/Oxanium-Regular.woff") format("woff"), url("../resources/fonts/oxanium/Oxanium-Regular.ttf") format("truetype"), url("../resources/fonts/oxanium/Oxanium-Regular.svg#Oxanium-Regular") format("svg");
  font-weight: normal;
  font-style: normal;
  font-display: swap;
}
:root {
  --color-light: white;
  --color-dark: black;
  --font-primary: "Oxanium";
}

*, *::before, *::after {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

header a {
  text-decoration: none;
  color: var(--color-dark);
  font-family: var(--font-primary);
  font-weight: 600;
  text-transform: uppercase;
  letter-spacing: 1px;
}

.container-main {
  width: min(1440px, 85%);
}

header form > * {
  background-color: transparent;
  border: 0;
}

header {
  --gap-logo: 5px;
  --height-icon: 20px;
  --height-logo: 50px;
  --height-logo-small: calc(var(--height-logo) * 0.75);
  --padding-header: 20px;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: var(--padding-header) 0;
}
header > * {
  flex: 1 1 0;
}
header > #logo {
  display: flex;
  justify-content: flex-start;
  align-items: center;
  gap: var(--gap-logo);
}
header > #logo > svg {
  height: var(--height-logo);
}
header > #logo > svg + svg {
  height: var(--height-logo-small);
}
header > nav {
  display: flex;
  justify-content: space-evenly;
  align-items: center;
}
header > #search {
  display: flex;
  justify-content: flex-end;
  align-items: center;
}
header > #search > .share {
  margin-right: var(--height-icon);
  padding-right: var(--height-icon);
  border-right: 1px solid var(--color-dark);
}
header form {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: var(--height-icon);
}
header .share svg,
header form button svg {
  height: var(--height-icon);
}
