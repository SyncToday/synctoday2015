--DECLARE @Name nvarchar(255) = 'sync.today.workflowmgr.exe'  --'test'

SELECT [Id]
      ,[CreatedOn]
      ,[Name]
      ,[XamlCode]
  FROM [Workflows] WHERE ISNULL(@Name, Name)=Name
