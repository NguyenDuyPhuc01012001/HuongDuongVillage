function isNumberOnly(id) {
    for (let i = 0; i < id.length; i++) {
        if (id[i] < '0' || id[i] > '9') {
            return false;
        }
    }
    return true;
}
function validateID(id) {
    if (id === undefined) {
        return false;
    }
    if ((id.length === 9 || id.length === 12) && isNumberOnly(id)) {
        return true;
    }
    return false;
}

export default validateID;