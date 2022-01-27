select CITY,LEN(CITY) FROM Station 
	WHERE City = (select Top(1) City from Station where LEN(City)=(select MAX(LEN(City)) from Station) order by City)
UNION ALL
select CITY,LEN(CITY) FROM Station 
	WHERE City = (select Top(1) City from Station where LEN(City)=(select MIN(LEN(City)) from Station) order by City)