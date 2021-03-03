USE sql_invoicing;

-- ----------------------------------------------------------------------
-- UPDATE ONE OR MORE ROW 
-- ----------------------------------------------------------------------

-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = 10, payment_date = '2019-03-01' -- pick columns  and set values to insert
-- WHERE invoice_id = 1

-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = 0, payment_date = null -- pick columns  and set values to insert
-- WHERE invoice_id = 1

-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = DEFAULT, payment_date = NULL  -- pick columns  and set values to insert
-- WHERE invoice_id = 1

-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = invoice_total * 0.5,
-- 	 payment_date = due_date -- pick columns  and set values to insert
-- WHERE invoice_id = 3

-- multiple row

-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = 10, payment_date = '2019-03-01' -- pick columns  and set values to insert
-- WHERE client_id = 3


-- UPDATE invoices-- PICK TABLE 
-- SET  payment_total = 10, payment_date = '2019-03-01' -- pick columns  and set values to insert
-- WHERE client_id = 
-- 					(SELECT client_id
-- 					FROM clients
-- 					WHERE name = 'myworks')

UPDATE invoices-- PICK TABLE 
SET  payment_total = 10, payment_date = '2019-03-01' -- pick columns  and set values to insert
WHERE client_id IN
					(SELECT client_id
					FROM clients
					WHERE name IN ('NY', 'CA'))