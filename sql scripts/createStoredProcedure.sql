USE garagedb;
DROP PROCEDURE IF EXISTS filterProductsBasedOnCategories;
DELIMITER //
CREATE  PROCEDURE `filterProductsBasedOnCategories`(IN arrayCategories VARCHAR(100), IN amountOfCategories int(16))
BEGIN
    select products.Id, products.Name, products.Price, products.Stock from productcategories
	inner join categories on productcategories.Category_Id = categories.Id
    inner join products on products.Id = productcategories.Product_Id
    WHERE FIND_IN_SET(categories.Type, arrayCategories)
    Group By productcategories.Product_Id
	HAVING count(distinct categories.Type) = amountOfCategories;
#select Array_String;
END//
DELIMITER ;

DROP PROCEDURE IF EXISTS filterProductsBasedOnNames;
DELIMITER //
CREATE  PROCEDURE `filterProductsBasedOnNames`(IN arrayNames VARCHAR(100), IN amountOfNames int(16))
BEGIN
    select products.Id, products.Name, products.Price, products.Stock from productcategories
	inner join categories on productcategories.Category_Id = categories.Id
    inner join products on products.Id = productcategories.Product_Id
    WHERE FIND_IN_SET(products.Name, arrayNames)
    Group By productcategories.Product_Id
	HAVING count(distinct products.Name) = amountOfNames;
#select Array_String;
END//
DELIMITER ;