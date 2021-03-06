# Adds the insert_item_entry stored procedure.

DELIMITER $$
CREATE PROCEDURE `insert_item_entry`(
	IN iid INT,
    IN iname VARCHAR(100),
    IN irarity TINYINT,
    IN iseries INT,
    IN itype TINYINT,
    IN isubtype TINYINT)
BEGIN
	INSERT IGNORE INTO ITEMS (id, name, rarity, series, type, subtype) VALUES (iid, iname, irarity, iseries, itype, isubtype)
		ON DUPLICATE KEY UPDATE name=iname, subtype=isubtype;
END$$

DELIMITER ;

ALTER TABLE `schema_version` 
ADD COLUMN `breaking` TINYINT(1) NOT NULL DEFAULT 0 AFTER `version`;


INSERT INTO schema_version VALUES (12, false);