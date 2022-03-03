SELECT c.Name FROM City c
    INNER JOIN Country co ON co.Code = c.CountryCode AND co.Continent = 'Africa'