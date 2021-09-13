# SignalRConsoleApplication
SignalR Console app w/ PostgreSQL database

Here are the basic steps in order to run the whole project smoothly:

1.Clone the repo locally

2.Change the connection string in DBConnection.cs inside SignalRConsoleDatabase to use your local database

3.Build the solution

4.Restore packages (if missing)

5.Set the SignalRConsoleApp as StartUp Project

6.Run the solution

7.While the solution is running, browse Solution Explorer for the SignalRConsoleClient project, right-click on it, select "Debug", then "Start New Instance"

8.Alternatively, configure both as startup projects
