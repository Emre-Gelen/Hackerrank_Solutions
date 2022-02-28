DECLARE @tmpTable TABLE(LAT_N DECIMAL(16,4),RowNumber int)

INSERT INTO @tmpTable (LAT_N,RowNumber) 
    SELECT LAT_N, ROW_NUMBER() OVER (ORDER BY LAT_N) as RowNumber FROM STATION

DECLARE @Count INT
    SET @Count = (SELECT MAX(RowNumber) FROM @tmpTable) 

IF(@COUNT % 2 = 0)
    BEGIN
        SELECT SUM(LAT_N)/2 FROM @tmpTable WHERE RowNumber in ((@Count+1/2),@Count / 2)
    END
ELSE
    BEGIN
        SELECT LAT_N FROM @tmpTable WHERE RowNumber = (@Count+1)/2
    END