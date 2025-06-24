# Car Rental Database Management & Reporting

An end-to-end car rental database system that supports real-time reservations, branch operations, and data-driven reporting. This project integrates a C# front end with a SQL Server backend and includes Python-based data analysis for business insights.

## Project Overview

This project simulates the operational workflow of a car rental agency. It enables users to:
- Reserve cars based on availability, location, and rental date
- View available vehicles by branch
- Perform backend operations like adding/deleting/modifying records for customers, cars, car types, and rentals

The system was designed with a normalized relational database to ensure accuracy and consistency, and enhanced with Python visualizations to uncover trends and support data-driven decision-making.

## Tools 
- **SQL Server** – Database design and data management  
- **C# (.NET)** – User interface for customer and branch interactions
- **GitHub** – Version control and collaboration

## Features

### Core Functionality
- **Customer Portal:**  
  - View and reserve available cars  
  - Select by branch, car type, and rental period  

- **Staff Portal:**  
  - Manage car inventory and rental data  
  - Create, update, and delete records for customers, cars, rentals, etc.

- **Conflict-Free Reservations:**  
  - Prevents overlapping bookings  
  - Ensures real-time availability is respected

### Business Insights (SQL + Python)
- Booking frequency by car type and time period  
- Car availability tracking and rental rates  
- Revenue by branch/location  
- Fleet utilization and customer behavior analysis

## Database Schema

Entities include:
- `Customer`
- `Car`
- `Branch`
- `CarType`
- `Rental`

Implemented foreign key relationships, constraints, stored procedures, and views to support efficient operations and enforce data integrity.

## Data Analysis Highlights
- SUVs and sedans are the most rented categories
- Peak bookings occur during weekends and holidays
- Downtown branches lead in revenue and rental frequency

## Recommendations
- Scale fleet availability in high-performing branches  
- Implement seasonal and demand-based dynamic pricing  



https://github.com/anikareaza/Car-Rental-System/assets/101680746/afa2c78d-12a8-4c45-b6b6-a7eeca35de2e

