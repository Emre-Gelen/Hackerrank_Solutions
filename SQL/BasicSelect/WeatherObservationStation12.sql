SELECT distinct City FROM Station 
	WHERE SUBSTRING(city,1,1) NOT IN ('a','e','i','u','o') 
		and SUBSTRING(city,len(city),1) NOT IN('a','e','i','u','o') 