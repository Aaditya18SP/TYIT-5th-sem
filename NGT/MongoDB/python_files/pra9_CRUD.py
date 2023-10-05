#insert a collection
from pymongo import MongoClient

client = MongoClient('localhost', 27017)
db=client.adi_pythondb

######### Insert a single document##########
#a dictionary represents an object . The object is to be inserted
gt3= {"brand":"Porsche",
      "hp":500,
      "top_speed_in_mph":198,
      "colors":["red","green","blue"]
      }

#access the cars collection
cars_coll = db.cars

inserted_car_id= cars_coll.insert_one(gt3).inserted_id
print("Object id inserted:",inserted_car_id)

############## Insert multiple records ##################
jsonArray= [
    {
        "brand":"Porsche",
        "model":"GT3RS",
        "hp":520,
        "colors":["red","blue"],
        "top_speed":200
    },
    {
       "brand":"Ferrari",
        "model":"FXXK Evo",
        "hp":900,
       "colors":["red","blue"],
        "top_speed":250
    },
     {
       "brand":"Ferrari",
        "model":"812 Competitzione",
        "hp":830,
       "colors":["red","blue"],
        "top_speed":220
    }
    ]

cars_coll= db.cars
inserted_ids= cars_coll.insert_many(jsonArray).inserted_ids
print(inserted_ids)

########## Acess the documents in a collection ###############
#Access the documents in the collection
import pprint

print()
print()
print()
print("find one using pprint")
#find_one()
#here, assigning the query documents to variables and then passing it doesnt work
pprint.pprint (cars_coll.find_one({"brand" :"Porsche"},{"_id" :1,"brand":1,"model":1}))
print()
print()

print("find one without pprint")
print()
x=cars_coll.find_one()
print(x)

#find()
print()
print("find multiple documents")
find_part={}
fields_to_display={"brand":1,"model":1}
for documents in cars_coll.find(find_part,fields_to_display):
    print(documents)

############### Update single document #################

print()
print("Updating.....")
cars_coll = db.cars
update_query= { "$set" : {"top_speed_in_mph" : 1000 } }
find_part = {"brand": "Porsche" }
cars_coll.update_one(find_part, update_query)

for docs in cars_coll.find():
    print( docs)
    
############### Update multiple documents #################

print()
print("Updating multiple........")

cars_coll = db.cars
find_part= {"brand" :"Ferrari" }
update_query = { "$set" : { "engine" : "V12 NA" } }
cars_coll.update_many(find_part, update_query)

for doc in cars_coll.find():
    print(doc)

###################### Unset in update #################

print()
print("Unsetting ........")

cars_coll = db.cars
find_part = {"brand" : "Porsche" }
update_query = {"$unset": {"top_speed_in_mph": "" } }

update= cars_coll.update_many(find_part,update_query)

for doc in cars_coll.find():
    print(doc)
print()
print(update.modified_count, "documents updated")

############### Delete documents #################

#remove single doc
cars_coll=db.cars
find_part = {"top_speed" : 198}


print()
print("deleting one ........")
delete = cars_coll.delete_one(find_part)

for doc in cars_coll.find():
    print(doc)

print()
print(delete.deleted_count, "documents deleted")

#remove multiple docs
print()
print("deleting many........")
find_many_part={"model":"FXXK Evo"}
cars_coll.delete_many(find_many_part)

print()
print(delete.deleted_count, "documents deleted")

for doc in cars_coll.find():
    print(doc)
    

#remove all docs
cars_coll= db.cars
delete= cars_coll.delete_many({})

print()
print(delete.deleted_count,"docs deleted")


for doc in cars_coll.find():
    print(doc)



'''NOTES:
1. The database needs to have a collection in order to show up in the database list
2.
'''
