# ASP.NET Core Web API for AKS - cn_service

This project was created using the **RobBell.cn_service.Template** `dotnet new` template. For more information, visit the project homepage:

https://github.com/robbell/dotnet-aks-api-template/

## Enabled features

* `SampleController` sample endpoint
* **Docker** containerisation
* **Helm** charts for deploying to Kubernetes
* **OpenAPI** support (Swagger)
* **Health checks** including Kubernetes liveness and readiness probes
* Logging configuration with **AppInsights**

## Project overview

* `chart/` - Helm Charts for deploying to Kubernetes
    * `Chart.yaml`
    * `values.yaml` - includes a reference to the published image
    * `template/`
        * `deployment.yaml`
        * `service.yaml`
* `Controllers/`
    * `v1/`
        * `SampleController.cs` - Sample HTTP endpoint
* `HealthChecks/`
    * `LiveHealthCheck.cs` - used by the Kubernetes liveness probe
    * `ReadyHealthCheck.cs` - used by the Kubernetes readiness probe
* `Properties/`
    * `launchsettings.json`
* `cn_service.csproj` - ASP.NET Web API project
* `appsettings.json` - includes AppInsights instrumentation key
* `Dockerfile` - Docker containerisation
* `Program.cs`
* `README.md` - this file
* `Startup.cs`
