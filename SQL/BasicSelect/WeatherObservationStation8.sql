SELECT City FROM Station 
	WHERE Substring(city,1,1) IN ('a','e','i','o','u') 
		and Substring(city,LEN(city),1) IN ('a','e','i','o','u')