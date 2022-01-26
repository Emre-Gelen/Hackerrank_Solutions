SELECT Name+'('+Substring(occupation,1,1)+')' 
	FROM Occupations 
	order by Name

SELECT 'There are a total of '+CAST(COUNT(Name) as nvarchar)+' '+LOWER(Occupation)+'s.'
	FROM Occupations 
	GROUP BY Occupation 
	ORDER BY Count(Name),Occupation