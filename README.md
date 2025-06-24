# Car Rental System

A  car rental management database system designed to handle real-time reservations, rental tracking, and operational reporting. This project integrates a relational database with a C# user interface and includes optional Python analysis scripts to generate insights on performance and customer behavior.

## Project Overview

This project involves designing and implementing a relational database system to support the operations of a car rental agency. The system allows customers to view and reserve available cars by date, branch, and car type. Branch employees can manage car inventory, customer records, and rental transactions. It ensures accurate booking, availability checks, and automated fee calculations.

## Tools & Technologies

- SQL Server – Database backend
- C# (.NET) – User interface (Windows Forms)
- GitHub – Version control and collaboration

## Database Schema

The system includes five main tables:

- **Customer** – Personal information, insurance, driving license, and membership status
- **Branch** – Rental and return location details
- **CarType** – Defines vehicle categories and cost structure
- **Car** – VIN-based tracking and availability status
- **Rental** – Transaction records with pickup, return, and fee data

Referential integrity and constraints ensure valid and consistent entries.

## Features

### For Customers

- View available cars based on date, branch, and type
- New user registration with automatic ID assignment
- Complete rental transactions with booking confirmation

### For Branch Staff

- Add, update, or delete cars, branches, customers, car types, and rentals
- Check vehicle availability and create rental contracts
- Return cars and calculate final costs, including late fees
- Automatic "Gold Membership" upgrade for customers with 3+ rentals in a year

### Reporting and Insights

- Rental revenue per branch and time period
- Branches with the highest and lowest rental activity
- Customers renting from the same branch multiple times
- Branches with no rentals in a selected period
- Customers renting only within their city





https://github.com/anikareaza/Car-Rental-System/assets/101680746/afa2c78d-12a8-4c45-b6b6-a7eeca35de2e

