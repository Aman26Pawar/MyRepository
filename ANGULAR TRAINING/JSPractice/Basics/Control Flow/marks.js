marks = [82,100,8]

function calculateGrade(){
    avg = calculateAverage(marks);
    if(avg < 60)
        return "F";
    else if(avg <70 )
        return "D";
    else if(avg <80 )
        return "C";
    else if(avg < 90 )
        return "B";
    else    
        return "A";
}

function calculateAverage(marks){
    let sum = 0;
    let avg;
    for (let index = 0; index < marks.length; index++) {
        sum += marks[index];
        avg = (sum/marks.length);
    }
    return avg;
}

console.log(calculateGrade());