--Create stored procedure for Inverting passed column values
CREATE proc [dbo].[usp_InvertColumnValueOnTest2]
	@Id INT,
	@ColumnName char(1)
as
begin
	if @ColumnName NOT IN ('A','B','C','D','E')
	BEGIN
		RAISERROR (15600, -1, -1, 'usp_InvertColumnValueOnTest2');
	END
	
	declare @strSql nvarchar(max)
	SET @strSql = '
		update t SET [' + @ColumnName + '] = case [' + @ColumnName + '] when 1 then 0 when 0 then 1 end
		from  dbo.TEST2 t
		WHERE t.Id = ' + cast(@Id as varchar(max))

	EXEC(@strSql)
end
