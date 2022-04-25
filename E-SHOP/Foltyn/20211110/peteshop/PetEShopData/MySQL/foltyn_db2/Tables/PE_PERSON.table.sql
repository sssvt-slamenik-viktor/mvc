USE foltyn_db2;


CREATE TABLE PE_PERSON
(
  ID                    INT             AUTO_INCREMENT  NOT NULL,
  NAME                  VARCHAR(200)                    NOT NULL,
  AGE                   INT                             NOT NULL,

  CONSTRAINT PK_PE_PERSON  PRIMARY KEY ( ID )
);
