SELECT 
    e.[ID],
    e.[Title], 
    et.[Name] 
FROM [dbo].[Event] e
LEFT JOIN [dbo].[Event_Type] et ON e.[Event_Type_ID] = et.[ID]
WHERE e.[Starting_Time] >= GETDATE()
ORDER BY e.[Starting_Time] ASC
OFFSET @Offset ROWS FETCH NEXT 3 ROWS ONLY;
