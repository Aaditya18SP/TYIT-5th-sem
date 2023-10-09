from pymongo import MongoClient
import pprint
import datetime

client=MongoClient('localhost',27017)

db=client.cars_db

dblist=client.list_database_names()
if "cars_db" in dblist:
    print(" db present")
else:
    print("db not present")


cars_coll=db.cars

coll_list=db.list_collection_names()
if "cars" in coll_list:
    print("collection present")
else:
    print("collection not present")


cars_coll=db.cars
########################## FIND #######################

print("######## Printing all Documents #########")
for docs in cars_coll.find():
    print(docs)

print()
print()

print("######### Printing single document #######")
pprint.pprint(cars_coll.find_one({"brand":"Porsche"}))

print()
print()

########################## INSERT #######################
print("######### INSERTING single document #######")

new_car={
    "_id":1010,
    "brand":"McLaren",
    "model":"P1",
    "top_speed":230,
    "hp":963,
    "release_date":str(datetime.datetime.now),
    "type":"hypercar"
    }

#inserted_id= cars_coll.insert_one(new_car).inserted_id

#print("the id of document inserted : ", inserted_id)

print()
print()

print("######### INSERTING MULTIPLE DOCUMENTS #######")
new_cars_array=[{
    "_id":1011,
    "brand":"McLaren",
    "model":"765LT",
    "top_speed":230,
    "hp":750,
    "release_date":str(datetime.datetime.now),
    "type":"supercar"
    },
    {
        "_id":1012,
        "brand":"McLaren",
        "model":"F1",
        "top_speed":250,
        "hp":680,
        "release_date":str("1995-10-24"),
        "type":"hypercar"
    }
    ]

#inserted_ids=cars_coll.insert_many(new_cars_array).inserted_ids

#print("the ids of documents inserted : ", inserted_ids)

print()
print()
########################## UPDATE #######################
print("######### UPDATING SINGLE document #######")

find_part={"brand":"Porsche"}
update_query={"$set":{"type":"sportscar"}}
cars_coll.update_one(find_part,update_query)

print()
print()

print("######### UPDATING MULTIPLE document #######")

find_part={}
update_query={"$set":{"price":1000000}}
updated_docs=cars_coll.update_many(find_part,update_query)

print("number of docs updated:" ,updated_docs.modified_count)

print()
print()

print("######### UNSETTING - UPDATING MULTIPLE document #######")
find_part={}
update_query={"$unset":{"price":""}}

updated_docs=cars_coll.update_many(find_part,update_query)
print("number of docs updated:" ,updated_docs.modified_count)

print()
print()


########################## DELETE #######################
print("######### DELETING SINGLE document #######")
find_part={"model":"GT3"}

cars_coll.delete_one(find_part)
print()
print()

print("######### DELETING MULTIPLE document #######")
find_part={"brand":"Porsche"}
deleted_docs=cars_coll.delete_many(find_part)

print("deleted docs: ", deleted_docs.deleted_count)
print()
print()


'''

OUTPUT

 db present
collection present
######## Printing all Documents #########
{'_id': 1001, 'brand': 'Aston Martin', 'model': 'Valkyrie', 'hp': 1000, 'top_speed': 220, 'release_date': datetime.datetime(2022, 11, 16, 0, 0)}
{'_id': 1002, 'brand': 'Aston Martin', 'model': 'Valkyrie AMR PRO', 'hp': 1100, 'top_speed': 210, 'release_date': datetime.datetime(2022, 12, 16, 0, 0)}
{'_id': 1003, 'brand': 'Rolls Royce', 'model': 'Ghost', 'hp': 600, 'top_speed': 170, 'release_date': datetime.datetime(2021, 6, 20, 0, 0), 'type': 'luxury sedan'}
{'_id': 1004, 'brand': 'Rolls Royce', 'model': 'Phantom', 'hp': 650, 'top_speed': 175, 'release_date': datetime.datetime(2024, 3, 23, 0, 0), 'type': 'luxury sedan'}
{'_id': 1005, 'brand': 'Bentley', 'model': 'Continental GT', 'hp': 650, 'top_speed': 175, 'release_date': datetime.datetime(2022, 5, 20, 0, 0), 'type': 'luxury sedan'}
{'_id': 1006, 'brand': 'Koenigsegg', 'model': 'Jesko', 'hp': 1600, 'release_date': datetime.datetime(2023, 5, 20, 0, 0), 'type': 'hypercar'}
{'_id': 1007, 'brand': 'Koenigsegg', 'model': 'Gemera', 'hp': 1300, 'release_date': datetime.datetime(2023, 5, 20, 0, 0), 'type': 'hypercar'}
{'_id': 1008, 'brand': 'Lamborghini', 'model': 'Revuelto', 'hp': 1000, 'top_speed': 211, 'release_date': datetime.datetime(2023, 6, 20, 0, 0), 'type': 'supercar'}
{'_id': 1009, 'brand': 'Lamborghini', 'model': 'Aventador SVJ', 'hp': 800, 'top_speed': 212, 'release_date': datetime.datetime(2020, 6, 20, 0, 0), 'type': 'supercar'}
{'_id': ObjectId('652450bae0d0fce69681c025'), 'brand': 'Pagani', 'model': 'Huayra R', 'hp': 700, 'top_speed': 220, 'colors': ['blue carbon', 'copper red', 'blue tdf'], 'release_date': '2023-08-18'}
{'_id': ObjectId('652450bae0d0fce69681c027'), 'brand': 'Ferrari', 'model': 'Daytona SP3', 'hp': 820, 'top_speed': 230, 'colors': ['rosso corsa', 'baby blue', 'rosso magma', 'blue NART'], 'release_date': '2022-06-08'}
{'_id': 1010, 'brand': 'McLaren', 'model': 'P1', 'top_speed': 230, 'hp': 963, 'release_date': '<built-in method now of type object at 0x00007FFF66B88980>', 'type': 'hypercar'}
{'_id': 1011, 'brand': 'McLaren', 'model': '765LT', 'top_speed': 230, 'hp': 750, 'release_date': '<built-in method now of type object at 0x00007FFF66B88980>', 'type': 'supercar'}
{'_id': 1012, 'brand': 'McLaren', 'model': 'F1', 'top_speed': 250, 'hp': 680, 'release_date': '1995-10-24', 'type': 'hypercar'}


######### Printing single document #######
None


######### INSERTING single document #######


######### INSERTING MULTIPLE DOCUMENTS #######


######### UPDATING SINGLE document #######


######### UPDATING MULTIPLE document #######
number of docs updated: 14


######### UNSETTING - UPDATING MULTIPLE document #######
number of docs updated: 14


######### DELETING SINGLE document #######


######### DELETING MULTIPLE document #######
deleted docs:  0




'''

