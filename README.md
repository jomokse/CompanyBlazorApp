# CompanyBlazorApp

**CompanyBlazorApp** is a Blazor WebAssembly demo application that allows users to search for Finnish company information using their Business ID (Y-tunnus). The data is fetched from the [PRH Open Data API](https://avoindata.prh.fi/opendata-ytj-api/).

> ⚠️ The application user interface (UI) is in **Finnish**.

## Features

- Enter a Finnish Business ID to search for company data.
- Fetches data from the official PRH open data API.
- Displays company name, address, website, and other basic details.
- Uses structured Razor components for clean UI rendering.
- Built using .NET 8 and Blazor WebAssembly.

## Technologies

- Blazor WebAssembly (.NET 8)
- HTTP Client & `System.Net.Http.Json`
- PRH Open Data API (`https://avoindata.prh.fi`)
- C# 12
- Visual Studio Code

## Running the App

1. Clone this repository:
   git clone https://github.com/jomokse/CompanyBlazorApp.git
   cd CompanyBlazorApp

2. Run the application:

   dotnet run

3. Open your browser and go to:

   https://localhost:5001

## License

This project is for demonstration purposes and is provided as-is without any warranty.
