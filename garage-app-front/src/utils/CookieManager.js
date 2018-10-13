export const getCookie = name => {
    let cookieArray = document.cookie.split(";");
    for (let i = 0; i < cookieArray.length; i++) {
        let cookie = cookieArray[i].trim();
        if (cookie.indexOf(name) !== -1) {
            return cookie.split("=")[1];
        }
    }
    return false;
};
/*
export const cookieExists = name => {
    let cookieArray = document.cookie.split(";");
    for (let i = 0; i < cookieArray.length; i++) {
        let cookie = cookieArray[i].trim();
        if (cookie.indexOf(name) !== -1) {
            return true;
        }
    }
    return false;
};
*/
export const setSessionCookie = (name, value) => {
    document.cookie = name + "=" + value;
};