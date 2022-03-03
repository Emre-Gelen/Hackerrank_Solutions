SELECT SUM(c.Population) FROM City c 
    INNER JOIN Country co on co.Code = c.CountryCode AND co.Continent = 'Asia'
