INSERT INTO `sheridanproject`.`customer`
(`uid`,
`FirstName`,
`LastName`,
`Address`,
`Phone`,
`Gender`,
`BirthDate`,
`EnName`,
`EnRelationship`,
`EnPhone`) 
VALUES 
(null,"Jackie","Huang","Somewhere","123123","Male","2016-05-02","Sam Smith","Friend","911");


INSERT INTO `sheridanproject`.`customer`
(`uid`,
`FirstName`,
`LastName`,
`Address`,
`Phone`,
`Gender`,
`BirthDate`,
`EnName`,
`EnRelationship`,
`EnPhone`) 
VALUES 
(null,"Obama","Barack","Whitehouse","4161102223","Male","1961-08-04","Michelle Obama","Spouse","4161122222");


INSERT INTO `sheridanproject`.`customer`
(`uid`,
`FirstName`,
`LastName`,
`Address`,
`Phone`,
`Gender`,
`BirthDate`,
`EnName`,
`EnRelationship`,
`EnPhone`) 
VALUES 
(null,"Gates","Bill","Microsoft HQ","511100022","Male","1955-10-28","Melinda Gates","Spouse","5222110023");


INSERT INTO `sheridanproject`.`flight`
(`flightID`,
`airline`,
`Departure`,
`Destination`,
`Duration`,
`flightDate`,
`flightTime`,
`availableSeats`,
`maxSeats`,
`status`)
VALUES
("1355","Air Canada","Toronto","Beijing","700","2016-08-07","17:32","200","250","Available");

INSERT INTO `sheridanproject`.`flight`
(`flightID`,
`airline`,
`Departure`,
`Destination`,
`Duration`,
`flightDate`,
`flightTime`,
`availableSeats`,
`maxSeats`,
`status`)
VALUES
("2500","Westjet","New York","Vancouver","500","2016-02-07","14:00","10","200","Completed");

INSERT INTO `sheridanproject`.`flight`
(`flightID`,
`airline`,
`Departure`,
`Destination`,
`Duration`,
`flightDate`,
`flightTime`,
`availableSeats`,
`maxSeats`,
`status`)
VALUES
("1322","Westjet","Washington","Toronto","320","2016-08-07","14:00","10","200","InProgress");

INSERT INTO `sheridanproject`.`flight`
(`flightID`,
`airline`,
`Departure`,
`Destination`,
`Duration`,
`flightDate`,
`flightTime`,
`availableSeats`,
`maxSeats`,
`status`)
VALUES
("3110","United Airline","Mexico City","Toronto","600","2016-05-02","05:30","30","220","Completed");

INSERT INTO `sheridanproject`.`flight`
(`flightID`,
`airline`,
`Departure`,
`Destination`,
`Duration`,
`flightDate`,
`flightTime`,
`availableSeats`,
`maxSeats`,
`status`)
VALUES
("2223","Air Canada","San Jose","Toronto","300","2016-08-09","15:45","150","250","Available");
