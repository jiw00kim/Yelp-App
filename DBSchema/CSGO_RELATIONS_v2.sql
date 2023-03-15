CREATE TABLE Users
(
    user_id VARCHAR,
    name VARCHAR,
    average_stars REAL NOT NULL,
    fans INTEGER NOT NULL,
    cool INTEGER NOT NULL,
    tipCount INTEGER,
    funny INTEGER,
    totalLikes INTEGER DEFAULT 0,
    lat REAL,
    long REAL,
    PRIMARY KEY (user_id)
);

CREATE TABLE Business
(
    business_id VARCHAR,
    name VARCHAR NOT NULL,
    city VARCHAR NOT NULL,
    state VARCHAR NOT NULL,
    zipcode CHAR(5) NOT NULL,
    latitude REAL NOT NULL,
    longitude REAL NOT NULL,
    address VARCHAR NOT NULL,
    numTips INT DEFAULT 0,
    numCheckins INT DEFAULT 0,
    is_open BOOLEAN NOT NULL,
    stars REAL NOT NULL,
    PRIMARY KEY (business_id)
);

CREATE TABLE Tip
(
    tipDate TIMESTAMP,
    tipText VARCHAR,
    likes INTEGER,
    -- foreign keys
    user_id VARCHAR,
    business_id VARCHAR,
    PRIMARY KEY (tipDate, user_id, business_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Friend
(
    friend_of VARCHAR,
    friend_for VARCHAR,
    PRIMARY KEY (friend_of, friend_for),
    FOREIGN KEY (friend_of) REFERENCES Users(user_id),
    FOREIGN KEY (friend_for) REFERENCES Users(user_id)
);

CREATE TABLE Categories
(
    category_name VARCHAR,
    business_id VARCHAR,
    PRIMARY KEY (category_name, business_id),
    FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Attributes
(
    attr_name VARCHAR,
    value VARCHAR NOT NULL,
    business_id VARCHAR,
    PRIMARY KEY (attr_name, business_id),
    FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Hours
(
    dayofweek VARCHAR,
    close TIME NOT NULL,
    open TIME NOT NULL,
    business_id VARCHAR,
    PRIMARY KEY (dayofweek, business_id),
    FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Checkins
(
    year INT,
    month INT,
    day INT,
    time TIME,
    business_id VARCHAR,
    PRIMARY KEY (year, month, day, time, business_id),
    FOREIGN KEY (business_id) REFERENCES Business(business_id)
);
