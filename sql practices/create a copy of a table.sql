USE sql_invoicing;


-- CREATE TABLE invoice_archived AS
-- INSERT INTO invoice_archived
SELECT 
		c.name AS client_name,
        I.client_id,
		i.invoice_id,
        i.number,
        i.invoice_total,
        i.payment_total,
         i.due_date,
        i.payment_date
       
FROM invoices i 
JOIN clients c USING(client_id)
WHERE payment_date IS NOT NULL
 


