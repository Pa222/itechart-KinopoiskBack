import { removeCookie } from "../../Utils/Cookies";
import { CLEAN_USER, UPDATE_USER } from "../ActionTypes";

const defaultState = {
    authorized: false,
    user: {
        role: '',
        name: '',
        phoneNumber: '',
        gender: '',
        email: '',
        cardNumber: '',
        avatar: 'https://res.cloudinary.com/pa2/image/upload/v1636535929/user_fhguim.png',
    },
}

const cleanUser = {
    role: '',
    name: '',
    phoneNumber: '',
    gender: '',
    email: '',
    cardNumber: '',
    avatar: 'https://res.cloudinary.com/pa2/image/upload/v1636535929/user_fhguim.png',
}

const UserReducer = (state = defaultState, action) => {
    switch(action.type){
        case UPDATE_USER:{
            state.user = action.payload;
            state.authorized = true;
            break;
        }
        case CLEAN_USER:{
            state.user = cleanUser;
            state.authorized = false;
            removeCookie("AuthToken");
            break;
        }
        default:
            break;
    }
    return Object.assign({}, state);
}

export default UserReducer;