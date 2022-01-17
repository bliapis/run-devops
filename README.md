# run-devops

Client microservice => [![Build Status](https://dev.azure.com/liapisbpro2/shopping/_apis/build/status/ShoppingClient-Pipeline?branchName=main)](https://dev.azure.com/liapisbpro2/shopping/_build/latest?definitionId=4&branchName=main)

API microservice => [![Build Status](https://dev.azure.com/liapisbpro2/shopping/_apis/build/status/ShoppingAPI-Pipeline?branchName=main)](https://dev.azure.com/liapisbpro2/shopping/_build/latest?definitionId=3&branchName=main)

This is a project that aims to study Azure DevOps, it contains 2 .Net C# applications with MongoDB that is used as 2 microservices, which are Client and API.

The main technologies and tools used are:

 - Local Envinroment: Docker, Docker Hub and Kubernetes.
 - 
 - Azure Environment: Docker, Azure Docker Registry, AKS and Azure Pipeline.
 
 This project is compose for some main folders, which are:
 
 AKS => YAML files to publish apps in the cloud environment.
 
 K8S => YAML files to publish apps in local kubernetes.
 
 Pipelines => YAML files to configure the Azure Pipelines.
 
 Shopping => There are the apps files and Docker-Compose files.
 
 Shopping/Chopping.API => There are the API app and Docker File.
 
 Shopping/Shopping.Client => There are the Client app and Docker File.
 
 
 Future steps: 
  - Helm
  - Jenkins
  - microservices using Kafka
  - More complex microservices architecture: DDD, CQRS, others.
  - Many data storage technologies: MSSQL Server, MongDB, Cassandra and Redis (cache).
  - Test projects (Unit and Integration Tests)
  - Many clients with many front-end technologies contacting the API`s: WPF, Blazor, React and Angular.
