function validateCheckOut(dateCheckIn, dateCheckOut) {
    dateCheckIn = Date.parse(dateCheckIn);
    dateCheckOut = Date.parse(dateCheckOut);
    const _30ngay = 2505600000;
    if (dateCheckOut - dateCheckIn >= _30ngay) {
        return 1;
    }
    if (dateCheckOut < dateCheckIn) {
        return 2;
    }
    if (dateCheckOut < Date.now()) {
        return 3;
    }
    if(dateCheckOut===undefined){
        return 4;
    }
    return 5;
}

export default validateCheckOut;