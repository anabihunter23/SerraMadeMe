CREATE DATABASE EldenDatabase;
USE EldenDatabase;

CREATE TABLE Locations(
	LocationId INT NOT NULL,
    LocationName VARCHAR (1000) NOT NULL,
    DiscoveredCheck BOOLEAN NOT NULL DEFAULT '0',
    RecommendedLevel INT NOT NULL,
    PRIMARY KEY (LocationId)
);

CREATE TABLE Items(
	ItemId INT NOT NULL AUTO_INCREMENT,
    ItemName VARCHAR (1000) NOT NULL,
    FoundCheck BOOLEAN NOT NULL DEFAULT '0',
    PRIMARY KEY (ItemId)
);

ALTER TABLE Items ADD COLUMN LocationId INT;
ALTER TABLE Items ADD CONSTRAINT FK_ItemLocation FOREIGN KEY (LocationId) REFERENCES Locations(LocationId);

INSERT INTO Locations (LocationId, LocationName, DiscoveredCheck, RecommendedLevel) VALUES (1, 'Carian Study Hall', TRUE, 65);
INSERT INTO Locations (LocationId, LocationName, DiscoveredCheck, RecommendedLevel) VALUES (2, 'Volcano Manor', FALSE, 70);
INSERT INTO Items (ItemName, FoundCheck, LocationId) VALUES ('Carian Inverted Statue', TRUE, 1);
INSERT INTO Items (ItemName, FoundCheck, LocationId) VALUES ('Magma Blade', FALSE, 2);

