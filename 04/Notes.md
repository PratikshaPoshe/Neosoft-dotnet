# Introduction to Databases
## Information vs data
- Data is a raw and unorganized fact that required to be processed to make it meaningful. Data can be simple at the same time unorganized unless it is organized. Generally, data comprises facts, observations, perceptions numbers, characters, symbols, image, etc.
- Data is always interpreted, by a human or machine, to derive meaning. So, data is meaningless. Data contains numbers, statements, and characters in a raw form.
- Information is a set of data which is processed in a meaningful way according to the given requirement. 
- Information is processed, structured, or presented in a given context to make it meaningful and useful.
- It is processed data which includes data that possess context, relevance, and purpose. It also involves manipulation of raw data.

- **Data Storage** - File System and then database.
## Paradigm Shift from File System to DBMS
-  File System manages data using files in hard disk. Users are allowed to create, delete, and update the files according to their requirement.
-  Issues with this system:
   -  **Redundancy of data**: Data is said to be redundant if same data is copied at many places. If a student wants to change Phone number, he has to get it updated at various sections. Similarly, old records must be deleted from all sections representing that student.
    - **Inconsistency of Data**: Data is said to be inconsistent if multiple copies of same data does not match with each other. If Phone number is different in Accounts Section and Academics Section, it will be inconsistent. Inconsistency may be because of typing errors or not updating all copies of same data.
    - **Difficult Data Access**: A user should know the exact location of file to access data, so the process is very cumbersome and tedious. If user wants to search student hostel allotment number of a student from 10000 unsorted students’ records, how difficult it can be.
    - **Unauthorized Access**: File System may lead to unauthorized access to data. If a student gets access to file having his marks, he can change it in unauthorized way.
    - **No Concurrent Access**: The access of same data by multiple users at same time is known as concurrency. File system does not allow concurrency as data can be accessed by only one user at a time.
    - **No Backup and Recovery**: File system does not incorporate any backup and recovery of data if a file is lost or corrupted.
## What is a database?
- Database is a collection of inter-related data which helps in efficient retrieval, insertion and deletion of data from database and organizes the data in the form of tables, views, schemas, reports etc.  
## Database Management System: 
- The software which is used to manage database is called Database Management System (DBMS). For Example, Sql Server, MySQL, Oracle etc. are popular commercial DBMS used in different applications. 
- DBMS allows users the following tasks:
  - **Data Definition**: It helps in creation, modification and removal of definitions that define the organization of data in database.
  - **Data Updation**: It helps in insertion, modification and deletion of the actual data in the database.
  - **Data Retrieval**: It helps in retrieval of data from the database which can be used by applications for various purposes.
  - **User Administration**: It helps in registering and monitoring users, enforcing data security, monitoring performance, maintaining data integrity, dealing with concurrency control and recovering information corrupted by unexpected failure.
## Architecture of DBMS
- DBMS 3-tier architecture divides the complete system into three inter-related but independent modules.
- ![Phases of database development](https://github.com/Tech-Training-2021/Neosoft-dotnet/blob/main/04/Images/dbms-3tier.jpg)
    1. **Physical Level**: At the physical level, the information about the location of database objects in the data store is kept. Various users of DBMS are unaware of the locations of these objects.In simple terms,physical level of a database describes how the data is being stored in secondary storage devices like disks and tapes and also gives insights on additional storage details.
    2. **Conceptual Level**: At conceptual level, data is represented in the form of various database tables. For Example, STUDENT database may contain STUDENT and COURSE tables which will be visible to users but users are unaware of their storage.Also referred as logical schema,it describes what kind of data is to be stored in the database.
    3. **External Level**:  An external level specifies a view of the data in terms of conceptual level tables.  Each external level view is used to cater to the needs of a particular category of users. For Example, FACULTY of a university is interested in looking course details of students, STUDENTS are interested in looking at all details related to academics, accounts, courses and hostel details as well. So, different views can be generated for different users. The main focus of external level is data abstraction.
## Phases of database design
- Database designing for a real-world application starts from capturing the requirements to physical implementation using DBMS software which consists of following steps shown below:
  - **Gathering requirements**: understanding all the datapoints which needs to be stored for an application.
  - **Conceptual Design**: The requirements of database are captured using high level conceptual data model. For Example, the ER model is used for the conceptual design of the database.
  - **Logical Design**: Logical Design represents data in the form of relational model. ER diagram produced in the conceptual design phase is used to convert the data into the Relational Model.
  - **Physical Design**: In physical design, data in relational model is implemented using commercial DBMS like Sql Server, Oracle, DB2.

## What is a database model?
- A database model shows the logical structure of a database, including the relationships and constraints that determine how data can be stored and accessed. 
- Individual database models are designed based on the rules and concepts of whichever broader data model the designers adopt. Most data models can be represented by an accompanying database diagram
### [Types of database models](https://www.lucidchart.com/pages/database-diagram/database-models/#section_0)
- There are many kinds of data models. Some of the most common ones include:
   - Hierarchical database model
   - Relational model
   - Network model
   - Object-oriented database model
   - Entity-relationship model
   - Document model
   - Entity-attribute-value model
   - Star schema
   - The object-relational model, which combines the two that make up its name

- The most common model, the **relational model** sorts data into tables, also known as relations, each of which consists of columns and rows. 
  - Relational databases are typically written in Structured Query Language (SQL). The model was introduced by E.F. Codd in 1970. 
  - Each column lists an attribute of the entity in question, such as price, zip code, or birth date. Together, the attributes in a relation are called a **domain**. 
  - A particular attribute or combination of attributes is chosen as a primary key that can be referred to in other tables, when it’s called a **foreign key**.
  - Each row, also called a **tuple**, includes data about a specific instance of the entity in question, such as a particular employee.
  - The model also accounts for the types of relationships between those tables, including one-to-one, one-to-many, and many-to-many relationships.
  - Within the database, tables can be normalized, or brought to comply with normalization rules that make the database flexible, adaptable, and scalable. When normalized, each piece of data is atomic, or broken into the smallest useful pieces.

## Constraints:
1. Primary Key: Key attribute which uniquely distinguish between different records/tuples. Unique, not null.
2. Foreign Key: used for referencing. Map entities type or tabe into a relationship.
3. Not Null
4. Unique key
5. Default
6. Check 

## Types of Sql Queries
1. DDL - create, alter, drop, truncate
2. DML - insert, update, delete
3. DQL - select, filteration
4. DCL - grant, revoke

## [Sql Datatypes](https://docs.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver15)
- Numerics
  - Exact numerics - numeric, bit, smallint, tinyint, int, bigint, decimal, smallmoney, money
  - Approximate - float, real
- Character/Text 
  - character strings - char, varchar, text
  - Unicode character strings - nchar, nvarchar, ntext
  - Large value data types: varchar(max), and nvarchar(max)
  - Large object data types: text, ntext, image, varbinary(max), and xml
- Binary - binary, image, varbinary
- Date/Time - date, datetime, datetime2, smalldatetime, time

## References
- [ER Model](https://www.geeksforgeeks.org/introduction-of-er-model/)