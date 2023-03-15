#CptS 451 - Spring 2022
# https://www.psycopg.org/docs/usage.html#query-parameters

#  if psycopg2 is not installed, install it using pip installer :  pip install psycopg2  (or pip3 install psycopg2) 
import json
import psycopg2

def cleanStr4SQL(s):
    return s.replace("'","`").replace("\n"," ")

def int2BoolStr (value):
    if value == 0:
        return 'False'
    else:
        return 'True'

def dropAllData(conStr):
    try:
        conn = psycopg2.connect(conStr)
    except:
        print('Unable to connect to the database!')
    cur = conn.cursor()

    try:
        cur.execute("delete from friend")
        conn.commit()
        print("friend data is dropped")

        cur.execute("delete from categories")
        conn.commit()
        print("categories data is dropped")

        cur.execute("delete from tip")
        conn.commit()
        print("tip data is dropped")

        cur.execute("delete from attributes")
        conn.commit()
        print("attribute data is dropped")

        cur.execute("delete from checkins")
        conn.commit()
        print("checkins data is dropped")

        cur.execute("delete from hours")
        conn.commit()
        print("hours data is dropped")

        cur.execute("delete from business")
        conn.commit()
        print("business data is dropped") 

        cur.execute("delete from users")
        conn.commit()
        print("users data is dropped")
    except Exception as e:
        print("Drop data failed!",e)

    cur.close()
    conn.close()


def insert2Business(conStr):
    #reading the JSON file
    with open('./yelp_business.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            try:
                cur.execute("INSERT INTO business (business_id, name, address, state, city, zipcode, latitude, longitude, stars, numCheckins, numTips, is_open)"
                       + " VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s)", 
                         (data['business_id'],cleanStr4SQL(data["name"]), cleanStr4SQL(data["address"]), data["state"], data["city"], data["postal_code"], data["latitude"], data["longitude"], data["stars"], 0 , 0 , [False,True][data["is_open"]] ) )              
            except Exception as e:
                print("Insert to business failed!",e)
                break
            conn.commit()

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("Business", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Users(conStr):
    #reading the JSON file
    with open('./yelp_user.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            try:
                tipcount = 0
                if ("tipcount" in data.keys()):
                    tipcount = data["tipcount"]
                cur.execute("INSERT INTO users (user_id, name, average_stars, fans, cool, tipcount, funny, totallikes, lat, long)"
                       + " VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s)", 
                         (data['user_id'],cleanStr4SQL(data["name"]), data["average_stars"], data["fans"], data["cool"], tipcount, data["funny"], 0, 0 , 0 ) )              
            except Exception as e:
                print("Insert to users failed!", e, data, count_line)
                break
            conn.commit()

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("User", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Friend(conStr):
    #reading the JSON file
    with open('./yelp_user.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            try:
                data = json.loads(line)
                friends = data["friends"]
                for friend in friends:
                    cur.execute("INSERT INTO friend (friend_of, friend_for)"
                        + " VALUES (%s, %s)", 
                            (data['user_id'], friend)  )          
                    conn.commit()
            except Exception as e:
                print("Insert to friend failed!", e, data, count_line)
                break

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("Friend", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Tip(conStr):
    #reading the JSON file
    with open('./yelp_tip.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            try:
                cur.execute("INSERT INTO tip (business_id, tipDate, likes, tipText, user_id)"
                       + " VALUES (%s, %s, %s, %s, %s)", 
                         (data['business_id'], data["date"], data["likes"], cleanStr4SQL(data["text"]), data["user_id"] ) )          
            except Exception as e:
                print("Insert to tip failed!", e, data, count_line)
                break
            conn.commit()

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("Tip", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Categories(conStr):
    #reading the JSON file
    with open('./yelp_business.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            categories = data['categories'].split(", ")
            for category in categories:
                try:
                    cur.execute("INSERT INTO categories (category_name, business_id)"
                        + " VALUES (%s, %s)", 
                            (category, data["business_id"]) )              
                except Exception as e:
                    print("Insert to categories failed!", e, count_line)
                    return
                conn.commit()

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("Categories", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Attributes(conStr):
    def flattenAttributes(y):
        out = []
        def flatten(x, name=''):
            if type(x) is dict:
                for a in x:
                    flatten(x[a], a)
            else:
                out.append(tuple((name, x)))
        flatten(y)
        return out

    #reading the JSON file
    with open('./yelp_business.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            attributes = dict(flattenAttributes(data['attributes']))
            for attribute, value in attributes.items(): 
                try:
                    cur.execute("INSERT INTO attributes (attr_name, value, business_id)"
                        + " VALUES (%s, %s, %s)", 
                            (attribute, value, data["business_id"]) )              
                except Exception as e:
                    print("Insert to attributes failed!", e, count_line)
                    return
                conn.commit()

            line = f.readline()
            count_line += 1

            if (count_line % 1000 == 0):
                print("Attributes", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Hours(conStr):
    #reading the JSON file
    with open('./yelp_business.JSON','r') as f:
        line = f.readline()
        count_line = 0

        #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            hours = data['hours']
            for day, idx in hours.items():
                try:
                    times = hours[day].split('-')
                    cur.execute("INSERT INTO hours (dayofweek, open, close, business_id)"
                        + " VALUES (%s, %s, %s, %s)", 
                            (day, times[0], times[1], data["business_id"]) )              
                except Exception as e:
                    print("Insert to hours failed!", e, count_line)
                    return
                conn.commit()

            line = f.readline()
            count_line +=1

            if (count_line % 1000 == 0):
                print("Hours", count_line)

        cur.close()
        conn.close()

    print(count_line)
    f.close()

def insert2Checkins(conStr):
    #Sam's function
     with open('./yelp_checkin.JSON','r') as f:
        line = f.readline()
        count_line = 0

    #connect to yelpdb database on postgres server using psycopg2
        try:
            conn = psycopg2.connect(conStr)
        except:
            print('Unable to connect to the database!')
        cur = conn.cursor()

        while line:
            data = json.loads(line)
            checkin_date = data['date'].split(", ")
            for checkin in checkin_date:
                try:
                    cur.execute("INSERT INTO checkins (year, month, day, time, business_id)"
                        + " VALUES (%s, %s, %s, %s, %s)", 
                            (checkin[0:4], checkin[5:7], checkin[8:10], checkin[11:19], data["business_id"]))              
                except Exception as e:
                    print("Insert to Checkins failed!", e, count_line)
                    return
                conn.commit()

            line = f.readline()
            count_line +=1

            if(count_line % 1000 == 0):
                print("Checkins", count_line)

        cur.close()
        conn.close()
    
     print(count_line)
     f.close()

def insert2Table():
    #TODO: update the database name, username, and password
    conStr = "dbname='tempyelp' user='postgres' host='localhost' password=''"
    dropAllData(conStr)
    insert2Business(conStr)
    insert2Users(conStr)
    insert2Friend(conStr)
    insert2Tip(conStr)
    insert2Categories(conStr)
    insert2Attributes(conStr)
    insert2Hours(conStr)
    insert2Checkins(conStr)

insert2Table()