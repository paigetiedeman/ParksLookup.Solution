<div align="center">

[![Language][language-shield]][language-url]
[![MIT License][license-shield]][license-url]

# National Parks API

#### _By: Paige Tiedeman_

#### This is a C# localhost API that allows the user to GET,PUT, POST, and DELETE data from their MySQL database using Postman.

</div>

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* Postman
* Swagger
* VS Code

## Description

This API is created with RESTful principles to store NAtional Park information within the United States. The user can view information within postman or running on a local server. 

## Getting Started

#### Installation

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install [MySQL Community](https://dev.mysql.com/downloads/file/?id=484914)
* Download and install [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
* Clone or download the zip file of this repository to your desktop
* Open in your code editor
* Install following packages:
  - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  - `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
  - `dotnet tool install --global dotnet-ef --version 3.0.0`
* Commit and push your .gitignore file to your repo
* Add the file ParksLookup.Solution/ParksLookup/appsettings.json and insert the following:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=paige_tiedeman;uid=[YOUR-UID];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* Insert your MySQL password and user Id
* Run `$ dotnet restore` to install bin & obj folder

### Steps to Use
* In your terminal navigate into ParksLookup.Solution/ParksLookup
* If Migrations folder is not present run `$ dotnet ef migrations add Initial` to add Migrations folder
* Then run `$ dotnet ef database update` to create the schema
* Run `$ dotnet run` to start the live server at http://localhost:5000 
* This API uses [Swagger documentation](https://swagger.io/tools/swagger-ui/)
  - Go to https://localhost:5001/index.html to access
  - NOTE: the program must be running to access Swagger
  - To Test a query, find the tab for the query type and click the "Try It Out" button located in the top right corner of the card.
  -  Enter your query in the form field(s) and click the "Execute" button to view the server responses
* Open Postman: 
  - Use https://localhost:5001/api/Parks to GET or POST Entries in Postman
  - Go to https://localhost:5001/api/Parks to see entires

## Parks API Endpoints

Base URL: `http://localhost:5000`

### HTTP Request Structure:
```
GET /api/Parks
POST /api/Parks
GET /api/Parks/{id}
PUT /api/Parks/{id}
DELETE /api/Parks
```
### Path Parameters:

| Parameter | Type | Description |  
| :---: | :---: | --- |
| ParkName | string | Returns any park by park names |  
| State | string | Returns any park by State name |    
| Rating | int | Returns any park with that number rating |  

### Example Query:

https://localhost:5000/api/Parks/?state=WA

```
  {
    "parkId": 1,
    "parkName": "Mount Ranier National Park",
    "state": "WA",
    "rating": 9,
    "highlight": "Paradise, hiking",
    "visited": true
  }
```
## Known Bugs

* Not a real API as it can only be run locally

## License

* MIT: click badge at top for info
* Copyright (c) 2021 Paige Tiedeman

## Contact Information

_Paige Tiedeman @ github.com/paigetiedeman_

[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-green
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/