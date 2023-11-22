SELECT
    SUM(IF(Gender = 'S', Count, 0)) as SieviesuSmarzas,
    SUM(IF(Gender = 'V', Count, 0)) as ViriesuSmarzas
FROM smarzas;
