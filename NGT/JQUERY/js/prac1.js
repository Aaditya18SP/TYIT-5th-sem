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

//DOM MANIPULATION

/*
//Setting the values
$("#class").val("Class 12th"); //set the value of form field

$("p").text("The quick <b>brown fox</b> jumps over the <b>lazy dog</b>"); //set the text of the thetag

$("p").html("The quick <b>brown fox</b> jumps over the <b>lazy dog</b>"); //set the inner HTMl of the tag

$("selector").attr("attribute","value") // set the attributes of the tag

//Others

//to replace a tag with another tag
//$("p").replaceWith("<h1>This is new heading</h1>");


//$( ".inner" ).append( "<p>Zara</p>" );

//$("<p>Zara</p>").appendTo(".inner");

$( ".inner" ).after( "<p>Zara</p>" );

$("<p>Zara</p>").insertAfter(".inner");

$( ".inner" ).prepend( "<p>Zara</p>" );

$("<p>Zara</p>").prependTo(".inner");

$( ".inner" ).before( "<p>Zara</p>" );

$("<p>Zara</p>").insertBefore(".inner");


$( ".hello" ).remove();
$("div").remove(".hello");
$( ".hello" ).empty();

$( ".hello" ).addClass("big" );

$( ".hello" ).addClass("big" );

$( ".hello" ).toggleClass("big" );//remove if present , Add if not present

$("selector").width();
$("selector").width("400px");


$("div").height();
$("div").height("100px");

// CSS
//get the css value

$("selector").css("background-color");//get the background  property

//set the css

$("selector").css("background-color","red");
$("selector").css({"background-color":"red","width":"100%"}); //multiple properties

//EFFECTS
//1. show

$("selector").show();
$("selector").show(1000); //speed with which to show the selected div

//2. hide

$("selector").hide();
$("selector").hide(1000); //speed with which to hide the selected div

//3.fadeIn 

$("#box").fadeIn(1000,function(){

});

//4.fadeOut


$("#box").fadeOut(1000,function(){

});


//5.Fade Toggle
$("#box").fadeToggle(1000);


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

$("#list_of_cars").text("");
$("#input_add_new_brand").on("input",()=>{
    $text_input=$("#input_add_new_brand").val();

    

    

    //get the last inputed element
    $string=$text_input[$text_input.length-1];

    if($string!=undefined){
        console.log( $("#list_of_cars").text() );
/*
        $("#list_of_cars").text(
            $("#list_of_cars").text() + $string
            );
            */

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






    

});