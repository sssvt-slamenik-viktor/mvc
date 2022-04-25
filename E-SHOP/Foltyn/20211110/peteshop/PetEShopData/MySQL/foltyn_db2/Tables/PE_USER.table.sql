USE foltyn_db2;


CREATE TABLE PE_USER
(
  ID                    INT             AUTO_INCREMENT  NOT NULL,
  USERNAME              VARCHAR(50)                     NOT NULL,
  EMAIL                 VARCHAR(100)                    NOT NULL,

  CONSTRAINT PK_PE_USER  PRIMARY KEY (ID)
);
