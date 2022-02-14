SELECT CAST(Long_W as decimal(16,4))
FROM Station 
    WHERE Lat_N = (SELECT MAX(Lat_N) 
                        FROM Station 
                        WHERE Lat_N < 137.2345)