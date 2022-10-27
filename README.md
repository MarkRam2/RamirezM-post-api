# RamirezM-post-api

to start the program you will have to start the debug in vs code you will then have to go into the debug console and copy the urls from there
it should look like this the number may diffrent http://localhost:5028 

you will then need to add
/Hello or /Adding
if you out /Hello
you will need to open post net
and go to the body tab add click raw and at the left where the blue text says Text click and select JSON
you will then need to past this into the area that has a 1 on the first line

{
    "userName" : {name},
    "lastName" : {lastname}
}

you can then replace {name} and {lastname} with your name and last name respectivly 

if you chose Adding you will need to put this

{
    "num1" : number1,
    "num2" : number2
}

number and number2 may be replaced with what ever whole number of your choosing such and 2 and 10 it will add them togeather and in this example you will get 12
