
maximumFunc = (a,b) =>{
    if(a < b)
        return  b;
    else 
        return a;
}
let maxNumber = maximumFunc(4,5);
console.log('max number is '+ maxNumber);