SELECT co.Continent, ROUND(AVG(c.Population),0) FROM Country co
    INNER JOIN City c ON c.CountryCode = co.Code
    GROUP BY co.Continent
    