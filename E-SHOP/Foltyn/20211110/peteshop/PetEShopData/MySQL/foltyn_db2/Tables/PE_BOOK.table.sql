USE foltyn_db2;


CREATE TABLE PE_BOOK
(
  ID                    INT             AUTO_INCREMENT  NOT NULL,
  TITLE                 VARCHAR(200)                    NOT NULL,
  PUBLISHED_IN          INT                             NOT NULL,

  CONSTRAINT PK_PE_BOOK  PRIMARY KEY ( ID )
);
