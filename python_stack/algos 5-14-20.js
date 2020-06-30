// Write a function that is given a string and a number, and returns the string rotated to the 
// right that many times

// EXAMPLE: rotate("hello world", 3) would return "rldhello wo", because you've essentially
// shifted the string to the right 3 times, and the text at the end "wrapped around" for the
// rotation
function rotate(string, num){
    var new_str = "";
    
}




{
    for(i=0; i<num; i++){
        for(j=0; j<string.length; j++){
            temp = string[0];
            string[0] = string[string.length-1];
            string[1] = temp
            if(string.length > j > 0){
                string[j+1] = string[j];
            }
        }
    }
}


// Write a function that will take 2 strings (oString and tString, for original string and test string),
// and return a boolean based on whether or not tString is a rotated version of oString

// EXAMPLE: isRotation("hello world", "rldhello wo") would return true, because, as we saw in the previous
// algorithm, "hello world", rotate right 3 spots, returns "rldhello wo"
function isRotation(oString, tString){

}