SELECT CAST(MAX(Lat_N) as decimal(16,4))
FROM Station
    WHERE Lat_N < 137.2345