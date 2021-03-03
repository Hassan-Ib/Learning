-- self join -- self relation
USE sql_hr;

SELECT
	e.employee_id,
	e.first_name AS employee_name,
    m.employee_id AS manager_id,
    m.first_name AS manager
    
FROM employees e
LEFT JOIN employees m 
	ON e.reports_to = m.employee_id