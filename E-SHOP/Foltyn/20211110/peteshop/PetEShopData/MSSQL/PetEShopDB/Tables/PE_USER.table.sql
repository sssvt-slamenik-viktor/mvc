USE PetEShopDB;


CREATE TABLE PE_USER
(
  ID                    INT             IDENTITY(1,1)   NOT NULL,
  USERNAME              VARCHAR(50)                     NOT NULL,
  EMAIL                 VARCHAR(100)                    NOT NULL,

  CONSTRAINT PK_PE_USER  PRIMARY KEY ( ID )
);
