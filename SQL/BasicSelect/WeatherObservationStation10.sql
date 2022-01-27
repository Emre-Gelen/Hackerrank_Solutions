SELECT distinct city FROM Station 
	WHERE SUBSTRING(city,len(city),1) NOT IN ('a','e','i','o','u')