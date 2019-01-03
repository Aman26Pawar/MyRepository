const speedLimit = 70;
const kmPerPoint = 5;

function checkSpeed(speed){
    if(speed <= speedLimit)
        return "OK";
   else
    {
        let point = Math.floor((speed - speedLimit) / kmPerPoint);
        if(point <= 12)
            return "points " + point;
        else 
            return "License Suspended";
    }
}

console.log(checkSpeed(80));