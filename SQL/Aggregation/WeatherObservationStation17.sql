SELECT CAST(Long_W as decimal(16,4))
FROM Station
    WHERE Lat_N = (SELECT MIN(Lat_N) 
                        FROM Station 
                            WHERE Lat_N > 38.7780)