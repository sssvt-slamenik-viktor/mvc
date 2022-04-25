USE PetEShopDB;


CREATE TABLE PE_BOOK
(
  ID                    INT             IDENTITY(1,1)   NOT NULL,
  TITLE                 NVARCHAR(200)                   NOT NULL,
  PUBLISHED_IN          INT                             NOT NULL,

  CONSTRAINT PK_PE_BOOK  PRIMARY KEY ( ID )
);
