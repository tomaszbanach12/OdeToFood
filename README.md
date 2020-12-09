# ✓ OdeToFood
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
### For publish without entire runtime, type:
PS [PATH]\OdeToFood\OdeToFood> dotnet publish -o [PATH]\OdeToFoodPublished

### For self contained publish which include entire runtime, type:
PS [PATH]\OdeToFood\OdeToFood> dotnet publish -o [PATH]\OdeToFoodPublished --self-contained -r win-x64

## Running the application:
### For local run, type:
PS [PATH]\OdeToFoodPublished> & OdeToFood.exe

### For IIS run:
## [Internet Information Services (IIS) Manager] Setup

## For install aspNetCoreModule: run CMD as administrator and type:
[PATH]\System32\inetsrv appcmd.exe install module /name:AspNetCoreModule /image: [PATH]\Windows\system32\inetsrv\aspnetcore.dll

## For install aspNetCoreModuleV2 run CMD as administrator and type:
[PATH]\System32\inetsrv>appcmd.exe install module /name:AspNetCoreModuleV2 /image: [PATH]\ProgramFiles\IISExpress\Asp.NetCoreModule\V2\aspnetcorev2.dll

## For show [Internet Information Services (IIS) Manager] in [Control Panel] go to:
[Start] -> type: [Windows Features] -> mark [Internet Information Services (IIS) Manager]

## For add Website in [Internet Information Services (IIS) Manager] go to:
[Control Panel] -> [Administrative Tools] -> [Internet Information Services (IIS) Manager] -> Expand [Desktop] -> Right Click on [Sites] -> [Add Website...]
[Site name]: OdeToFood
[Physical path]: [PATH]\OdeToFoodPublished
[Type: https]
[IP adress]: All Unassigned
[Port]: 443
[SSL certificate]: IIS Express Development Certificate
[Start Website Immediately]: Yes
Click [OK]

## [Microsoft SQL Server Managment Studio (SSMS)] Setup

Connect to server in [Microsoft SQL Server Managment Studio (SSMS)]
Expand Server -> Expand [Security] -> Right Click on [Logins] -> [New Login...] -> [General]
[Login name]: ISS AppPool\OdeToFood
[Server Roles] -> 
[Server roles] mark: [dbcreator] and [public]

