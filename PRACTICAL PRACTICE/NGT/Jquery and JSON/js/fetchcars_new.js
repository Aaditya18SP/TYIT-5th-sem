let fetchedData;
async function fetchData(){
    fetchedData=await fetch("../json_files/Cars.json")
    .then(response=>{return response.json()})
    .then(json=>{return json})
}

function displayData(){
    fetchData().then(function(){
        console.log("Fetched Data: ",fetchedData);

        fetchedData.forEach(element => {
            
            $("ol").append(`<li>${element.brand} ${element.model} ${element.top_speed}</li>`)
        })


        /*------------------
        STRINGIFY DATA
        -------------------*/
        var stringifiedData=JSON.stringify(fetchedData,replacer,8)
        console.log("Stringified Data: ",stringifiedData);


        /*------------------
        PARSE DATA
        -------------------*/

        var parsedData=JSON.parse(stringifiedData,reviver)
        console.log("Parsed Data: ",parsedData)
})
}

function replacer(k,v){
    if(k=="release_date"){
        return new Date(v).toISOString();
    }
    return v
}

function reviver(k,v){
    if(k=="release_date"){
        return new Date(v);
    }
    return v;
}

displayData()