# Contents Limit Insurance
A web app made for Nude Solutions Developer Assignment for the purposes of allowing customers to calculate the total contents limit they require and maintain a list of high-value items.

###
See the [Front End Documentation](https://github.com/BryanMartinez95/ContentsLimitInsurance/tree/master/ContentsLimitInsurance/ClientApp) for more information over how the front end was designed.

## Prerequisites
Install NET Core SDK https://dotnet.microsoft.com/download

Install Entity Framework Core CLI or PMC Tools

- [CLI](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet) 

- [Visual Studio 2019 Package Manager Console](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell)

Install Nodejs & npm https://nodejs.org/en/
## Development
build & Run with IDE/Visual Studio or run `dotnet run` on CLI

Access Locally `https://localhost:44326`

## Testing
### Swagger
View & Test available APIs once project is running `https://localhost:44326/swagger/index.html`

### XUnit
Integration Tests the back end are done with XUnit in the [ContentsLimitInsurance.IntegrationTests](https://github.com/BryanMartinez95/ContentsLimitInsurance/tree/master/test/ContentsLimitInsurance.IntegrationTests) directory. Unit Tests can be done via Visual Studio or with CLI `dotnet test`
 when inside the ContentsLimitInsurance.IntegrationTests folder
 
 Tests are ran with an in memory SQLite database
## Deployment
Application is currently deployed on Azure App Services: https://contentslimitinsurance20200803193134.azurewebsites.net
## Built With
- [React](https://reactjs.org/) Front End SPA
- [ASP.NET Core 3.1](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1) Back End API
- [EntityFrameworkCore](https://docs.microsoft.com/en-us/ef/) on [SQLite](https://www.sqlite.org/index.html) for demo purposes.
- [Automapper](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection) Entity to Dto Mapping
- [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) API Documentation/Testing

## Additional Libraries/Resources
- [Bulma](https://bulma.io/)
- [CSS Spinner](https://projects.lukehaas.me/css-loaders/)
- [Axios](https://github.com/axios/axios)
- [XUnit](https://xunit.net/)

## Roadmap
See the [open issues](https://github.com/BryanMartinez95/ContentsLimitInsurance/issues) for a list of proposed features (and known issues).

## Authors
- Bryan Martinez

## License
This project is licensed under the MIT License - see the [LICENSE.MD](https://github.com/BryanMartinez95/ContentsLimitInsurance/blob/master/LICENSE) file for details

## Useful Database Commands (For CLI)
- dotnet ef migrations add {MIGRATION_NAME} --add migration
- dotnet ef database update  --update database
- dotnet ef database update {MIGRATION_NAME} -- target a specific migration
- dotnet ef migrations remove -- removes last migration

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers <- documentation for multiple database providers
