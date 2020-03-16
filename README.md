[![Build Status](https://dev.azure.com/uchan20/County-OR-Board/_apis/build/status/Rev-Team-4.County-OR-Board?branchName=master)](https://dev.azure.com/uchan20/County-OR-Board/_build/latest?definitionId=2&branchName=master)

A web application that helps Physicians, Health facilities and Operating Room teams to reduce patient surgical waiting time, 
increase utilization of idle Operating Room resources, reduce Operating Room backlog and congestion, reduce wastage and manage 
time and outcomes of Operating Room procedures.

Note: The web application was constructed using the MVC design pattern. 

**Features currently in progress**
1. Create docker-compose to start both ASP.NET and SQL Server containers.
 - Currently, the challenge is to figure out how to populate database in SQL Server container. 
 - There are few options I am looking at. One is to apply DB migrations at runtime. The other is to create SQL script and run the script.
2. Add back the unit tests and ensure that SonarCloud can display proper code coverage. 
 - In the process of adding back unit tests, I may also plan on refactoring the back-end before moving towards the front-end (planned for another time!). 
