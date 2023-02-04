function FixAge(array) {
    //  Firstly values below 18 and above 60 are filtered out
    let filtered = array.filter((age) => age >= 18 && age <= 60);
    //  If there are no valid ages returns NA
    if (filtered.length === 0) return "NA";
    //  Otherwise array is printed out in string form
    return filtered.toString();
}