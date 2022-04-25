USE foltyn_db2;


CREATE TABLE PE_HOUSE
(
  ID                    INT             AUTO_INCREMENT  NOT NULL,
  DESCRIPTION           VARCHAR(500)                    NOT NULL,
  WIDTH                 FLOAT                           NOT NULL,
  LENGTH                FLOAT                           NOT NULL,

  CONSTRAINT PK_PE_HOUSE  PRIMARY KEY ( ID )
);
