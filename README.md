# Contents Limit Insurance
A web app made for Nude Solutions Developer Assignment for the purposes of allowing customers to calculate the total contents limit they require and maintain a list of high-value items.


## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

## Prerequisites
## Installing
## Testing
## Deployment
## Built With
- [React](https://reactjs.org/) Front End SPA
- [ASP.NET Core 3.1](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1) Back End API
- [EntityFrameworkCore](https://docs.microsoft.com/en-us/ef/) on SQLite for demo purposes.
- [Automapper](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection) Entity to Dto Mapping
- [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) API Documentation/Testing

## Authors
- Bryan Martinez

## License
This project is licensed under the MIT License - see the [LICENSE.MD](https://github.com/BryanMartinez95/ContentsLimitInsurance/blob/master/LICENSE) file for details

## Useful Database Commands
- dotnet ef migrations add {MIGRATION_NAME} --add migration
- dotnet ef database update  --update database
- dotnet ef database update {MIGRATION_NAME} -- target a specific migration
- dotnet ef migrations remove -- removes last migration

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers <- documentation for multiple database providerss
