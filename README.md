# IntroToWinForms
This was to test how Github works with Visual Studio. It is great. Also, this is a project to introduce windows forms to anyone who is 
starting with windows forms.

Software Requirements to run this .sln file:
- Microsoft Windows XP
- Microsoft Visual Studio 2010
- SQL Server Management Studio (2005 or above)
- Please rename the connection strings as per your requirements.

Database Designs used:
use the following query to make the databse used in SQL Server Management Studio:

CREATE TABLE StudentDetail
(
ID int IDENTITY NOT NULL PRIMARY KEY,
Name varchar(50) NOT NULL,
DOB varchar(50) NOT NULL,
Email varchar(50) NOT NULL,
PhoneNo numeric(18,0) NOT NULL,
MobileNo numeric(18,0) NOT NULL,
TenthScore float NOT NULL,
TwelthScore float NOT NULL,
Qualification varchar(50) NOT NULL,
Gender char(1) NOT NULL
);
