export function max(array) {
    let output;
    let isArrayHaveContent = checkArrayContent(array);
    isArrayHaveContent == true ?  output = Math.max.apply(Math.max,array) :  output = undefined;

    return output;
}

function checkArrayContent(array){
    return array.length != 0 ? true :false;
}
