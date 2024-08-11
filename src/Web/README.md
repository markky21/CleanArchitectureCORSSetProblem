# Aqua Diary
This repository is a web API application for Aqua Diary.
## Getting Started
### Template
This project is based on the [Clean Architecture Solution Template](https://github.com/jasontaylordev/CleanArchitecture) template.

Launch the app:
```bash
cd src/Web
dotnet run
```

To learn more, run the following command:
```bash
dotnet new ca-sln --help
```

You can create use cases (commands or queries) by navigating to ./src/Application and running dotnet new ca-usecase. Here are some examples:

To create a new command:
```bash
dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int
```

To create a query:
```bash
dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm
```

To learn more, run the following command:
```bash
dotnet new ca-usecase --help
```

### Logging
The template uses [Serilog](https://serilog.net/) to log events. The logs are written to the console and a file. The logs are written to the console and a file. The log file is located in the `./logs` folder. The log level can be changed in the `appsettings.json` file.

To read logs use seq:
```bash
docker run -d --name seq -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
```
and navigate to http://localhost:5341

### Database
To create postgresql database:
```bash
docker run --name AquaDiaryAPI -e POSTGRES_PASSWORD=mysecretpassword -p 5432:5432 -d postgres
```

Running database migrations is easy. Ensure you add the following flags to your command (values assume you are executing from repository root)

* `--project src/Infrastructure` (optional if in this folder)
* `--startup-project src/Web`
* `--output-dir Data/Migrations`

For example, to add a new migration from the root folder:

`dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\Web --output-dir Data\Migrations`

### Test

The solution contains unit, integration, and functional tests.

To run the tests:
```bash
dotnet test
```

The solution contains unit, integration, functional, and acceptance tests.

To run the unit, integration, and functional tests (excluding acceptance tests):
```bash
dotnet test --filter "FullyQualifiedName!~AcceptanceTests"
```

To run the acceptance tests, first start the application:
```bash
cd .\src\Web\
dotnet run
```

Then, in a new console, run the tests:
```bash
cd .\src\Web\
dotnet test
```

### Deploy

The template includes a full CI/CD pipeline. The pipeline is responsible for building, testing, publishing and deploying the solution to Azure. If you would like to learn more, read the [deployment instructions](https://github.com/jasontaylordev/CleanArchitecture/wiki/Deployment).

### Technologies

* [ASP.NET Core 8](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [Entity Framework Core 8](https://docs.microsoft.com/en-us/ef/core/)
* [Angular 15](https://angular.io/) or [React 18](https://react.dev/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [NUnit](https://nunit.org/), [FluentAssertions](https://fluentassertions.com/), [Moq](https://github.com/moq) & [Respawn](https://github.com/jbogard/Respawn)

### Help
To learn more about the template go to the [project website](caRepositoryUrl). Here you can find additional guidance, request new features, report a bug, and discuss the template with other users.
