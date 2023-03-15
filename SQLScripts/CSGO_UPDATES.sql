-- Calculate and update the “numCheckins”, “numTips”, “totalLikes”, and “tipCount” attributes for 
-- each business. 

UPDATE Business
SET numCheckins = 
    (SELECT COUNT(day)
       FROM Business as b1 ,Checkins as c1
      WHERE b1.business_id = c1.business_id);

UPDATE Business
SET numTips = 
    (SELECT COUNT(tipText)
       FROM Business as b1, Tip as t1
      WHERE b1.business_id = t1.business_id);

UPDATE Users
SET tipCount = 
    (SELECT COUNT(tipText)
       FROM Users, Tip
      WHERE Users.user_id = Tip.user_id)

UPDATE Users
SET totalLikes =
    (SELECT SUM(likes)
       FROM Users, Tip
      WHERE Users.user_id = Tip.user_id)
    





