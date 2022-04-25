USE PetEShopDB;


CREATE TABLE PE_HOUSE
(
  ID                    INT             IDENTITY(1,1)   NOT NULL,
  DESCRIPTION           NVARCHAR(500)                   NOT NULL,
  WIDTH                 FLOAT                           NOT NULL,
  LENGTH                FLOAT                           NOT NULL,

  CONSTRAINT PK_PE_HOUSE  PRIMARY KEY ( ID )
);
