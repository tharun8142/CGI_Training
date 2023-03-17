## Problem Statement: Calculate total StockValue of the stock available in a Furniture Shop.

**This program simulate the stock management of a Furniture Shop. This shop deals with only two type of Furnitures BookShelf and DiningTable only. The program should accept details any 5 furnitures(each can be either BookShelf or DiningTable), the program should show a menu that allow the user to select choice of Furniture. After accepting the required no of Furniture details program will show accepted details and TotalCost of Accepted Stock**

**This exercise contains a base class named Furniture to hold the common properties of all type of Furnitures, and BookShelf and DiningTable class as child class with additional properties relevant to child classes. Program class has below functions**

     +AddToStock(Furniture []) : int
         - Should accept the required no of Furnitures and store to array by calling Accept method.
         - Should return total no of Furniture details accepted.

------------------------------------------------------
     +TotalStockValue(Furniture []) : double
         - Should take arrray of Furniture objects are parameter
         - Calculate total stockvalue of all furnitures in the array
         - Should return percentage total stockvalue as double

------------------------------------------------------

      +ShowStockDetails(Furniture []) : int
         - Should take arrray of Furniture objects are parameter
         - Should display the Furniture details available by calling Display method

------------------------------------------------------

The program should also contain definitions for  class types as suggested below:

      +Furniture : class
         - Should contain properties such as Height,Widthe,Color,Qty,Price 
         - Accept method to Accept Common Furniture details 
-------------------------------------------------------

      + BookShelf : class
         - Child class of Furniture with additional NoOfShelves Property
         - Should declare Accept and Display function to Read Additional Property

--------------------------------------------------------
      + DiningTable : class
         - Child class of Furniture with additional NoOfLegs Property
         - Should declare Accept and Display function to Read Additional Property

--------------------------------------------------------
## Instructions

- Avoid printing unnecessary values
- Take care of whitespace/trailing whitespace
- Do not change the provided class/method names unless instructed
- Follow best practices while coding
- Regularly push code to git
- Submit to [Hobbes](https:\\hobbes-cgi.stackroute.in) for automated testing