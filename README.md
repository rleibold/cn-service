# ASP.NET Core Web API for AKS - cn-service

A sample project that is a data driven API service using MySQL DB.

## Current Features
* `ChuckNorrisController` endpoint
* **Docker** containerization
* **Kubernetes** Deployment

## Future Enhancements
* Proper unit testing on all code
* implement health checks in kubernetes
* properly use **Helm** to configure the namespace with mysql and cn-service pods (current deployment is mostly manual)
* better implementation of configuration (use of secrets for db password, connection, etc)
