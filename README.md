# Event Management System

A simple C# application for managing events and their associated contacts.

## Description

This Event Management System allows users to create, store, and manage events along with their contact information. Each event includes details such as event type, name, location, date, and associated contact information.

## Features

- Add new events with detailed information
- Retrieve list of all events
- Store contact information for each event
- Unit testing implementation

## Project Structure

- `Event.cs`: Contains the core classes
  - `Event`: Defines event properties
  - `Contact`: Manages contact information
  - `EventManager`: Handles event operations
- `Program.cs`: Main application entry point
- `EventManagerTests.cs`: Unit tests for the system

## Classes

### Event

Properties:

- EventType
- EventName
- Location
- Date
- Contact

### Contact

Properties:

- Name
- PhoneNumber
- Email

### EventManager

Methods:

- AddEvent(Event newEvent)
- GetAllEvents()

## Testing

The project includes MSTest unit tests to verify the functionality of:

- Adding new events
- Retrieving all events
- Validating event properties

## Technologies Used

- .NET 6.0
- C#
- MSTest for unit testing
- NUnit framework

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the tests to ensure everything is working correctly

## Prerequisites

- .NET 6.0 SDK
- Visual Studio 2022 (recommended)

## Running the Tests

1. Open Test Explorer in Visual Studio
2. Click "Run All Tests"
3. Verify all tests pass

## Contributing

1. Fork the project
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Open a pull request

## License

This project is licensed under the MIT License - see the LICENSE file for details.
