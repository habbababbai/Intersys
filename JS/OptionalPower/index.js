//  This script requires to be connected to any HTML file to work

//  Boolean is created to store info if users presses OK or Cancel
let canceled = false;

//  Two buttons are created and added to HTML document
//  Both on click fire console log with optionalPow function to check value;
let ok = document.createElement("button");
ok.innerHTML = "OK";
ok.onclick = () => {
    canceled = false;
    console.log(optionalPow(2, 3));
};

let cancel = document.createElement("button");
cancel.innerHTML = "Cancel";
cancel.onclick = () => {
    canceled = true;
    console.log(optionalPow(2, 3));
};

document.body.appendChild(ok);
document.body.appendChild(cancel);

//  Function check whether OK or Cancel has been clicked and return output
function optionalPow(a, b) {
    const output = canceled ? Math.pow(b, a) : Math.pow(a, b);
    return output;
}
