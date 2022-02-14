SELECT CAST(SQRT(
            POWER(MAX(Lat_N)-MIN(Lat_N),2) +
            POWER(MAX(Long_W)-MIN(Long_W),2)) as decimal(16,4)) 
FROM Station