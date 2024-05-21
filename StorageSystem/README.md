## Storage System

- this purpose of this project is to create a system that allows you to add track and find items that you have stored in the system. This should work
- by adding new items to the system and it quantity and then adding it to a given storage bin that has been created. A storage bin should be given a 
- number and a location making it easy to find the bin around the house.

# database

TABLES:
- Item
- StorageBin
- Location

CREATE TABLE Location (
id int pk,
name varchar
);

CREATE TABLE StorageBin(
bin_number int pk,
name varchar
locationId int fk location(id);
{maybe nfcUid when adding nfc tags}
)

CREATE TABLE ITEM (
id int pk,
name varchar,
quantity int,
storagebinId int fk storagebin(bin_number);
);



## TASKS

- setup database connection stuff
- create data models as cs classes
- code first migration to create classes
- controllers for each class
- create, delete, get all, get by id, update location
- create, delete, get all, get by id, update storage bin, also move storage_bin
- create, delete, get all, get by id, update item, also move item to new storage_bin

- add identity core with just one user type
- add custom endpoints for logging in and out with custom endpoints file
- protect all actions for authorised users only

