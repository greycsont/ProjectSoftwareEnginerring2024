SELECT 
    ID, 
    FirstName + ' ' + LastName AS Username
FROM 
    [User]
WHERE 
    Email = @Email 
    AND Password = @Password;
