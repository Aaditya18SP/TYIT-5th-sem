#START THE MONGOD AND MONGO from cmd
#pip install pymongo

from pymongo import MongoClient

# Ways to connect to the mongo database:
#1st way:
myclient=MongoClient("mongodb://localhost:27017/")

#2nd way: specify the host and port 
#myclient =MongoClient('localhost', 27017)

#attribute style to access the database
#Here the database is not created, only already created db can be accessed
db = myclient.lost_and_found_db
# Dictionary style to access the database: db=myclient["lost_and_found_db"]

#get  a list of database names as strings
dblist= myclient.list_database_names()
print(dblist)

#test whether the db exists
if "lost_and_found_db" in dblist:
    print("the database exists")

else:
    print("not in the list")


#access a collection
collection= db.reported_item
#dictionary style:  collection = db["reported_item"]

#test whether the collection exists
collist = db.list_collection_names()
if "reported_item" in collist:
  print("The collection exists.")
else:
    print("collection doesnt exist")

#INSERT A collection
