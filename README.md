# _Epicodus Pierrie Bakery_

#### _Epicodus Week 8 Code Review Project_

#### By _**KhanSahab**_

## Description

_Bakery Project when run first welcomes the customer and than proceeds to take Loaves and Pastry orders in a sequence. After the completion of the order it Provides the customer with order price and further prompts the customer if the customer wants to make the second order. If yes, it takes the second round of Loaves and Pastry order and calculates the grand total Price for both the orders._

## Setup/Installation Requirements

* Clone this repository.
* dotnet build &
* dotnet run


## Known Bugs

None so far

## Support and contact details

_Have a bug or an issue with this application? email post_khan@Yahoo.com_

## Technologies Used

* uses auto-implemented properties.
* Classes with namespace.
* C# Console UI 
* Methods that calculate price in the class
* Some code of UI pushed to back end classes to keep the code Dry
* Refactoring to make the code shorter and more effective with each iteration.
* Dictionary to keep track of the first order by the customer

## Technical Specs
### Bread is for 5 dollars. If customer wants more than two, Each set of two Loaves comes with one extra bread.
### Pastries are $2 a piece. If customer orders 3 or more, each pastry is float (5/3) = $1.66666



### User specs in Steps
* 1- User is welcomed and introduced with Loaves price and promotion and asked to input number of loaves he wants.
* 2- Total price of loaves is displayed after the User inputs number of loaves he wants
* 3- User is displayed with the promotion and price of Pastries and prompted to input the number of pastries wanted.
* 4- Customer is shown the total price of the pastries and the combined Order price of both Loaves and Pastries.
* 5- Customer is prompted to input "y" if he wants to place another order.
* 6- Steps 2 - 4 are repeated and he is shown the Grand Total Price of Both the orders.
* 7- He is given a bye bye if he doesn't want another order.
### License

This software is licensed under the Epicodus inc license.

Copyright (c) 2020 **_Khan Sahab_**