movie = {
    title :"NAAL",
    Director : "Manjule",
    Price : 150,
    Rating : 4.5
}
function showProperties(obj){
    for (const key in obj) {
        if (typeof(obj[key]) === 'string') {
            console.log(key, obj[key]);            
        }
    }
}
showProperties(movie);