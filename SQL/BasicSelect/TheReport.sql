SELECT
    CASE WHEN g.Grade < 8 THEN NULL 
        ELSE s.Name END as Name
    ,g.Grade
    ,s.Marks
FROM Students s
INNER JOIN Grades g on s.Marks between g.Min_Mark and g.Max_Mark
ORDER BY g.Grade desc,s.Name