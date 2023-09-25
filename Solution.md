# Solution Overview

The solution follows clean code architecture and best practices to provide a structured and maintainable codebase. Here's an overview of the project:

## Projects

1. **CryptoMarketViewer.API**:
   - Contains the controllers for the Web API.
   - Entry point for handling HTTP requests.

2. **CryptoMarketViewer.Application**:
   - Defines application-specific logic, interfaces, and use cases.
   - Orchestrates behavior and interacts with the infrastructure layer.

3. **CryptoMarketViewer.Domain**:
   - Holds core entities that represent the cryptocurrency market.

4. **CryptoMarketViewer.Infrastructure**:
   - Implements external services, adapters, and data access.
   - Interacts with external resources, such as APIs.

## Dependency Flow

- **Domain Layer**:
   - Independent of other layers, contains core data structures.

- **Infrastructure Layer**:
   - Depends on Domain Layer.
   - Implements services and adapters.

- **Application Layer**:
   - Depends on Domain Layer and Infrastructure Layer.
   - Defines interfaces and orchestrates behavior.

- **API Layer**:
   - Depends on Application Layer.
   - Provides HTTP endpoints using controllers.

## Setup Instructions

1. Clone the repository.
2. Open the solution (`CryptoMarketViewer.sln`) in Visual Studio.
3. Build and run the project.

## Usage

Launch the Web API.
