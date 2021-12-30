function isNumberOnly(phone) {
    for (let i = 0; i < phone.length; i++) {
        if (phone[i] < '0' || phone[i] > '9') {
            return false;
        }
    }
    return true;
}
function validatePhone(phone) {
    if (phone === undefined)
        return false
    return (isNumberOnly(phone) && phone[0] === '0' && phone.length === 10)
}

export default validatePhone;