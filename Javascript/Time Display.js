// Write a JavaScript program to display the current day and time in the following format.
//Sample Output : Today is : Friday. 
//Current time is : 4 PM : 50 : 22
//Creating a Date() object to use all time related functions.
var time = new Date();
//Creating string to be displayed, extra step.
var string = ("Today is:" + time.getDay() + ".\n Current time is:" + time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds());
//Writing into Document, directly. Throws JSLint error with "document.write can be a form of eval."
document.write(string);
