DROP TABLE Ticket;
DROP TABLE Flight;
DROP TABLE Customer;

CREATE TABLE Customer(
	uid INT AUTO_INCREMENT,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	Phone VARCHAR(15) NOT NULL,
	Gender VARCHAR(10) NOT NULL,
	BirthDate VARCHAR(100) NOT NULL,
	EnName VARCHAR(255) NOT NULL,
	EnRelationship VARCHAR(255) NOT NULL,
	EnPhone VARCHAR(15) NOT NULL,
	CONSTRAINT pk_uid PRIMARY KEY ( uid )
);

CREATE TABLE Flight(
	flightID VARCHAR(10) NOT NULL,
	airline VARCHAR(255) NOT NULL,
	Departure VARCHAR(255) NOT NULL,
	Destination VARCHAR(255) NOT NULL,
	Duration INT NOT NULL,
	flightDate VARCHAR(100) NOT NULL,
	flightTime VARCHAR(100) NOT NULL,
	availableSeats INT CHECK(availableSeats < maxSeats),
	maxSeats INT CHECK(maxSeats > 0),
	status VARCHAR(10) NOT NULL,
	CONSTRAINT pk_flightID PRIMARY KEY ( flightID )
);

CREATE TABLE Ticket(
	uid INT,
	flightID VARCHAR(10) NOT NULL,
	CONSTRAINT pk_Ticket PRIMARY KEY ( uid, flightID ),
	CONSTRAINT fk_uid FOREIGN KEY (uid) REFERENCES Customer(uid),
	CONSTRAINT fk_flightID FOREIGN KEY (flightID) REFERENCES Flight(flightID)
);