
CREATE TABLE DEPDTLS(EID INT PRIMARY KEY,ENAME VARCHAR(3))
INSERT INTO DEPDTLS(EID,ENAME)VALUES(1,'TV')
INSERT INTO DEPDTL(DEPID,DEPNAME)VALUES(2,'HR')
INSERT INTO DEPDTLS(EID,ENAME)VALUES(3,'MOBILE')

SELECT *FROM DEPDTL
CREATE TABLE EMPDTL(EID INT PRIMARY KEY,ENAME VARCHAR(25),ESAL INT, DEPID INT FOREIGN KEY (DEPID) REFERENCES DEPDTL(DEPID))

INSERT INTO DEPDTLS 
CREATE TABLE DEPDTL (
DEPID INT,
DEPNAME VARCHAR(25),
PRIMARY KEY(DEPID)
)