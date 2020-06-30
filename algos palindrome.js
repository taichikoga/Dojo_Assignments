// Write a function that takes a string, and returns a boolean based on 
// whether or not the string is a palindrome.

// EXAMPLE: "tacocat" is a palindrome because it is the same backwards and forwards.

// Challenge: ignore spaces, so "taco cat" "tacocat " "tacocat" would still return true


function isPalindrome(string) {
    var new_str = '';
    for(var i=0; i < string.length; i++){
        if(string[i] != ' '){
            new_str += string[i]
        }
    }
    console.log(new_str);
    var reverse_str = '';
    for(var j=new_str.length-1; j > -1; j--){
        reverse_str += new_str[j];
    }
    console.log(reverse_str);
}

isPalindrome("taco cat")


        if(i !== Arr.length-1-i){
            arr[i] = temp;
            arr[i] = arr[arr.length-1-i];
            arr[arr.length-1-i] = temp;



// CHALLENGE ALGORITHM: Write a function that will find and return the longest palindrome within a string
// EXAMPLE: "the man ate a banana with his tacocat at dinner the other day" would return "tacocat"
function longestPalindrome(string) {

} 