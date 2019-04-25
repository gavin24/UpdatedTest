# ReadMe

# Technologies
This project uses:
-Visual studio 2017
-.net framework 4.6.1
-mvc
-entity framework
-microsoft asp.net web api
-Cors has been enabled.

# Sql Server - Section 1
Created an mdf database in the App_Data folder.

Created an ado data enity model from the database in the models folder.

Scripts for the database are in the SQL folder inside the root folder of the project.

The Primary key is set to auto-increment.

TopLevelNode - The orignal node underneath the Home item that the current item derives from will be the TopLevelNode ID.

ItemLevel - The value of the level in the hierarchy the item is.

ItemOrder - The position of which the item should be sitting under its parent item.

ParentId - The id of the node directly about the current item in the hierarchy;


# Web Api - Section 2
Created A web api controller called "MenuItemsController"
GetMenuItems returns a list of the "MenuItems" Model from the database.

The methods will get a menu item by its id or by the item title.
The retrieved menu item will be used to search the menu table for all items that have their TopLevelNode column value as the same as the retrieved menu item ID.

This is put in a List of Menu item objects which is then serialized into JSON and returned to the client.
