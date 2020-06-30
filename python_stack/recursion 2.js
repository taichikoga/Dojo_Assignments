// Write a function that, given an array, returns the sum of the elements. USE RECURSION


// EXAMPLE: sumArr([8])
function sumArr(array, index=0){
    // Base case is what keeps us from exceeding our max call stack size/looping infinitely
    if (index == array.length-1) {
        return array[index];
    }

    // This would be my general (recursive) case
    return array[index] + sumArr(array, index+1);
}



// Write a function that returns the sum of a number RECURSIVELY

// EXAMPLE: sigma(3) returns 6, because 3 + 2 + 1 = 6
function sigma(num) {
    // BASE CASE!! We've reached our base case if num is 1, because the sigma of 1 is 1
    if (num == 1) {
        return num;
    }

    // General (recursive) case: we need to add num to the sigma of num - 1 and return it
    return num + sigma(num-1);
}



/* *********************************************************
            THESE ALGOS ARE TO BE DONE RECURSIVELY
********************************************************* */

// Write a function that, given a number, returns its factorial

// Factorial: 7! = 7 * 6 * 5 * 4 * 3 * 2 * 1
// The ! does not mean the number is really excited!!

// EXAMPLE: factorial(3) returns 6 because 3 * 2 * 1 = 6
function factorial(num){
    if(num == 1){
        return num;
    }
    return num * factorial(num-1);
}
console.log(factorial(3))


//Write a function that, given a number, will return that element in the Fibonacci sequence

// Fibonacci Sequence: Each number in the sequence is the sum of the previous two numbers.

// 1 1 2 3 5 8 13 21 34 ...

// EXAMPLE: rFib(4) would return 3, because 3 is the 4th number in the fibonacci sequence!

// NOTE! You may need to have an additional parameter!!
function rFib(num) {
    if(num == 1){
        return 1
    }
    else if(num == 2){
        return 1
    }
    else{
        return rFib(num-1) + rFib(num-2)
    }
}
console.log(rFib(6))