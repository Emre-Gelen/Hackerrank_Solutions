SELECT distinct City FROM Station 
	WHERE SUBSTRING(City,1,1) IN ('a','e','i','o','u')