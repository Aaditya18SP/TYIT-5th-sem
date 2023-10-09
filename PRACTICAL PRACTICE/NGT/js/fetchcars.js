let fetchedData;


 async function fetchCarsData(){
    
     fetchedData= await fetch('../Jquery and JSON/json_files/Cars.json')
    .then((response) => {return response.json()})
    .then((json)=>{return json});
    console.log(fetchedData);

   
}

function displayData(){

    //var ol_car_list= document.getElementById("ol_car_list");
    
    fetchCarsData()
    .then(()=>{
        console.log(typeof (fetchedData));

        //ACCESS THE FETCHED DATA
        fetchedData.forEach(element => {
            console.log(element.brand)

            var htmltemplate=`<li> 
            ${element.brand} ${element.model} ${element.colors[0]} ${element.release_date}
        </li>`;

        //ol_car_list.innerHTML +=htmltemplate;

        //INSERT THE DATA USING JQUERY
        $("ol").append(htmltemplate)


        });

        


        /*----------------
        STRINGIFY DATA 
        ----------------*/
        var stringifiedDATA= JSON.stringify(fetchedData,replacer,8);
        console.log(stringifiedDATA)
        
    
        /*----------------
        PARSE DATA 
        ----------------*/

        var parsedData= JSON.parse(stringifiedDATA,replacer);
        console.log("PARSED DATA:" + parsedData);
    

        //ACESSS THE PARSED DATA
        for (var i=0;i<parsedData.length;i++){
            console.log(parsedData[i].model + parsedData[i].release_date)
        }
        


        /*-------------------------
        JQUERY
        --------------------------*/ 

        /*
        $("ol li").hover(function(){

            //WHEN MOUSE ENTERS
            $(this).css("color","red");
            $(this).css("transform","scale(1.1)")
            $(this).css("transition","trasnform 0.5s ease")
        },
        function(){
            //WHEN MOUSE LEAVES
            $(this).css("color","black")
            $(this).css("transform","scale(1)")
            $(this).css("transition","trasnform 0.5s ease")
        });

        */


        $("ol li").hover(function(){
            $(this).animate({
                //width:"+=5%",
                fontSize:"+=20px"
            },"slow","swing")
        },
        function(){
            $(this).animate({
                fontSize:"20px",
            },"fast","linear")
        })

    });


    
    
}



function replacer(k,v){
    if (k=="release_date"){
        return new Date(v).toISOString();
    }
    return v;
}

function reviver(k,v){
    if (k=="release_date"){
        return new Date(v)
    }
    return v;
}


displayData();


