import { UPDATE_MOVIE, FETCH_MOVIE_ASYNC, CLEAN_MOVIE, SET_USER, CLEAN_USER, UPDATE_USER, UPDATE_USER_ASYNC, ADD_USER_CREDIT_CARD, ADD_USER_CREDIT_CARD_ASYNC } from "./ActionTypes"

//Movie actions
export const updateMovie = (movie) => {
    return {
        type: UPDATE_MOVIE,
        payload: movie,
    }
}

export const cleanMovie = () => {
    return {
        type: CLEAN_MOVIE,
    }
}

export const fetchMovieAsync = (id) => {
    return {
        type: FETCH_MOVIE_ASYNC,
        payload: id,
    }
}
//Movie actions

//User actions
export const setUser = (user) => {
    return {
        type: SET_USER,
        payload: user,
    }
}

export const updateUser = (user) => {
    return {
        type: UPDATE_USER,
        payload: user
    }
}

export const updateUserAsync = (user) => {
    return {
        type: UPDATE_USER_ASYNC,
        payload: user,
    }
}

export const addUserCreditCard = (card) => {
    return {
        type: ADD_USER_CREDIT_CARD,
        payload: card,
    }
}

export const addUserCreditCardAsync = (card) => {
    return {
        type: ADD_USER_CREDIT_CARD_ASYNC,
        payload: card,
    }
}

export const cleanUser = () => {
    return {
        type: CLEAN_USER,
    }
}
//User actions