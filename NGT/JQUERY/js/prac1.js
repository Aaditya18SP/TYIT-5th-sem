$(document).ready(function(){
    //alert("hello");


    //hovering over the car brands
$('.car_list_tag').hover(function(){
    console.log($(this));
   
    //$(this).fadeIn("fast",()=>{
        
        $(this).css("transform","scale(1.1)");
      
        $(this).css("transition","transform 0.5s ease");
        $(this).addClass("bg-primary");
        $(this).find("p").css("color","white")
    //})
},function(){

    //$(this).fadeOut("fast",()=>{
        //alert("fadeout");
        $(this).css("transform","scale(1)");
        $(this).removeClass("bg-primary");
        $(this).find("p").css("color","black")
    //})
    //
}
);

//$("div:not(#porsche)").fadeOut("slow"); //select the divs that dont have id porsche

//$("div:not(.mb-3)").fadeOut("slow"); //select the divs that dont have class mb-3

//$("div.mb-3").fadeOut("slow"); //select all the div with the class mb-3

$("div#list_of_cars.container").css("background-color","red"); //select a div with specified id AND class

$("div.mb-3 select#input_car_brand option").css("color","blue"); //select div with class mb-3 inside which select a  'select' tag with id input_car_brand

$("input[id='input_add_new_brand']").css("color","green"); //select the input with id input_add_new_brand

$("ul li:first").css("background-color","green"); //select the first element in of the unordered list


$("ul li:last").css("background-color","purple"); //select the last element in of the unordered list

$("hr").css({"background-color": "black","width":"100%"}); //how to provide multiple propeties to the css method

$("#input_car_name").attr("type","password") ;// set the attributes of the tag


$("b").replaceWith("<h1>This is new heading</h1>");
$( "#list_of_cars" ).append( "<p>Rimac</p>" );

$( "#list_of_cars" ).after( "<div class='mb-3'><h1>This is after method of DOM manipulation and this add a new html element after the specified element</h1></p>" );

$( "#list_of_cars" ).before( "<p>World Record Holder of fastest accelerating car</p>" );

$("#animation_div").attr("hidden","true");

$("#animation_div").removeAttr("hidden");

//$("#animation_div").removeAttr("hidden");

$("#input_car_brand option[value='Other']").remove(); //remove the selected element

//DOM MANIPULATION

/*
//Setting the values
$("#input_add_new_brand").val("Tata Motors"); //set the value of form field

$("div b").text("Changing test content to a new text using .text() function"); //set the text of the the tag

$("div b").html("The quick <b>brown fox</b> jumps over the <b>lazy dog</b>");

$("#input_car_name").attr("type","password") ;// set the attributes of the tag

$("animation_div").attr("hidden","true");
$("animation_div").removeAttr("hidden"); //remove an attribute



//Others

//to replace a tag with another tag
//$("b").replaceWith("<h1>This is new heading</h1>");


//$( "#list_of_cars" ).append( "<p>Rimac</p>" );


$( "#list_of_cars" ).after( "<div class="mb-3"><h1>This is after method of DOM manipulation and this add a new html element after the specified element</h1></p>" );

$( "#list_of_cars" ).prepend( "<p>Alfa Romeo. This is the prepend method which adds an element inside the selector element but adds it before all the child elements</p>" );


$( "#list_of_cars" ).before( "<p>World Record Holder of fastest accelerating car</p>" );



$("#input_car_brand option[value='Other']").remove(); //remove the selected element
$( "#animation_div" ).remove(); //remove all 
$( "#animation_div" ).empty();

$( "#animation_div" ).addClass("mt-4" );

$( "#animation_div" ).toggleClass(""mt-4" );//remove if present , Add if not present

console.log("width is: "+$("#animation_div").width()); //get the width
$("#animation_div").width("400px"); //set the width


console.log("height is: "+$("#animation_div").height()); //get the height
$("#animation_div").height("100px"); //set the heigth

// CSS
//get the css value

$("#animation_div").css("background-color");//get the background  property

//set the css

$("#animation_div").css("background-color","red");
$("#animation_div").css({"background-color":"red","width":"100%"}); //multiple properties

//EFFECTS
//1. show

$("#animation_div").show();
$("#animation_div").show(1000); //speed with which to show the selected div

//2. hide

$("#animation_div").hide();
$("#animation_div").hide(1000); //speed with which to hide the selected div

//3.fadeIn 

$("#animation_div").fadeIn(1000,function(){
console.log("The div is hidden and will appear");
});

//4.fadeOut


$("#animation_div").fadeOut(1000,function(){
console.log("The div is hidden and will appear");
});


//5.Fade Toggle
$("#animation_div").fadeToggle(1000);


*/

//ANIMATION

//animate the button to increase in width
$("button[type='submit']").hover(function(){
    $("#submit_btn").animate({
        //marginRight: "+=400px",
       // width: "+=500px",
        width: "+=5%",
            }, "slow","swing",function(){
                $("div#list_of_cars b").text("Animation");
            }
        
            )
});


//
//Animate and add the text in a div as the form value is filled

/*
$("#list_of_cars").text("");
$("#input_add_new_brand").on("input",()=>{
    $text_input=$("#input_add_new_brand").val();

    

    

    //get the last inputed element
    $string=$text_input[$text_input.length-1];

    if($string!=undefined){
        console.log( $("#list_of_cars").text() );
        */
/*
        $("#list_of_cars").text(
            $("#list_of_cars").text() + $string
            );
            */
/*
            $("#list_of_cars").append(`<p>${$string}</p>`);

            $("#list_of_cars p").css({"display":"inline-block"});
    }

    $("#list_of_cars p").animate({
        marginRight:"+20px",
        fontSize:"+20px"
        
    },"slow","linear",()=>{
        $("#list_of_cars p").css("transform","scale(2)");
        
    });


});






   */ 

});