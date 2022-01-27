SELECT distinct City FROM Station 
	WHERE Substring(city,1,1) NOT IN ('a','e','i','o','u')