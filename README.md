# AddressBookService
AddressBookService is a Asp.Net Core (v3.0) service for dealing with the management of address books.

## Getting started

This service is running on Asp.Net Core 3.0 therefore it is recommended to install the latest version of Entity Framework.

All the data is stored on your local SQL server (by default this is localhost). Once the program is run it will generate a database on the selected server called `myDataBase`. 

Please make sure you have the Windows [SQL Server](https://www.microsoft.com/en-gb/sql-server/sql-server-downloads) installed on your machine.

If you want to change any of this update the connection string within the `appsettings.json` file:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "SqlDbSettings": {
    "ConnectionString": "Server=localhost;Database=myDataBase;Trusted_Connection=True;"
  }
}
```

## Usage

Run the `AddressBookService` from visual studio or from a command line.

Go into [Postman](https://www.getpostman.com/) or a similar service and call the following endpoints:
 http://localhost:5000/api/addressBook
 https://localhost:5001/api/addressBook
