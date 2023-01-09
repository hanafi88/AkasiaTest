
--Run test exec the stored procedure
select * from dbo.TEST2 where Id = 1
exec dbo.usp_InvertColumnValueOnTest2 1, 'E'
select * from dbo.TEST2 where Id = 1
