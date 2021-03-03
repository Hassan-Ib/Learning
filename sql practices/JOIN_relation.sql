use sql_store;

SELECT  order_id, p.product_id, name, o.unit_price, quantity 
FROM order_items o -- alia must be used
JOIN products p ON -- relation btw the table 
	 o.product_id = p.product_id
	 
	