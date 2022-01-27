SELECT CONVERT(decimal(8,2),SUM(LAT_N)) as lat
    ,CONVERT(decimal(8,2),SUM(LONG_W)) as lon
FROM STATION