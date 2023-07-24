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

})