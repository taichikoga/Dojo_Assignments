// Write a function that will take an array of numbers, and return the
// sum of all unique numbers in that array. Hint: Use a frequency table!

// A frequency table is a dictionary where, in each key-value pair, 
// the key is the item in the array, and the value is the number of times
// that thing appears

// EXAMPLE: [1,3,3,6,6,7,8,10] will return 26 because 1+7+8+10 = 26



function sumUniques(arr) {
    var new_dict = {};
    for(var i=0; i<arr.length; i++){
        new_dict.push(arr[i]);
        for(var j=0; j<arr.length; j++){
            count = 0;
            if(arr[i] = arr[j]){
                count += 1;
                new_dict[i].push(arr[j]);
            }
        }
    }
}
sumUniques([1,3,3,6,6,7,8,10])


// Write a function that will take a string, and return a new string that contains
// the same words, but in reverse.

// EXAMPLE: "hello world my name is Cody" will return "Cody is name my world hello"
function reverseWordOrder(string) {
    
}