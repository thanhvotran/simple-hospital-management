--------------CREATE DATABASE FOR ASS2----------------

--------------TranVoThanh---1552343------
USE ASSIGNMENT2
GO
CREATE TABLE DEPARTMENT
(
	DID INT NOT NULL,
	DTitle VARCHAR(30),
	PRIMARY KEY(DID)
)
GO


	
CREATE TABLE EMPLOYEE
(
	EID INT NOT NULL,
	EFName VARCHAR(15) NOT NULL,
	ELName VARCHAR(15) NOT NULL,
	EDoB DATE,
	EGenre VARCHAR(3),
	ESpeciality VARCHAR(30),
	EAddress VARCHAR(30),
	EStartDate DATE,
	PRIMARY KEY (EID),
	DID INT,
	CONSTRAINT FK_DID FOREIGN KEY (DID) REFERENCES dbo.DEPARTMENT(DID)
)
GO

CREATE TABLE EMP_Phone
(
	EID INT NOT NULL,
	EPhone INT NOT NULL,
	PRIMARY KEY(EID,EPhone),
	CONSTRAINT FK_EID FOREIGN KEY(EID) REFERENCES dbo.EMPLOYEE(EID)
)
GO

CREATE TABLE DOCTOR
(
	EID_Doc INT NOT NULL,
	PRIMARY KEY(EID_Doc),
	CONSTRAINT FK_EID_Doc FOREIGN KEY(EID_Doc) REFERENCES dbo.EMPLOYEE(EID)
)
GO

CREATE TABLE NURSE
(
	EID_Nur INT NOT NULL,
	PRIMARY KEY(EID_Nur),
	CONSTRAINT FK_EID_Nur FOREIGN KEY(EID_Nur) REFERENCES dbo.EMPLOYEE(EID)
)
GO

CREATE TABLE PATIENT
(
	PID INT NOT NULL,
	PFname VARCHAR(15),
	PLname VARCHAR(15),
	PDoB DATE,
	PGender VARCHAR(1),
	PPhone INT,
	PAddress VARCHAR(30),
	PGenre VARCHAR(3),
	PRIMARY KEY(PID)
)
GO




CREATE TABLE OUTPATIENT
(
	PID_Out INT NOT NULL,
	PRIMARY KEY(PID_Out),
	EID_Doc INT,
	CONSTRAINT FK_EID_Doc_Out FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	CONSTRAINT FK_PID_Out FOREIGN KEY (PID_Out) REFERENCES dbo.PATIENT(PID)
)
GO

CREATE TABLE INPATIENT
(
	PID_In INT NOT NULL,
	PAdmissionDate DATE,
	PDischargeDate DATE,
	PDiagnosis VARCHAR(30),
	PSickroom VARCHAR(10),
	PFee INT,
	EID_Doc INT,
	CONSTRAINT FK_EID_Doc_In FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	EID_Nur INT,
	CONSTRAINT FK_EID_Nur_In FOREIGN KEY (EID_Nur) REFERENCES dbo.NURSE(EID_Nur),
	PRIMARY KEY(PID_In),
	CONSTRAINT FK_PID_In FOREIGN KEY (PID_In) REFERENCES dbo.PATIENT(PID)

)
GO

CREATE TABLE EXAMINATION
(
	EID_Doc INT NOT NULL,
	PID_Out INT NOT NULL,
	ExID INT NOT NULL,
	ExDate DATE,
	ExFee INT,
	ExDiagnosis VARCHAR(30),
	ExSecondExaminationDate DATE,
	PRIMARY KEY(EID_Doc,PID_Out,ExID),
	CONSTRAINT FK_EID_Doc_Ex FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	CONSTRAINT FK_PID_Out_Ex FOREIGN KEY (PID_Out) REFERENCES dbo.OUTPATIENT(PID_Out)
)
GO

CREATE TABLE TREATMENT
(
	EID_Doc INT NOT NULL,
	PID_In INT NOT NULL,
	TrID INT NOT NULL,
	TrStart DATE,
	TrEnd DATE,
	TrResult DATE,
	PRIMARY KEY(EID_Doc,PID_In,TrID),
	CONSTRAINT FK_EID_Doc_Tr FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	CONSTRAINT FK_PID_Out_Tr FOREIGN KEY (PID_In) REFERENCES dbo.INPATIENT(PID_In)
)
GO

CREATE TABLE MEDICATION
(
	MID INT NOT NULL,
	MName VARCHAR(15),
	MEffects VARCHAR(15),
	MPrice INT,
	PRIMARY KEY(MID)
)
GO

CREATE TABLE Uses_Exam
(
	EID_Doc INT NOT NULL,
	PID_Out INT NOT NULL,
	ExID INT NOT NULL,
	MID INT NOT NULL,
	PRIMARY KEY(EID_Doc,PID_Out,ExID,MID),
	CONSTRAINT FK_EID_Doc_Uses_Ex FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	CONSTRAINT FK_PID_Out_Uses_Ex FOREIGN KEY (PID_Out) REFERENCES dbo.OUTPATIENT(PID_Out),
	CONSTRAINT FK_ExID_Uses_Ex FOREIGN KEY (EID_Doc,PID_Out,ExID) REFERENCES dbo.EXAMINATION(EID_Doc,PID_Out,ExID),
	CONSTRAINT FK_MID_Uses_Ex FOREIGN KEY (MID) REFERENCES dbo.MEDICATION(MID)
)
GO

CREATE TABLE Uses_Treat
(
	EID_Doc INT NOT NULL,
	PID_In INT NOT NULL,
	TrID INT NOT NULL,
	MID INT NOT NULL,
	PRIMARY KEY(EID_Doc,PID_In,TrID,MID),
	CONSTRAINT FK_EID_Doc_Uses_Tr FOREIGN KEY (EID_Doc) REFERENCES dbo.DOCTOR(EID_Doc),
	CONSTRAINT FK_PID_In_Uses_Tr FOREIGN KEY (PID_In) REFERENCES dbo.INPATIENT(PID_In),
	CONSTRAINT FK_TrID_Uses_Tr FOREIGN KEY (EID_Doc,PID_In,TrID) REFERENCES dbo.TREATMENT(EID_Doc,PID_In,TrID),
	CONSTRAINT FK_MID_Uses_Tr FOREIGN KEY (MID) REFERENCES dbo.MEDICATION(MID)
)
GO



-----------------------INSERT------------------

INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 1, 'Heart Center' ) ;
INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 2, 'Trauma & Emergency Center' ) ;
INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 3, 'Gastroenterology Center' ) ;
INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 4, 'Surgery' ) 
INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 5, 'Internal Medicine' ) ;
INSERT INTO dbo.DEPARTMENT ( DID, DTitle ) VALUES  ( 6, 'Other' ) ; 




INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1552343 , 'David' , 'Modric' ,'19920317', 'doc' ,'Cardiology' , '37 Green Street, London' , '20101102' , 1 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1553432 , 'Tran' , 'Modric' ,'19910208', 'doc' ,'Vascular Surgery' , '55 Grown Street, London' , '20141101' , 2 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550113 , 'Nguyen' , 'Anna' ,'19950703', 'nur' ,'Cardiology' , '22 Garden Street, London' , '20001202' , 3 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550114 , 'Lucar' , 'Messi' ,'19920317', 'nur' ,'Vascular Surgery' , '372 Pink Street, London' , '20150101' , 4 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550115 , 'Chiris' , 'Ronald' ,'19900317', 'doc' ,'Cardiothoracic Surgery' , '7 Black Street, London' , '20120303' , 5 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550116 , 'Le' , 'Mickey' ,'19910522', 'nur' ,'Cardiothoracic Surgery' , '31/2 Blue Street, London' , '20101102' , 6 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550117 , 'Lee' , 'Woo' ,'19960512', 'doc' ,'Vascular Surgery' , '30/2 Blue Street, London' , '20111102' , 1 );

INSERT INTO dbo.EMPLOYEE( EID , EFName ,ELName ,EDoB , EGenre ,ESpeciality , EAddress , EStartDate ,DID )
VALUES  ( 1550118 , 'Park' , 'Hi' ,'19810222', 'nur' ,'Cardiothoracic Surgery' , '111 Blue Street, London' , '20131202' , 1 );



INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1552343, 01653751769 );
INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1553432, 01653722212 );
INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1550113, 01653723231 );
INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1550114, 01653788821 );
INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1550115, 01624222114 );
INSERT INTO dbo.EMP_Phone ( EID, EPhone ) VALUES  ( 1550116, 01653837312 );

INSERT INTO dbo.DOCTOR ( EID_Doc ) VALUES  ( 1552343 );
INSERT INTO dbo.DOCTOR ( EID_Doc ) VALUES  ( 1553432 );
INSERT INTO dbo.DOCTOR ( EID_Doc ) VALUES  ( 1550115 );
INSERT INTO dbo.DOCTOR ( EID_Doc ) VALUES  ( 1550117 );

INSERT INTO dbo.NURSE ( EID_Nur ) VALUES  ( 1550116 );
INSERT INTO dbo.NURSE ( EID_Nur ) VALUES  ( 1550114 );
INSERT INTO dbo.NURSE ( EID_Nur ) VALUES  ( 1550113 );
INSERT INTO dbo.NURSE ( EID_Nur ) VALUES  ( 1550118 );

INSERT INTO dbo.PATIENT VALUES  ( 111 ,'Le' , 'Heo' , '19920211' , 'M' , 01232237311 , '22 Blue Street, Scotland','in');
INSERT INTO dbo.PATIENT VALUES  ( 112 ,'Richard' , 'Hii' , '19880521' , 'F' , 01132221131 , '32 Best Street, Highland','in');
INSERT INTO dbo.PATIENT VALUES  ( 113 ,'Yiang' , 'Xiao' , '19900215' , 'M' , 01242287911 , '222 Yasuo Street, Scotland','in');
INSERT INTO dbo.PATIENT VALUES  ( 114 ,'Bui' , 'Mi' , '19911211' , 'F' , 01233222211 , '221 Chicken Street, Proland','out');
INSERT INTO dbo.PATIENT VALUES  ( 115 ,'Nguyen' , 'Po' , '19820821' , 'M' , 01162223711 , '522 Lee Street, Sonda','out');
INSERT INTO dbo.PATIENT VALUES  ( 116 ,'Lee' , 'Hee' , '19940111' , 'M' , 01232232121 , '422 Blue Street, Summor','out');
INSERT INTO dbo.PATIENT VALUES  ( 117 ,'David' , 'Han' , '19930111' , 'F' , 01678232121 , '3 Under Street, Summor','out');
INSERT INTO dbo.PATIENT VALUES  ( 118 ,'Kim' , 'Hoo' , '19940215' , 'F' , 0932232121 , '2 Blue Street, Summor','in');
INSERT INTO dbo.PATIENT VALUES  ( 119 ,'Kim' , 'Tan' , '19941219' , 'M' , 0955552121 , '90 High Street, LeSummor','out');
INSERT INTO dbo.PATIENT VALUES  ( 120 ,'Pham' , 'Ly' , '19930715' , 'F' , 0922222622 , '112 Low Street, Ummor','out');
INSERT INTO dbo.PATIENT VALUES  ( 121 ,'Ly' , 'Ha' , '19910225' , 'M' , 0939990761 , '255 Medium Street, Ya','out');
INSERT INTO dbo.PATIENT VALUES  ( 122 ,'Son' , 'Goku' , '19900712' , 'F' , 0936565551 , '44 Blue Street, Lao','out');
INSERT INTO dbo.PATIENT VALUES  ( 123 ,'Ve' , 'Geta' , '19940711' , 'F' , 0936563331 , '33 Deep Street, Vietnam','in');
INSERT INTO dbo.PATIENT VALUES  ( 124 ,'Vo' , 'Tien' , '19930311' , 'M' , 0936562342 , '144 Under Street, Lao','in');
INSERT INTO dbo.PATIENT VALUES  ( 125 ,'Chan' , 'Kim' , '19920702' , 'F' , 0936561212 , '544 Bee Street, Campudia','in');
INSERT INTO dbo.PATIENT VALUES  ( 126 ,'Soo' , 'Goo' , '19890422' , 'M' , 0922265331 , '444 Boss Street, Thailand','in');
INSERT INTO dbo.PATIENT VALUES  ( 127 ,'Kimi' , 'Misu' , '19800511' , 'F' , 0966565442 , '23 Upper Street, Land','in');

INSERT INTO dbo.PATIENT VALUES(128,'Kii','kee','19960202','M',0123456789,'44 UUUU Streest, Mland','in');



INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 116,1552343 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 115,1553432 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 114,1550115 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 117,1550117 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 122,1552343 );----add 4
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 119,1552343 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 120,1550115 );
INSERT INTO dbo.OUTPATIENT( PID_Out, EID_Doc ) VALUES  ( 121,1552343 );


INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 113 , '20170102' ,'20180201' ,'Eating' ,'100' ,30000000 ,1552343 ,1550116);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 112 , '20180402' ,'20180506' ,'Walking' ,'101' ,25000000 ,1553432 ,1550114);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 111 , '20160202' ,'20180603' ,'Drinking' ,'102' ,55000000 ,1550115 ,1550113);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 118 , '20150202' ,'20170603' ,'Drinking' ,'103' ,55000000 ,1550117 ,1550118);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 126 , '20160101' ,'20160603' ,'Drinking' ,'104' ,45000000 ,1550117 ,1550113);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 123 , '20190102' ,'20190503' ,'Drinking' ,'105' ,35000000 ,1552343 ,1550113);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 124 , '20191202' ,'20200602' ,'Surgery' ,'102' ,65000000 ,1552343 ,1550114);
INSERT INTO dbo.INPATIENT( PID_In ,PAdmissionDate ,PDischargeDate ,PDiagnosis ,PSickroom ,PFee ,EID_Doc ,EID_Nur)
VALUES  ( 125 , '20150202' ,'20160603' ,'Drinking' ,'103' ,15000000 ,1552343 ,1550116);




INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1552343 ,116 ,1800 ,'20200110',3000000 ,'High Tech' ,'20191201');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1553432 ,115 ,1801 ,'20220113',10000000 ,'Drugs' ,'20191101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1550115 ,114 ,1802 ,'20210513',5000000 ,'Drugs' ,'20181101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1550117 ,117 ,1803 ,'20230513',3000000 ,'Drugs and Walking' ,'20181101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1550117 ,114 ,1802 ,'20210513',9000000 ,'Drinking' ,'20181101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1550115 ,117 ,1802 ,'20210513',7000000 ,'Flying' ,'20181101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1552343 ,116 ,1802 ,'20210513',2000000 ,'Drugs' ,'20181101');
INSERT INTO dbo.EXAMINATION( EID_Doc ,PID_OUT ,ExID ,ExDate ,ExFee ,ExDiagnosis ,ExSecondExaminationDate) VALUES  ( 1553432 ,114 ,1802 ,'20210513',3000000 ,'Walking' ,'20181101');

INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1552343 ,113 ,1900 ,'20190110' ,'20201010' ,'20211111');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1553432 ,112 ,1901 ,'20190210' ,'20201110' ,'20220101');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1550115 ,111 ,1902 ,'20190309' ,'20191211' ,'20210111');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1550117 ,118 ,1903 ,'20180301' ,'20190301' ,'20210323');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1550115 ,118 ,1904 ,'20180301' ,'20190301' ,'20210323');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1553432 ,111 ,1905 ,'20180301' ,'20190301' ,'20210323');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1552343 ,112 ,1906 ,'20180301' ,'20190301' ,'20210323');
INSERT INTO dbo.TREATMENT( EID_Doc ,PID_In ,TrID ,TrStart ,TrEnd ,TrResult) VALUES  ( 1550117 ,113 ,1907 ,'20180301' ,'20190301' ,'20210323');

INSERT INTO dbo.MEDICATION( MID, MName, MEffects, MPrice ) VALUES  ( 01,'AAA','Tired',2000000);
INSERT INTO dbo.MEDICATION( MID, MName, MEffects, MPrice ) VALUES  ( 02,'BBB','Dry skin',3000000);
INSERT INTO dbo.MEDICATION( MID, MName, MEffects, MPrice ) VALUES  ( 03,'CCC','Tired',2000000);
INSERT INTO dbo.MEDICATION( MID, MName, MEffects, MPrice ) VALUES  ( 04,'DDD','Stress',2600000);

INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1552343,116,1800,01 );
INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1553432,115,1801,02 );
INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1550115,114,1802,03 );---a
INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1550115,117,1803,04 );
INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1550115,114,1802,04 );-----a
INSERT INTO dbo.Uses_Exam ( EID_Doc, PID_Out, ExID, MID ) VALUES  ( 1553432,114,1802,03 );

INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1550117,118,1903,01 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1550115,111,1902,02 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1553432,112,1901,03 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1553432,111,1905,01 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1550117,113,1907,02 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1552343,113,1900,04 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1552343,113,1900,03 );
INSERT INTO dbo.Uses_Treat( EID_Doc, PID_In, TrID, MID ) VALUES  ( 1550115,111,1902,01 );



--------------------------------------------------------------------------------------------------FUNCTION---------------------------------------
-----QUESTION A-------------
-----Description------
-----incresing PFee of INPATIENT to 10% --------------
CREATE PROCEDURE Increase_fee
AS SELECT PFname,PLname,PAdmissionDate,1.1*PFee NewFee FROM dbo.INPATIENT,dbo.PATIENT
	WHERE PID=PID_In AND PAdmissionDate > '20170901' 
GO

EXEC dbo.Increase_fee


------QUESTION B-------------
----Description------
--------list all patient(out& in)of doctor named 'Lee Woo'-----------------------
CREATE PROCEDURE PatientOfDoctor
AS 
	SELECT PFName,PLName,DOCTOR.EID_Doc
	FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
	WHERE (EFName='Lee' AND ELName='Woo' AND EID=DOCTOR.EID_Doc AND INPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_In=PID) --out
	UNION	(SELECT PFName,PLName,DOCTOR.EID_Doc
					FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
					WHERE (EFName='Lee' AND ELName='Woo' AND EID=DOCTOR.EID_Doc AND OUTPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_Out=PID) ----in
			)	


GO

EXEC dbo.PatientOfDoctor;



----PROCEDURE FOR SEARCHING ANY PATIENT OF A PATIENT WITH INPUT: INPUT : EID_Doc
CREATE PROCEDURE Patient_Doctor_Func
@EID_Doc INT
AS
	BEGIN
		SELECT PFName,PLName,DOCTOR.EID_Doc
		FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
		WHERE (EID=@EID_Doc AND EID=DOCTOR.EID_Doc AND INPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_In=PID) --out
		UNION	(SELECT PFName,PLName,DOCTOR.EID_Doc
						FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
						WHERE (EID=@EID_Doc AND EID=DOCTOR.EID_Doc AND OUTPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_Out=PID) ----in
				)	

	END



EXEC dbo.Patient_Doctor_Func @EID_Doc = '1552343'







----------TEST---

	SELECT PFName,PLName,DOCTOR.EID_Doc
		FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
		WHERE (EID='1552343' AND EID=DOCTOR.EID_Doc AND INPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_In=PID) --out
		UNION	(SELECT PFName,PLName,DOCTOR.EID_Doc
						FROM dbo.DOCTOR,dbo.PATIENT,dbo.INPATIENT,dbo.EMPLOYEE,dbo.OUTPATIENT
						WHERE (EID='1552343'AND EID=DOCTOR.EID_Doc AND OUTPATIENT.EID_Doc=DOCTOR.EID_Doc AND PID_Out=PID) ----in
				)
---------------------QUESTION C--------------
------------DESCRIPTION OF MY PROCEDURE--------

----------Calculate total medicalpprice of a patient( out&in)that have to pay for a examination or a treatment----
--INPUT: P_ID ..... OUT or INPATIENT are allowed---
----OUTPUT: LIST OF total medical price that each treatment ( has 3 column is key)//examination----
---------------------------------------------------------INPUT_PROCEDURE---------------------------
CREATE PROCEDURE Cal_total_MedicalPrice
@P_ID INT
AS
	BEGIN
		IF(@P_ID IN ( SELECT PID_Out FROM dbo.OUTPATIENT))
			SELECT EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID,SUM(MPrice) TotalpriceOfmedication FROM dbo.MEDICATION,dbo.EXAMINATION,dbo.Uses_Exam
			WHERE EXAMINATION.EID_Doc=Uses_Exam.EID_Doc AND EXAMINATION.PID_Out=Uses_Exam.PID_Out AND EXAMINATION.ExID=Uses_Exam.ExID AND MEDICATION.MID=Uses_Exam.MID
			GROUP BY EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID -----tong so tien tu phai tra cho moi examination
			HAVING EXAMINATION.PID_Out=@P_ID
		ELSE IF (@P_ID IN ( SELECT PID_In FROM dbo.INPATIENT)) ( 
																	SELECT TREATMENT.EID_Doc,TREATMENT.PID_In,TREATMENT.TrID,SUM(MPrice) Total_medical_price FROM dbo.MEDICATION,dbo.TREATMENT,dbo.Uses_Treat
																	WHERE TREATMENT.EID_Doc=Uses_Treat.EID_Doc AND TREATMENT.PID_In=Uses_Treat.PID_In AND TREATMENT.TrID=Uses_Treat.TrID AND MEDICATION.MID=Uses_Treat.MID
																	GROUP BY TREATMENT.EID_Doc,TREATMENT.PID_In,TREATMENT.TrID
																	HAVING TREATMENT.PID_In=@P_ID
																	--ORDER BY TREATMENT.PID_In DESC
																)
				

	END


EXEC dbo.Cal_total_MedicalPrice @P_ID = '113'



---another function that calculates total medical price for only eirther treatment or examination
-------INPUT: will be PID_In if for treatment/////will be PID_Out for examination
----Enter ID of patient----
----
CREATE FUNCTION totalMedicalpriceExamination (@P_ID INT)
RETURNS TABLE AS RETURN	(	
								SELECT EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID,SUM(MPrice) TotalpriceOfmedication FROM dbo.MEDICATION,dbo.EXAMINATION,dbo.Uses_Exam
								WHERE EXAMINATION.EID_Doc=Uses_Exam.EID_Doc AND EXAMINATION.PID_Out=Uses_Exam.PID_Out AND EXAMINATION.ExID=Uses_Exam.ExID AND MEDICATION.MID=Uses_Exam.MID
								GROUP BY EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID -----tong so tien tu phai tra cho moi examination
								HAVING EXAMINATION.PID_Out=@P_ID
								--ORDER BY EXAMINATION.PID_Out DESC
						)		 

---test
SELECT * FROM dbo.totalMedicalpriceExamination('114')					




-------QUESTION D----		
----doctors are sorted as ascending of number of inpatient that he/she took care of and PAdmissioDate between Start_Date and @End_Date------
------.....----	

CREATE PROCEDURE Sorting_doctor
@Start_Date DATE,@End_Date DATE
AS
	BEGIN
			SELECT EFName,ELName,EID,COUNT(PID_In) Patient_number FROM dbo.INPATIENT,dbo.DOCTOR,dbo.EMPLOYEE
			WHERE dbo.INPATIENT.EID_Doc=DOCTOR.EID_Doc AND EID=DOCTOR.EID_Doc AND (PAdmissionDate BETWEEN @Start_Date AND @End_Date)
			GROUP BY EFName,ELName,EID
			ORDER BY Patient_number ASC
	END


EXEC Sorting_doctor @Start_Date='20150101',@End_Date='20180101'

EXEC Sorting_doctor @Start_Date='20180101',@End_Date='20191230'

------------------DRAFT( NHAP ))----------------
---------------total price for medication of patient 114----------------
--list of total price of medication for each examination----
---114 patient has 2 examinations from hospital---
SELECT EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID,SUM(MPrice) Total_medical_price FROM dbo.MEDICATION,dbo.EXAMINATION,dbo.Uses_Exam
WHERE EXAMINATION.EID_Doc=Uses_Exam.EID_Doc AND EXAMINATION.PID_Out=Uses_Exam.PID_Out AND EXAMINATION.ExID=Uses_Exam.ExID AND MEDICATION.MID=Uses_Exam.MID
GROUP BY EXAMINATION.EID_Doc,EXAMINATION.PID_Out,EXAMINATION.ExID
HAVING EXAMINATION.PID_Out='114'------------
ORDER BY EXAMINATION.PID_Out DESC



SELECT TREATMENT.EID_Doc,TREATMENT.PID_In,TREATMENT.TrID,SUM(MPrice) Total_medical_price FROM dbo.MEDICATION,dbo.TREATMENT,dbo.Uses_Treat
WHERE TREATMENT.EID_Doc=Uses_Treat.EID_Doc AND TREATMENT.PID_In=Uses_Treat.PID_In AND TREATMENT.TrID=Uses_Treat.TrID AND MEDICATION.MID=Uses_Treat.MID
GROUP BY TREATMENT.EID_Doc,TREATMENT.PID_In,TREATMENT.TrID
HAVING TREATMENT.PID_In='113'
ORDER BY TREATMENT.PID_In DESC



SELECT EFName,ELName,EID,COUNT(PID_Out) FROM dbo.OUTPATIENT,dbo.DOCTOR,dbo.EMPLOYEE
WHERE OUTPATIENT.EID_Doc=DOCTOR.EID_Doc AND DOCTOR.EID_Doc=EID
GROUP BY EFName,ELName,EID

EXEC Sorting_doctor @Start_Date='20150101',@End_Date='20180101'
SELECT EFName,ELName,EID,COUNT(PID_In) FROM dbo.INPATIENT,dbo.DOCTOR,dbo.EMPLOYEE
WHERE dbo.INPATIENT.EID_Doc=DOCTOR.EID_Doc AND EID=DOCTOR.EID_Doc AND (PAdmissionDate BETWEEN '20150101' AND '20180101')
GROUP BY EFName,ELName,EID


SELECT EFName,ELName,EID,COUNT(PID_In) FROM dbo.INPATIENT,dbo.DOCTOR,dbo.EMPLOYEE
WHERE dbo.INPATIENT.EID_Doc=DOCTOR.EID_Doc AND EID=DOCTOR.EID_Doc 
GROUP BY EFName,ELName,EID
----OUT







-----USER-----
---admin-------
CREATE LOGIN tranvothanh WITH PASSWORD = '1552343',
DEFAULT_DATABASE = ASSIGNMENT2

CREATE USER user_admin FOR LOGIN tranvothanh


CREATE LOGIN tranvothanh_2 WITH PASSWORD = '1552343',
DEFAULT_DATABASE = ASSIGNMENT2

CREATE USER user_normal FOR LOGIN tranvothanh_2

------TABLE TO SAVVE DATA OF USERS FOR APP-----
CREATE TABLE USERs
(
	LoginID INT NOT NULL,
	Accounts NVARCHAR(20) NOT NULL,
	Passwords NVARCHAR(20),
	PRIMARY KEY (LoginID)
)

INSERT INTO dbo.USERs ( LoginID, Accounts, Passwords ) VALUES  ( 1, N'tranvothanh_admin', N'1552343')
INSERT INTO dbo.USERs ( LoginID, Accounts, Passwords ) VALUES  ( 2, N'tranvothanh_admin1', N'1552343')
INSERT INTO dbo.USERs ( LoginID, Accounts, Passwords ) VALUES  ( 3, N'tranvothanh_admin2', N'1552343')
INSERT INTO dbo.USERs ( LoginID, Accounts, Passwords ) VALUES  ( 4, N'tranvothanh_admin3', N'1552343')




--AND (PFname='Le' OR PLname='Heo'OR PID='112')


----------------------UPDATE STATEMENT FOR TESTING APPLICATION-----
UPDATE dbo.PATIENT SET PID=127,PFname='ttttt',PLname='ttt',PDoB='19900303',PATIENT.PGender ='F',PPhone=01653751769,PAddress='3333',PGenre='out';


UPDATE dbo.PATIENT SET PFname='tet',PLname='ttt',PDoB='19900303',PGender ='F',PPhone=01653751769,PAddress='3333',PGenre='out'
WHERE PID = '128'


---TEST FOR APPLICATION-----
SELECT EXAMINATION.PID_Out,MEDICATION.MID,MName,MEffects,MPrice,ExFee FROM dbo.EXAMINATION,dbo.Uses_Exam,dbo.MEDICATION WHERE EXAMINATION.PID_Out='116' AND Uses_Exam.MID=MEDICATION.MID
AND EXAMINATION.EID_Doc=Uses_Exam.EID_Doc AND
EXAMINATION.PID_Out=Uses_Exam.PID_Out AND EXAMINATION.ExID=Uses_Exam.ExID



SELECT * FROM dbo.INPATIENT WHERE INPATIENT.EID_Doc='1552343'


SELECT * FROM dbo.INPATIENT,dbo.PATIENT WHERE INPATIENT.EID_Doc='1552343' AND PID_In=PID

SELECT * FROM dbo.EXAMINATION WHERE PID_Out='116'

SELECT * FROM dbo.Uses_Exam	,dbo.MEDICATION WHERE PID_Out='114' AND MEDICATION.MID=Uses_Exam.MID

SELECT * FROM dbo.Uses_Exam,dbo.MEDICATION WHERE MEDICATION.MID=Uses_Exam.MID AND PID_Out='116'

SELECT * FROM dbo.Uses_Treat,dbo.MEDICATION WHERE MEDICATION.MID=Uses_Treat.MID AND PID_In
SELECT * FROM dbo.INPATIENT WHERE PID_In

SELECT * FROM (SELECT * FROM dbo.EXAMINATION WHERE PID_Out='116') AS T LEFT JOIN (SELECT * FROM dbo.Uses_Exam,dbo.MEDICATION WHERE MEDICATION.MID=Uses_Exam.MID ) AS B
ON B.EID_Doc = T.EID_Doc
