# __OrderTrack__

#### __An application which a user can use to manage stylists currently hired and their current clients. October 9, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's tenth week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.

User Stories
  * As the salon owner, I need to be able to see a list of all stylists.
  * As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
  * As the salon owner, I need to add new stylists to our system when they are hired.
  * As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

## Project Objectives:

  * Do the database table and column names follow both the specific requirements for this project and general .NET naming conventions? [Completed]
  * Are the instructions for re-creating your database thorough and clear? [Completed]
  * Is there a one-to-many relationship set up correctly in the database? [Completed]
  * Is CREATE functionality included for one class and is CREATE and VIEW functionality included for the other class? [Completed]
  * Is Entity used for communication with the database? [Completed]
  * Have all of the standards from previous weeks been met? (See below) [Completed]
  * Does the project demonstrate understanding of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology? [Completed]
  * Is the project in a polished, portfolio-quality state? [Completed]
  * Was required functionality in place by the Friday deadline? [Completed]

## Previous Objectives

For reference, here are the previous weeks' objectives:
  * Project uses two or more controllers. [Completed]
  * GET and POST requests/responses are used successfully. [Completed]
  * MVC routes follow RESTful conventions. [Completed]
  * Logic is easy to understand. [Completed]
  * Build files are included in .gitignore file and are not be tracked by Git [Completed]
  * Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README). [Completed]

## Specs

  1.[x] Stylists can be created, with the properties of StylistName, StylistDescription, and StylistId.
    * Input:
    * Output:

  2.[x] Clients can be created, with the properties of ClientName, ClientDescription, StylistId, and ClientID.
    * Input:
    * Output:

  3.[x] The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming the user and providing them with a link to all stylists.
    * Input:
    * Output:

  4.[x] The Stylists page should contain a link to a form which can be used to add a new Stylist.
    * Input:
    * Output:

  5.[x] Clicking a Stylist's name will take you to a new page that will display all of that Stylist's details and clients.
    * Input:
    * Output:

  6.[x] On the Stylist details page, 
    * Input:
    * Output:

## Setup/Installation Requirements

* First, recreate the database schema by connecting to a local instance within MySql Workbench (instal information can be found here if you have not already done so https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Query and run the following in a new tab:
  * CREATE DATABASE `emme_buentiempo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;CREATE TABLE `clients` (
  `ClientID` int NOT NULL AUTO_INCREMENT,
  `ClientName` varchar(45) DEFAULT NULL,
  `ClientDetails` mediumtext,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`ClientID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `StylistName` varchar(255) DEFAULT NULL,
  `StylistDetails` mediumtext,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

Then, to run the application:
* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/HairSalon", then press enter_
* _locate and open directory on desktop named "HairSalon" with your console of choice_
* _If necessary, update the appsettings.json file with your personal mysql username/password:_
  * {"ConnectionStrings": {"DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid={YOUR USERNAME};pwd={YOUR USERNAME}"}
* _(in console) locate and move to the directory inside called OrderTrack_
* _(in console) run $dotnet restore_
* _(in console) run $dotnet build_
* _(in console) run $dotnet run_

## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.