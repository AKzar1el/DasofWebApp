# DasofWebApp Vehicle Price Calculator

## Overview
The Vehicle Price Calculator is a component of the DasofWebApp, designed to calculate vehicle prices based on base prices, VAT, and additional equipment costs. It provides an API endpoint to submit pricing details and receive a calculated total price, both net and gross.

## Features
- Calculate vehicle base price net and gross.
- Calculate additional equipment price net and gross.
- Compute total vehicle price net and gross considering VAT.

## Getting Started

### Prerequisites
- .NET 7.0 or higher.
- Visual Studio 2022 or any preferred IDE with C# support.

### Installation
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore the NuGet packages.
4. Build the solution to ensure everything is set up correctly.

### Running the Application
1. Run the application using Visual Studio or the .NET CLI: dotnet run --project path/to/DasofWebApp.csproj
2. Once running, the application will be available at `http://localhost:5000` by default.

## Usage

To calculate the vehicle price, make a POST request to `/api/vehicleprice/calculate` with a JSON payload containing the vehicle pricing details.

### Request Example

Content-Type: application/json

# DasofWebApp Vehicle Price Calculator

## Overview
The Vehicle Price Calculator is a component of the DasofWebApp, designed to calculate vehicle prices based on base prices, VAT, and additional equipment costs. It provides an API endpoint to submit pricing details and receive a calculated total price, both net and gross.

## Features
- Calculate vehicle base price net and gross.
- Calculate additional equipment price net and gross.
- Compute total vehicle price net and gross considering VAT.

## Getting Started

### Prerequisites
- .NET 7.0 or higher.
- Visual Studio 2022 or any preferred IDE with C# support.

### Installation
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore the NuGet packages.
4. Build the solution to ensure everything is set up correctly.

### Running the Application
1. Run the application using Visual Studio or the .NET CLI: dotnet run --project path/to/DasofWebApp.csproj
2. Once running, the application will be available at `http://localhost:5000` by default.

## Usage

To calculate the vehicle price, make a POST request to `/api/vehicleprice/calculate` with a JSON payload containing the vehicle pricing details.

### Request Example

Content-Type: application/json
```json
{
  "vat": 20,
  "basePriceNet": 10000,
  "basePriceGross": 12000,
  "additionalEquipmentPriceNet": 2000,
  "additionalEquipmentPriceGross": 2400
}
```
### Response Example
```json
{
  "basePriceNet": 10000,
  "basePriceGross": 12000,
  "additionalEquipmentPriceNet": 2000,
  "additionalEquipmentPriceGross": 2400,
  "totalPriceNet": 12000,
  "totalPriceGross": 14400
}
```


