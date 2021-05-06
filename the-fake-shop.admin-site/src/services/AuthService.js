import {UserManager} from 'oidc-client';
import {IDENTITY_SERVER_URL,ADMIN_URL} from '../constants/connection';

const config = {
    authority:  (IDENTITY_SERVER_URL),
    client_id: "admin",
    redirect_uri: (ADMIN_URL)+"Home/SignIn",
    response_type: "id_token token",
    scope:"openid profile thefakeshop.api"
}

const userManager = new UserManager(config);

export function signIn() {
    return userManager.signinRedirect();
}


export default userManager;