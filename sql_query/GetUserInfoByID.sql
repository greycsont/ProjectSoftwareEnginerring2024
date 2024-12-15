SELECT 
    FirstName + ' ' + LastName AS Username, 
    Description, 
    mt.Name AS MembershipType
FROM [User] u
LEFT JOIN [Membership_Type] mt ON u.Membership_Type_ID = mt.ID
WHERE u.ID = @UserID;
