SELECT CONCAT(c.company_code,
              ' ',c.founder,
              ' ',COUNT(distinct lm.lead_manager_code),
              ' ',COUNT(distinct sm.senior_manager_code),
              ' ',COUNT(distinct m.manager_code),
              ' ',COUNT(distinct e.employee_code)) 
FROM Company c
    INNER JOIN Lead_Manager lm on lm.company_code = c.company_code
    INNER JOIN Senior_Manager sm on sm.company_code = c.company_code
    INNER JOIN Manager m on m.company_code = c.company_code
    INNER JOIN Employee e on e.company_code = c.company_code
GROUP BY c.company_code,c.founder
ORDER BY c.company_code