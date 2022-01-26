SELECT f1.x, f1.y
    FROM FUNCTIONS f1 JOIN FUNCTIONS f2 ON
        f1.x = f2.y AND f1.y = f2.x       
GROUP BY f1.x, f1.y
HAVING COUNT(f1.x) > 1 OR f1.x < f1.y
ORDER BY f1.x