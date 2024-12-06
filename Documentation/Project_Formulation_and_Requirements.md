# Project Formulation & Initial Requirements

## Project Overview

This project is a simplified ride-sharing system inspired by BlaBlaCar. The platform allows users to register as either drivers or passengers. Drivers can post available rides, while passengers can search for and book rides.

The system focuses on core functionality, emphasizing learning concepts such as:
- User authentication and authorization.
- RESTful API design.
- Role-based access control.
- Using SQLite with Entity Framework Core for data persistence.

## Project Domain

Ride-sharing platforms have become a popular eco-friendly and cost-effective transportation option. This project simplifies the concept by allowing users to find or offer rides while learning about .NET development.

## Requirements (User Stories)

### As a Driver:
- I want to create an account so I can manage my rides.
- I want to log in to access my profile and rides.
- I want to post a ride with details like destination, date, and time.
- I want to edit or delete my ride if plans change.

### As a Passenger:
- I want to create an account to book rides.
- I want to log in to view my booking history.
- I want to search for available rides based on destination and time.
- I want to book a ride and receive confirmation.

### General:
- The system must allow roles (drivers and passengers) to access specific resources.
- The system must securely store user data using SQLite and Entity Framework Core.

## Technology Stack
- **Backend:** ASP.NET Core Web API
- **Frontend:** HTML/CSS
- **Database:** SQLite with Entity Framework Core
