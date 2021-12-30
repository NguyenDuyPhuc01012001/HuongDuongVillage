function validateCheckIn(dateCheckIn) {
    dateCheckIn = Date.parse(dateCheckIn);
    if (dateCheckIn >= Date.now() && dateCheckIn !== null) {
        return true;
    }
    return false;
}

export default validateCheckIn;