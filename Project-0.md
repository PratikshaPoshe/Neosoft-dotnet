# project 0: store application

## functionality
* place orders to store locations for customers
* add a new customer
* search customers by name
* display details of an order
* display all order history of a store location
* display all order history of a customer
* input validation
* exception handling
* persistent data (XML or JSON or SQL); no products, prices, customers, etc. hardcoded in C#
* (optional: order history can be sorted by earliest, latest, cheapest, most expensive)
* (optional: get a suggested order for a customer based on his order history)
* (optional: save some or all data to disk in JSON format)
* (optional: load some or all data from disk)
* (optional: display some statistics based on order history)

## structure

### business logic
* class library
* contains all business logic
* contains domain classes (customer, order, store, product, etc.)
* documentation with `<summary>` XML comments (optional: `<params>` and `<return>`)
* has no dependency on UI or any input/output considerations

### user interface
* interactive console application
* has only display- and input-related code
* low-priority component, will be replaced when we move to project 1

### data access
* class library
* contains scaffolded EF DbContext
* contains data access logic but no business logic
* use repository pattern for separation of concerns

### test 
* at least 10 test methods
* use TDD for some of the application
* focus on unit testing business logic; testing the console app is very low priority

## object model
### customer
* has first name, last name, etc.
* (optional: has a default store location to order from)

### order
* has a store location
* has a customer
* has an order time (when the order was placed)
* can contain multiple product types in the same order
* rejects orders with unreasonably high product quantities
* must have some additional business rules

### location
* has an inventory
* inventory decreases when orders are accepted
* rejects orders that cannot be fulfilled with remaining inventory
* (optional: more than one inventory item decrements for a given product order, for at least one product)

### product

## technologies
* C#/.NET
* Entity Framework
* Azure SQL Database
* xUnit, NUnit, or MSTest

|# | Team Representative  | Team Members         | Store type       |
|--|----------------------|----------------------|------------------|
|1.|Shivam Gupta          |Saad Mansuri, Sana Haju, Pratiksha Poshe|Grocery Shop|
|2.|Harsh Chheda          |Kunal Patil, Hrushikesh Shinde, Yogesh Chaudhari|Book Store  |
|3.|Prachi Gaikwad        |Mayuri Kumbhar, Krunal Rane, Pranali Deore, Jaideep Sahu|Cake Store |
|4.|Himani Jain           |Emran, Vivek, Nikita, Anagha|Shoes Store|
|5.|Aman Sharma           |Mitali Jain, Ramya Guduru, Sushma | Pizza Store|
|6.|Samuel Joy            |Raj Bhosale,Lucky Pareekh,Kajal|Mobile Store|
|7.|Alfaiz Khan           | Anshul, Nomaan Pansare,Saif Khan| Book Store |
|8.|Maaria Khan           |Shivani Yogi, Shruti, Nivrutti|Beauty Products Store|
|9.|Akshay Pawar          |Shivani Goswami,Imam, Vishram, Romila|Aquarium Fish Store|
