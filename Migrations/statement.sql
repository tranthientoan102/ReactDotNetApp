CREATE TABLE `Candidates` (
                              `id` int NOT NULL AUTO_INCREMENT,
                              `fullName` nvarchar(50) NULL,
                              `email` nvarchar(50) NULL,
                              `mobile` nvarchar(20) NULL,
                              `age` int NOT NULL,
                              `bloodGroup` nvarchar(5) NULL,
                              `address` nvarchar(100) NULL,
                              PRIMARY KEY (`id`)
);