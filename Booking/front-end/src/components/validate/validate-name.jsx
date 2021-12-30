function validateName(name) {
    if (name === undefined)
        return false;
    if (name.trim().length === 0) {
        return false;
    }
    return true;
}

export default validateName;