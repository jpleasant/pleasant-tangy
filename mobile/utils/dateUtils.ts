export function getShortDate(date:Date):string{
    const day = getDayName(date.getDay()).substring(0, 3);
    const month = getMonthName(date.getMonth()).substring(0, 3);
    const dateActual = date.getDate() + 1;
    return `${day} ${month} ${dateActual}`;
}


function getDayName(dayNumber:number){
    switch(dayNumber){
        case 0:
            return "Sunday";
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        default:
            return "None";
    }
}
function getMonthName(monthNumber:number){
    switch(monthNumber){
        case 0:
            return "January";
        case 1:
            return "February";
        case 2: 
            return "March";
        case 3:
            return "April";
        case 4:
            return "May";
        case 5:
            return "June";
        case 6:
            return "July";
        case 7:
            return "August";
        case 8:
            return "September";
        case 9:
            return "October";
        case 10:
            return "November";
        case 11:
            return "December";
        default:
            return "None";
            
    }
}