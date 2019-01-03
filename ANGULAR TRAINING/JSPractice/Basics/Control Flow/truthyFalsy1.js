array = [1,2,3,4,0,'',8,undefined];


function countTruthy(array){
    let count = 0;
    for(let value in array){
        if(value)
         {count++;}
    } 
    return count;
}

console.log(countTruthy(array));