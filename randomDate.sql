SET sql_mode = PIPES_AS_CONCAT;

DELIMITER // 

DROP PROCEDURE IF EXISTS random_date//
CREATE PROCEDURE random_date()
BEGIN
	-- RANDOMAN DATE
	DECLARE hasil VARCHAR(10000) DEFAULT '';
	DECLARE tempDate VARCHAR(20) DEFAULT '';
	DECLARE hasilDate VARCHAR(20) DEFAULT '';
	DECLARE randomDate INT DEFAULT 0;
	
	-- CURSOR LOOPING VARIABLE
	DECLARE done INT DEFAULT 0;
	DECLARE i INT DEFAULT 1;
	
	DECLARE cur CURSOR FOR 
		SELECT warranty
		FROM cars;
    
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
	
	
	OPEN cur;
	    getDate : LOOP
		FETCH cur INTO tempDate;
		IF done = 1 THEN
		LEAVE getDate;
		END IF;
		
		-- random tanggal
		SET randomDate = RAND()*(30-5)+5;
		-- convert bulan 
		IF SUBSTR(tempDate,1,3) = 'Jan' THEN SET hasilDate = CONCAT('1/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Feb' THEN SET hasilDate = CONCAT('2/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Mar' THEN SET hasilDate = CONCAT('3/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Apr' THEN SET hasilDate = CONCAT('4/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Mei' THEN SET hasilDate = CONCAT('5/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Jun' THEN SET hasilDate = CONCAT('6/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Jul' THEN SET hasilDate = CONCAT('7/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Agt' THEN SET hasilDate = CONCAT('8/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Sep' THEN SET hasilDate = CONCAT('9/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Okt' THEN SET hasilDate = CONCAT('10/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Nov' THEN SET hasilDate = CONCAT('11/',randomDate,'/',SUBSTR(tempDate,5,4));
		ELSEIF SUBSTR(tempDate,1,3) = 'Des' THEN SET hasilDate = CONCAT('12/',randomDate,'/',SUBSTR(tempDate,5,4));
		END IF;
		
		UPDATE cars SET warranty = hasilDate WHERE id_car = i;
		-- SET hasil = hasil || i || '. ' || hasilDate || '\n';
		SET i = i + 1;
	    END LOOP;
	CLOSE cur;
	
	-- select hasil;
END// 

DELIMITER ;

CALL random_date()

UPDATE cars SET warranty = '5-25-2023' WHERE id_car = 1