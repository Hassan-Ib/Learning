use sql_store;

-- SELECT *, quantity * unit_price AS total_quanity -- columns
-- FROM order_items -- table
-- WHERE order_id = "6" AND (quantity * unit_price) > 30; -- filter by row
-- WHERE order_id = "6" AND total_quantity > 30; -- filter by newly created column/ row while selecting wont be filtered


-- IN OPERATOR 
-- SELECT *
-- FROM  Products
-- WHERE quantity_in_stock IN (49,38,72)

-- Between operator
-- SELECT *
-- FROM customers
-- WHERE birth_date BETWEEN "1990-01-01" AND "2000-01-01"; 

-- RETRIVE WITH STRING PATTERN -- LIKE 
-- SELECT *
-- FROM customers
-- WHERE last_name LIKE "b%" -- REGEX " %" - % at end (check end) %- begin (at begining);
-- WHERE last_name LIKE "____y" -- REGEX " __"  _ reperesent a single pattern
-- CHECK ADDRESS WHERE TRAIL AND AVENUE
-- WHERE address LIKE '%TRAIL%' OR  address LIKE "%AVENUE%"
-- PHONE NUMBER 
-- WHERE PHONE LIKE "%9"
-- WHERE PHONE NOT LIKE "%9" 
-- --------------------------------------------------------------------------------
-- REGEXP
-- --------------------------------------------------------------------------------
-- WHERE last_name REGEXP 'FIELD' -- ^ BEGINING , $ - END , | OR

-- WHERE last_name REGEXP 'field|mac|rose' --  |
-- WHERE last_name REGEXP "[gim]e" -- [value] if any of the values in [] exits pick that value
-- WHERE last_name REGEXP "[a-g]e" -- value between a-g followed by e 

-- excersice

-- first ex
-- WHERE first_name REGEXP "elka|ambur"

-- second ex
-- WHERE last_name REGEXP "ey$|on$"

-- third ex
-- WHERE last_name REGEXP "^my|se"

-- fourth ex
-- WHERE last_name REGEXP "b[ru]";

-- records with missing value -- IS NULL
-- SELECT *
-- FROM customers
-- WHERE phone IS NULL
-- FROM orders
-- WHERE shipPed_date IS NULL  -- IS NOT NULL
-- --------------------------------------------------------------------------------
-- ORDER BY
-- --------------------------------------------------------------------------------
-- SELECT *, quantity * unit_price AS total_price
-- FROM order_items
-- WHERE order_id = 2
-- ORDER BY total_price desc;
-- --- --- -----------------------------------------------------------------------
-- limit
-- -------------------------------------------------------------------------------- 
-- SELECT *
-- FROM customers
-- LIMIT 300
-- offset 
-- LIMIT 6, 3 -- START FROM 6 AND COUNT 3

-- EX
-- ORDER BY points desc
-- LIMIT 3

-- --------------------------------------------------------------------------------
-- join table
-- --------------------------------------------------------------------------------
-- SELECT o.order_id, last_name,first_name, order_date
-- FROM orders o
-- JOIN customers C ON
	-- o.customer_id = c.customer_id -- inner join;
    
-- ----------------------------------------------------------------------------------
-- join table across database
-- --------------------------------------------------------------------------------
-- SELECT *
-- FROM order_items oi
-- JOIN sql_inventory.products ip ON -- sql_inventory is from another data base
-- 	 oi.product_id = ip.product_id

-- ----------------------------------------------------------------------------------
-- join multiple table
-- ----------------------------------------------------------------------------------
-- SELECT 
-- 	o.order_id,
--     o.order_date,
--     c.first_name,
--     c.last_name,
--     os.name AS status
-- FROM orders o
-- JOIN customers c 
-- 	ON o.customer_id = c.customer_id
-- JOIN order_statuses os
-- 	ON o.status = os.order_status_id

-- ----------------------------------------------------------------------------------
-- compound joining composite
-- ----------------------------------------------------------------------------------

-- SELECT *
-- FROM order_items oi
-- JOIN order_item_notes oin
-- 	ON oi.order_id = oin.order_id
--     AND oi.product_id = oin.product_id
    
-- ----------------------------------------------------------------------------------
-- implicit join syntax
-- ----------------------------------------------------------------------------------
-- SELECT *
-- FROM orders o
-- JOIN customers c
-- 	ON o.custormer_id = c.customer_id  -- explicit

-- implicit -- 
-- FROM orders o, customers c
-- WHERE o.customer_id = c.customer_id 

-- ----------------------------------------------------------------------------------
-- outer join LET US SELECT PROPERTIES THAT DOESNT MATCH RELATION ASWEL 
-- ----------------------------------------------------------------------------------
-- Compare inner join only select data with compare relation
-- SELECT c.customer_id, c.first_name, o.order_id
-- FROM customers c
-- JOIN orders o
-- 	ON c.customer_id = o.customer_id
    
-- outer LEFT join 
-- LEFT JOIN orders o
--      ON c.customer_id = o.customer_id -- ALL THE RECORDS FORM THE LEFT TABLE ARE RETURN TRUE OR NOT 
-- OUTER RIGHT JOIN
-- RIGHT JOIN orders o
--      ON c.customer_id = o.customer_id -- ALL THE RECORDS FORM THE LEFT TABLE ARE RETURN TRUE OR NOT 
 
-- SELECT p.product_id, p.name, oi.quantity
-- FROM products p
-- LEFT JOIN order_items oi
-- 	ON p.product_id = oi.product_id


-- EX OUTER MUTIPLE JOIN

-- SELECT o.order_date,
-- 		o.order_id,
--         c.first_name,
--         sh.name AS "shipper",
--         os.name AS "status"
-- FROM orders o
-- JOIN customers c 
-- 	ON o.customer_id = c.customer_id
-- LEFT JOIN shippers sh
-- 	ON o.shipper_id = sh.shipper_id
-- JOIN order_statuses os
-- 	ON o.status = os.order_status_id 
-- ORDER BY 

-- ----------------------------------------------------------------------------
-- USING CLAUSE -- USED IF THE COLUMN NAME FOR TABLE TABLES ARE THE SAME 
-- ----------------------------------------------------------------------------
-- SELECT 
-- 	o.order_id,
--     c.first_name,
--     sh.name AS shipper,
--     os.name AS status
-- FROM orders o
-- JOIN customers c
-- 	USING (customer_id)  -- instead of o.customer_id = c.customer_id
-- LEFT JOIN shippers sh
-- 	USING(shipper_id) -- instead of o.shipper_id = c.shipper_id
-- JOIN order_statuses os -- can't be used with this
-- 	ON o.status = os.order_status_id

-- 'USING' with composite join -- composite join if the table has more one key for identification

-- SELECT *
-- FROM order_items oi
-- -- JOIN order_item_notes oin
-- --     ON oi.order_id = oin.order_id
-- --     AND oi.product_id = oin.product_id 
-- JOIN order_item_notes oin
--     USING (order_id,product_id)
	
    
-- ----------------------------------------------------------------------
-- NATURL JOIN
-- ----------------------------------------------------------------------
-- SELECT 
-- 		o.order_id,
--         c.first_name
-- FROM orders o 
-- NATURAL JOIN customers c 


-- ----------------------------------------------------------------------
-- cross join
-- ----------------------------------------------------------------------

-- SELECT 
-- 	c.first_name AS  customer,
--     p.name AS  products
-- FROM customers c 
-- CROSS JOIN products p 
-- ORDER BY c.first_name

-- excersice
-- SELECT *
-- -- FROM shippers , products -- implicit
-- FROM shippers 
-- CROSS JOIN products -- explicit

-- ----------------------------------------------------------------------
-- union of querys -- number of column each query returns must be equal
-- ----------------------------------------------------------------------
-- SELECT 
-- 	order_id,
--     order_date,
--     "ACTIVE" AS status
-- FROM orders
-- WHERE order_date >= '2019-01-01'
-- union -- union 
-- SELECT 
-- 	order_id,
--     order_date,
--     "Archived" AS status
-- FROM orders
-- WHERE order_date < '2019-01-01'

-- ex 
-- SELECT customer_id,
-- 		first_name,
--         points,
--         'Bronze' AS type
-- FROM customers
-- WHERE points < 2000
-- UNION
-- SELECT customer_id,
-- 		first_name,
--         points,
--         'Silver' AS type
-- FROM customers
-- WHERE points BETWEEN "2000" AND "3000"
-- UNION
-- SELECT customer_id,
-- 		first_name,
--         points,
--         'Gold' AS type
-- FROM customers
-- WHERE points > 3000
-- ORDER BY first_name


-- ----------------------------------------------------------------------
-- INSERTING ROW INTO A TABLE
-- ----------------------------------------------------------------------
-- INSERT INTO customers (
-- 		-- IN HERE WE CAN SPECIFY THE COLUMNS WE WANT TO FILL
--         first_name,
--         last_name,
--         birth_date,
--         address,
--         city,
--         state
-- )-- SELECTING table
-- VALUES (
-- 		-- DEFAULT, --  for AI PK -- it can be ordered anyway you want
--         
-- 		"JOHN", -- VARCHAR(50) STRING
--         "SMITH", -- //
--         "1990-01-01", -- //
--          -- NULL, -- OR NULL
--          "ADRRESS",
--          "CITY",
--          "CA" --  char(2)
--          -- DEFAULT
--          ) -- INPUT THE VALUES IN ORDER
--          
-- ----------------------------------------------------------------------
-- INSERTING multiple rows
-- ----------------------------------------------------------------------
-- INSERT INTO shippers (name)
-- VALUE ("SHIPPER1"),
-- 		("SHIPPER2"),
--         ("SHIPPER3")
-- EX  -- multiple insertion
-- INSERT INTO products (name, quantity_in_stock, unit_price) -- specified columns
-- VALUES ("fanbet", 2, 20.45), -- varchar(50), int, decimal(4,2) -- decimal max-4.min-2
-- 		("music", 5, 40.56),
--         ("mouse", 10, 99.99)
        
-- ----------------------------------------------------------------------
-- INSERTion into multiple table
-- ----------------------------------------------------------------------
-- INSERT INTO orders (customer_id, order_date, status)
-- VALUES (1,'2019-01-02', 1);

-- INSERT INTO order_itemS
-- VALUES (LAST_INSERT_ID(), 1, 1, 2.95),
-- 		(LAST_INSERT_ID(), 2, 1, 3.95)
-- 		-- (LAST_INSERT_ID(), 1, 1, 2.95)

-- ----------------------------------------------------------------------
-- COPY data from one table to another -- create table -- using select as subquery
-- ----------------------------------------------------------------------
-- CREATE TABLE orders_archived AS
-- SELECT * FROM  orders

-- INSERT INTO orders_archived
-- SELECT *
-- FROM orders
-- where order_date < '2019-01-01'

-- ----------------------------------------------------------------------
-- UPDATE ROW
-- ----------------------------------------------------------------------
UPDATE customers
SET points = points + 50
WHERE birth_date < '1990-01-01'

