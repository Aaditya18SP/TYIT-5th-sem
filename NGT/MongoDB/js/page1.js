

async function fetchJSON(){
    const JSONdata= await fetch('../json/reported_items.json')
.then((response) => {return response.json()})
.then((json) => {return (json)});


console.log(typeof(JSONdata));
console.log(JSONdata);
//stringify the data
const stringifiedData= JSON.stringify(JSONdata);
console.log(stringifiedData);

const parsedData=JSON.parse(stringifiedData);
console.log(parsedData);

/*
const arr=Array.from(parsedData);
console.log(arr);

*/

var divDisplay = document.getElementById("displayDiv");
for(i=0;i<parsedData.length;i++){
    divDisplay.innerText+= " \n"+i+"." +parsedData[i].name + " \n \t description: " + parsedData[i].description;
}
/*
for(i=0;i<arr.length;i++){
    divDisplay.innerText+= " \n"+i+"." +arr[i].name + " \n \t description: " + arr[i].description;
}
*/
}

fetchJSON();
/*
import data from './json/reported_items.json';
$(document).ready(function(){
//const Jsonfile= "../json/reported_items.json";

console.log(data);




});
*/