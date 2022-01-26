SELECT
  [Doctor], [Professor], [Singer], [Actor]
FROM  
(
 SELECT ROW_NUMBER() OVER (PARTITION BY OCCUPATION ORDER BY NAME) [RowNumber], * FROM OCCUPATIONS
) AS SourceTable  
PIVOT  
(  
  MAX(Name)
  FOR Occupation IN ([Doctor], [Professor], [Singer], [Actor])  
) AS PivotTable;  