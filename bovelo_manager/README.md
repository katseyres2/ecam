

# BOVELO Project

![set text](https://i.imgur.com/Vq0UU1Q.png)

Bovélo is a fictive company that produces and delivers different customizable bikes. This project includes two applications, one for managing client order and the other for production and stock management. 

`BoveloInternal` allows the manager to control and order parts stock and add new bikes to the current stock. The bike fitter can also use this application to see the production planning, validate an assembled bike when it is ready and reports broken bike parts. 

`BoveloClient` enables the company to make orders for its client with customizable bikes. It features client management and allows to register new clients to the company database.

## Installation
For users, you can run the `BoveloSetup.exe` file included in the repository to install both applications on your local machine. It runs on **Windows 10 32/64 bits** systems and requires [**.NET Framework 4.7.2 Runtime**](https://dotnet.microsoft.com/download/dotnet-framework/net472).

# For Developers

The database structure is based on MySql and here is the included [Database Diagram](https://github.com/smarbal/bovelo_manager/issues/8#issuecomment-817109381).  

Further UML diagrams are listed below:
- [The Activity Diagram](https://lucid.app/documents/embeddedchart/9a903477-747d-4a87-b3f7-fb47c50f605c)
- [The Use Case Diagram](https://app.lucidchart.com/documents/image/a46ee63b-3627-4046-a257-9277f3b090aa/0/1000/1)  
- [The Sequence Diagram](https://app.lucidchart.com/documents/image/570fe02b-57dd-400f-bd7d-0c7af648c352/0/1000/1)  
- [The Class Diagram](https://lucid.app/documents/embeddedchart/c6953fb9-22ae-4676-a6b1-a276b2a08189)  
- [The Supplier Order Sequence Diagram](https://lucid.app/documents/embeddedchart/9d8bd2ac-e7c2-4b73-9a76-d67fc0b0ff67)
- [The Fitter Sequence Diagram](https://lucid.app/documents/embeddedchart/98403bf0-496c-453e-b62d-8a8212890689)

## Prerequisites
### .NET Framework
Download and install [**.NET Framework 4.7.2 Developer Pack**](https://dotnet.microsoft.com/download/dotnet-framework/net472) for building and running C# applications.

### MySQL Connector/NET
Download and install [**MySQL Connector 8.0.23**](https://downloads.mysql.com/archives/c-net/) that provides useful tools for accessing the database in C# applications and add `MySql.Data` reference to BoveloLibrary if you have building issues.

## Database Import
You can find the backup file for the database on [**BoveloDatabase.sql**](https://github.com/smarbal/bovelo_manager/blob/main/Bovelo_Database.sql). The schema name is `bovelo`, just create it and use the backup in the "Import data" section in MySQL Workbench. 

## Run
Clone the repository in a local folder on your computer. Then create a new file named `Database.cs` in the `BoveloLibrary` folder and copy the following lines. 

```C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
public class Database
{
public string MyConnection = "server=XXX.XXX.XXX.XX;user=3BE-GRP5;database=bovelo;port=XXXXX;password=************";
}
}
```
You need to change the following values :

- IP_address
- Port
- Username
- Password
- Database_name

*Never share your information, it must remain confidential.*

Build the solution and select either the `BoveloInternal` or `BoveloClient` folder as the main project to run the specific application.  

# Developer Team

```text
Demarcin Louis [18090]
Denis Maximilien [18332]
Martinez Balbuena Sébastien [18360]
Mitrovic Nikola [18365]
Noël Logan [18003]
Penning Chloé [20264]
```
