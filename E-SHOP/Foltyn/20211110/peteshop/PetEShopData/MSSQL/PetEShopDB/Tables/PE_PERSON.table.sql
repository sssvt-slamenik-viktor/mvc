USE PetEShopDB;


CREATE TABLE PE_PERSON
(
  ID                    INT             IDENTITY(1,1)   NOT NULL,
  NAME                  NVARCHAR(200)                   NOT NULL,
  AGE                   INT                             NOT NULL,

  CONSTRAINT PK_PE_PERSON  PRIMARY KEY ( ID )
);
