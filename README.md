# OdeToFood
## Running the application for the first time:

### For instal NPM, type in PowerShell:
PS [PATH]\OdeToFood\OdeToFood> npm install

### For creating a initial migrate data, type in PowerShell:
PS [PATH]\OdeToFood\OdeToFood.Data> dotnet ef migrations add initialcreate -s ..\OdeToFood\OdeToFood.csproj
 
### For migrate database schema becouse you add another properties to class Restaurant etc, type in PowerShell:
PS [PATH]\OdeToFood\OdeToFood.Data > dotnet ef database update -s ..\OdeToFood\OdeToFood.csproj

### For update EF Core tools version type in PowerShell:
PS [PATH]\OdeToFood\OdeToFood.Data> dotnet tool update --global dotnet-ef

## Publishing the application:
### For publish, type:
PS [PATH]\OdeToFood\OdeToFood> dotnet publish -o [PATH]\OdeToFoodPublished

### For self contained publish which include entire runtime, type:
PS [PATH]\OdeToFood\OdeToFood> dotnet publish -o [PATH]\OdeToFoodPublished --self-contained -r win-x64

## Run the application:
### For run, type:
PS [PATH]\OdeToFoodPublished> & OdeToFood.exe
