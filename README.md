# Factory

## About / Synopsis

* This project tracks a factories Engineers and Machines keeping track of which engineers are licensed to work on which machines.
* This project was created following Epicodus' Many to Many Database Independent Project's requirments.
* Project status: working
* Created by: Joseph Nilles



## Table of contents


> * [Title / Repository Name](#title--repository-name)
>   * [About / Synopsis](#about--synopsis)
>   * [Table of contents](#table-of-contents)
>   * [Installation](#installation)
>   * [Usage](#usage)
>     * [Screenshots](#screenshots)
>     * [Features](#features)
>   * [Code](#code)
>     * [Content](#content)
>     * [Requirements](#requirements)
>     * [Limitations](#limitations)
>     * [Build](#build)
>     * [Deploy (how to install build product)](#deploy-how-to-install-build-product)
>   * [Resources (Documentation and other links)](#resources-documentation-and-other-links)
>   * [Contributing / Reporting issues](#contributing--reporting-issues)
>   * [License](#license)
>   * [About Nuxeo](#about-nuxeo)

## Installation

* Clone the project from the repository at https://github.com/jbnilles/Factory
* Navigate to the project file and then into the folder `Factory`
* Create a file called `appsettings.json`
* In the `appsettings.json` file add the following
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=joseph_nilles;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* Replace `YOUR_PASSWORD` with you MySQL password
* Open a terminal and navigate to the `Factory` folder inside the project 
* In the terminal run `dotnet ef database update`
* In the terminal run `dotnet run`
* Open a web browser and go to http://localhost:5000/ 




## Usage
* When using this project you can add an engineer by either clicking on the new engineer button on the landing page or by navigating to the engineers page and clicking on the new engineers button from there. Similarly you can add a new Machine by clicking on the new machine button on the landing page or on the machine page. Once you have add either a machine or engineer you can view the details for an individual machine or engineer by clicking on the link of their name in the list on their respective pages(engineers page or Machines page). The Engineer page and Machine page each will list all of thier contents in alphabetical order by their names. When you are viewing the details of one object it will list either which machines they are licensed for or which engineers are licensed for the machine. You can add a license by clicking a button at the bottom of the list either link a Machine or link an engineer. If you click on remove from within the list it will remove the license of the machine/engineer to the selected engineer/machine. On the right of the details page it will show the details of your selection where you have buttons that will edit or delete your selection. 

## Screenshots
<img src="Factory/wwwroot/images/FactoryDbMap.png" width="500px">
<p>This is the sctructure of the MySQL</p>
<img src="Factory/wwwroot/images/Landing.png" width="500px">
<p>This is the Landing Page.</p>
<img src="Factory/wwwroot/images/EngineersIndex.png" width="500px">
<p>This is the Engineers Home Page.</p>
<img src="Factory/wwwroot/images/MachineDetails.png" width="500px">
<p>This is the Machine Details Page.</p>

### Features
* Add/Edit/Delete/View Engineers
* Add/Edit/Delete/View Machines
* Add/Edit/Delete/View Licenses(links between machines and Engineers)



### Bugs

* No known bugs

### To Do
