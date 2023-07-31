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

$("input[@id=input_add_new_brand]").css("color","green"); 
})