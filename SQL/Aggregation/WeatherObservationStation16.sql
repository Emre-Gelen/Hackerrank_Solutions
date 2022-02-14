SELECT CAST(MIN(Lat_N) as decimal(16,4))
FROM Station 
    WHERE Lat_N > 38.7780