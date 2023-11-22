-- data import
LOAD DATA INFILE 'D:/UNIVERSITATE/DATU BAZES/datubazes-majas-darbi/AK_IT-P-Ns-2_Antons_Cvetkovs_3md/smarzas.csv' -- noradam linku lidz csv failam
INTO TABLE smarzas -- noradam tabulu kura dati bus importeti
FIELDS TERMINATED BY ',' -- atdalam pirmo kolonnu no otras
LINES TERMINATED BY '\n' -- noradam simbolu ar kuru beidzas rinda
(@var1, @var2) -- @var1 ir pirma kolonna, @var2 ir otra kolonna
SET Brand = SUBSTRING_INDEX(@var1, ';', 1),
    Gender = SUBSTRING_INDEX(SUBSTRING_INDEX(@var1, ';', 2), ';', -1),
    Name = SUBSTRING_INDEX(SUBSTRING_INDEX(@var1, ';', 3), ';', -1),
    Volume = SUBSTRING_INDEX(SUBSTRING_INDEX(@var1, ';', 4), ';', -1),
    Price = CAST(SUBSTRING_INDEX(SUBSTRING_INDEX(@var1, ';', 5), ';', -1) AS DECIMAL(10,2)),
    Count = @var2;

UPDATE smarzas
SET Count = 0
WHERE Count IS NULL;