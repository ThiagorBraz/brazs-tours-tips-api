# Braz's Tours Tips API

A RESTful Web API for travel tips developed as part of the 2nd 
Semester Web Design module at Atlantic Technological University 
(ATU), Sligo, Ireland.

## About the Project

BrazsToursTips is a RESTful Web API built with ASP.NET Web API 
framework, designed to serve travel tip data to client applications. 
The API follows standard REST conventions and was developed as part 
of a larger travel agency web project.

## Features

- RESTful endpoints to retrieve travel tips by tour destination
- Database integration via Entity Framework
- 5 travel tips for Irish destinations included as seed data

## Technologies Used

- C# / ASP.NET Web API
- Entity Framework 6
- SQL Server Express
- .NET Framework 4.7.2
- JSON data format

## Project Structure

- Controllers/ — API endpoint controllers
- Models/ — Entity Framework data models
- App_Start/ — Web API and route configurations

## Database

The file `T-SQL_APIBrazsToursTipsDB.sql` contains the full database 
schema and seed data for this API, including travel tips for:
- Wicklow Mountains
- Cliffs of Moher
- Giants Causeway
- Malahide Castle
- Newgrange

To restore the database:
1. Open SQL Server Management Studio (SSMS)
2. Run the script `T-SQL_APIBrazsToursTipsDB.sql`
3. Update the connection string in Web.config if needed

## Academic Context

Developed at Atlantic Technological University (ATU), Sligo — 
BSc (Hons) Computer Science, 2nd Semester, Web Design Module.

## Note

This API was developed to work alongside the Braz's Tours MVC 
web application. It requires a local SQL Server Express instance 
to run. Connection string is defined in Web.config.
