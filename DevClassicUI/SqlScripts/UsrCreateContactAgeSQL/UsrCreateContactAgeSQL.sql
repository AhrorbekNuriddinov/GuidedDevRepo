create or alter view UsrVwContactAgeDays
as
select Id as UsrId,Name as UsrName,Birthdate as UsrBirthDate,
datediff(day,BirthDate,getDate()) as UsrAgeDays from Contact