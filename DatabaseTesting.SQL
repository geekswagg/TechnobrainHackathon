SELECT *
FROM Users
WHERE CreatedDate >= DATEADD(DAY, -30, GETDATE());

SELECT COUNT(*)
FROM Users
WHERE Email LIKE '%@example.com';

UPDATE Users
SET Email = 'newemail@example.com'
WHERE UserId = 12345;