SELECT distinct City FROM Station 
	WHERE SUBSTRING(City,LEN(CITY),1) IN ('a','e','i','o','u')