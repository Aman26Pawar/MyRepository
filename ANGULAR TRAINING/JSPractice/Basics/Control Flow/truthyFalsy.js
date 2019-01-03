array = [1,2,3,4,0,'',8,undefined];
const arrFalsy = ['',0,undefined,NaN,false,null];

function countTruthy(array){
    let falsyCount = 0;
    array.forEach(element => {
        arrFalsy.forEach(falsyElement =>{
           
            if(element === falsyElement)
                falsyCount = falsyCount + 1;
            truthyCount = array.length - falsyCount;
        })
    });
    console.log(truthyCount, falsyCount);
}

countTruthy(array);