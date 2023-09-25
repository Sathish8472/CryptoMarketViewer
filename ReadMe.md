# Crypto Market Viewer Web API

This project implements a Web API to fetch and display market data for cryptocurrencies. It follows best practices and utilizes clean code architecture.

## Project Overview

The solution is organized using clean code architecture principles, separating concerns into layers:

- **Domain Layer**:
  - Contains core entities and business logic representing the cryptocurrency market.

- **Infrastructure Layer**:
  - Implements external services, adapters, and data access. Interacts with external resources like APIs.

- **Application Layer**:
  - Defines interfaces and use cases. Orchestrates the application's behavior, leveraging services from the Infrastructure layer.

- **API Layer**:
  - Provides HTTP endpoints to expose the functionality of the application. Controllers in this layer interact with the Application layer.

