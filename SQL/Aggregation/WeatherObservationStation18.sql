SELECT CAST(MAX(Lat_N)-MIN(Lat_N) + MAX(Long_W)-MIN(Long_W) as decimal(16,4)) 
FROM Station;