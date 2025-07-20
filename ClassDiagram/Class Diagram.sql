CREATE TABLE `Class` (
  `Id` integer PRIMARY KEY,
  `Name` varchar(255),
  `X` integer,
  `Y` integer,
  `Width` integer,
  `Height` integer
);

CREATE TABLE `Attribute` (
  `Id` integer PRIMARY KEY,
  `ClassId` integer,
  `Modificator` char,
  `Name` varchar(255),
  `DataType` varchar(255)
);

CREATE TABLE `Operation` (
  `Id` integer PRIMARY KEY,
  `ClassId` integer,
  `Modificator` char,
  `Name` varchar(255),
  `ReturnDataType` varchar(255)
);

CREATE TABLE `OperationAttribute` (
  `Id` integer PRIMARY KEY,
  `OperationId` integer,
  `Name` varchar(255),
  `DataType` varchar(255)
);

ALTER TABLE `Attribute` ADD FOREIGN KEY (`ClassId`) REFERENCES `Class` (`Id`);

ALTER TABLE `Operation` ADD FOREIGN KEY (`ClassId`) REFERENCES `Class` (`Id`);

ALTER TABLE `OperationAttribute` ADD FOREIGN KEY (`OperationId`) REFERENCES `Operation` (`Id`);
