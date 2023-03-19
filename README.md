Excel to SQL Import Wizard
Standard Operating Procedure (SOP)
Date: 2023-03-19
Revision: 1.1

Title
Update any MS SQL database and any table with the Excel to SQL Import Wizard .NET Forms Application

Author
Elijah D Brown, Full System Developer, AuNyx LLC

Objective
To provide a step-by-step guide for end users to update any SQL table in any SQL database.

Pre-requisites
1.	The end user should have access to the application.
2.	The end user should be familiar with Excel.
3.	The end user should be supplied with the following details:
a.	Server Instance Name
b.	Database Name
c.	Basic SQL Username and Password (Read and Write Permissions)
d.	Target SQL Table Name
e.	Target SQL Table Fields and Data Types
	

 
Procedure

1.	Launch the Excel to SQL Import Wizard application.

2.	Enter the following SQL Database Connection Settings in the corresponding text boxes:

Server Name: 127.0.0.1\SQLEXPRESS
Database Name: Database01
Username: Application
Password: sql12345$

3.	Click on the 'Save' button underneath the ‘Server Name’ text box to save these settings. Your settings will be saved by the application.

4.	Enter the following SQL Table Settings in the corresponding text boxes:

Table Name: Table01
Columns:
IndexNumber, Bigint;
Name, NVarChar;
Value, Float;
TimeStamp, Datetime2;
Validation, Bit[];

Note: NVarChar corresponds to Excel cells containing text, Float corresponds to cells containing decimal numbers, and Bigint corresponds to cells containing integers. Both the column names and the sequence of the columns in the Excel spreadsheet must match the table in the SQL database.

5.	Click on the 'Save' button underneath the ‘Columns’ text box to save these settings. Your settings will be saved by the application.

6.	Prepare the Excel file to be imported:
Ensure that the Excel file's columns match the BorderStylesParent table in both name and sequence.

Note: The first column is almost always a Primary Key and cannot be blank (null). Each row must have a unique value. Format the cells in your Excel spreadsheet to match the corresponding SQL data types (e.g., text for NVarChar, decimal for Float, integer for Int, etc.)

7.	Click on the 'Select File’ Button to open the File Explorer Dialog and choose the Excel file to import. The File Path Label will be displayed next to the ‘Select File’ button.

8.	Click on the 'Upload’ Button to upload the data from the selected Excel file to the BorderStylesParent table in the High Point, NC  AAC_Emulator database.

Note: The system will open a dialog box after the Upload button has been pressed. Larger data sets will take longer to import (the time out will expire after 60 seconds). If the data was successfully written to the SQL database, then a confirmation message will be displayed. If the operation encounters a problem, then an error message will be displayed.
