SELECT distinct City FROM Station 
	WHERE ID % 2 = 0
	ORDER BY City;