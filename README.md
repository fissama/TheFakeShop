# TheFakeShop
TheFakeShop is a sample open source e-commerce website
## Features
#### Anonymous user
- View all products
- View products by category
- View product detail
#### Signed-in user
- Rate & review product
#### Admin
- Modify products
- Modify categories
## Get the code
Clone the repository:
```git clone https://github.com/fissama/TheFakeShop.git```
## Setup
1. First, you must run the script **CreateDatabaseScript.sql** in *./src/TheFakeShop.Script*
2. Secondly, open **Package Manager Console** and run a below code:
	```Scaffold-DbContext "Server=localhost;Database=TheFakeShop;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -Force -OutputDir Models```
## Build
From the command line:
```cd TheFakeShop/src```
```dotnet run```
## Test

## Deploy
