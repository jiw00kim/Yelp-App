-- #1
-- Whenever a user provides a tip for a business, the “numTips” value for that business and the 
-- “tipCount” value for the user should be updated.
CREATE OR REPLACE FUNCTION updateNumTips() RETURNS trigger AS '
BEGIN 
    UPDATE business
    SET numtips = (SELECT COUNT(*) FROM tip WHERE business_id = NEW.business_id)
	WHERE business_id = NEW.business_id;
RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE TRIGGER tipCheck
AFTER INSERT ON tip
FOR EACH ROW
EXECUTE PROCEDURE updateNumTips();

-- #2
-- Similarly, when a customer checks-in a business, the “numCheckins” attribute value for that 
-- business should be updated. 
CREATE OR REPLACE FUNCTION updateNumCheckins() RETURNS trigger AS '
BEGIN 
    UPDATE business
    SET numcheckins = (SELECT COUNT(*) FROM checkins WHERE business_id = NEW.business_id)
    WHERE business_id = NEW.business_id;
RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE TRIGGER checkinCheck
AFTER INSERT ON checkins
FOR EACH ROW
EXECUTE PROCEDURE updateNumCheckins();

-- #3
-- When a user likes a tip, the “totalLikes” attribute value for the user who wrote that tip should be updated.
CREATE OR REPLACE FUNCTION updateTotalLikes() RETURNS trigger AS '
BEGIN 
    UPDATE users
    SET totallikes = (select SUM(likes) from tip where user_id = NEW.user_id)
    WHERE user_id = NEW.user_id;
RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE TRIGGER totallikesCheck
AFTER UPDATE OF likes ON tip
FOR EACH ROW
EXECUTE PROCEDURE updateTotalLikes();