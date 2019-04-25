# ReadMe

# Technologies
Visual studio 2017
.net framework 4.6.1
asp.net mvc.
entity framework
microsoft asp.net web api
Cors enabled.

# Sql Server
Created an mdf database in the App_Data folder.
Created an ado data enity model from the database in the models folder.
Scripts for the database are in the SQL folder inside the root folder of the project.
The Primary key is set to auto-increment.
TopLevelNode - 
ItemLevel - 
ItemOrder - 
ParentId - 

# Code
Created A web api controller called "MenuItemsController"
GetMenuItems returns a list of the "MenuItems" Model from the database.
The methods will get a menu item by its id or by the item title.
The retrieved menu item will be used to search the menu table for all items that have their TopLevelNode column value as the same as the retrieved menu item ID.
This is put in a List of Menu item objects which is then serialized into JSON and returned to the client.
