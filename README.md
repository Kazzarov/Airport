This app is a simulation of an airport
In it, the flights created in an async way using mutithreading.

This app includes both the server side and the front end side.
Please follow these steps in order to run the application(I am aware that for
some of you, some steps don't need to be mentioned - but for some it might be more challenging)

Server side
--------------------------
1.Make sure you re-build the project before running it

2.Please replace the connection string into 
your local or online database source, you can do so by going into "appsettings.json"
and under "ConnectionStrings", put your own connection string.

3.Make sure your database is working and online

4.When running the api, go to https://localhost:7263/api/airport

Client side
----------------------------

1.Install the program(in the terminal or comand prompt on this folder) 
using the line "npm install"

2.make sure the server side is running first(it has a 404 message but it exist logically)
And then go to the terminal/comand prompt and type "npm start"


The page will automatically open and you can start the flights by pressing the button


