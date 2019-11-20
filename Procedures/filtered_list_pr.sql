CREATE PROCEDURE filtered_list_pr @filter_type int, @filter_text varchar(50) 
AS
SELECT [last_name] '�������', Left([first_name],1)+'.' '���', Left([second_name],1)+'.' '��������',
[status].[name] '������', [deps].[name] '�����', [posts].[name] '���������',  
[date_employ] '���� �����',[date_unemploy] '���� ����������'
FROM [dbo].[persons] 
LEFT JOIN [status] on [status].[id] = [persons].[status]
LEFT JOIN [deps] on [deps].[id] = [persons].[id_dep]
LEFT JOIN [posts] on [posts].[id] = [persons].[id_post]
WHERE (@filter_type = 0) OR
(@filter_type = 1 and [status].[name] = @filter_text) OR
(@filter_type = 2 and [deps].[name] = @filter_text) OR
(@filter_type = 3 and [posts].[name] = @filter_text) OR
(@filter_type = 4 and [persons].[last_name] LIKE ('%' + @filter_text + '%'))
GO

