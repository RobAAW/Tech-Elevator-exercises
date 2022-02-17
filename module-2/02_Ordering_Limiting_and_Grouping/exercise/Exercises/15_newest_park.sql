-- 15. The name and date established of the newest national park.
-- (1 row)
SELECT TOP 1 *
FROM
(
SELECT park_name, date_established
FROM park
) youngest
ORDER BY date_established DESC;
