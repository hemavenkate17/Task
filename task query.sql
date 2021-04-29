select city , count(*) au_id from authors group by city

select au_fname,au_lname  from authors where city not in 
(select distinct pub_name ='New Moon Books'from publishers)

create proc proc_author(@eau_fname varchar(50), @eau_lname varchar(50),@enewprice float)
as
begin
  declare
  @eprice float
  
    set @eprice = @enewprice 
    select @eprice as NewPrice from titles 
    select @eau_fname as FirstName,@eau_lname as LastName from authors
    where authors.au_fname=@eau_fname and authors.au_lname=@eau_lname
end

exec proc_author 'johnson','white',100


drop proc proc_author


create function fn_BookTax(@eqty int)
  returns float 
	as
	begin
		declare 
             @tax float 
             set @eqty = (select qty from sales )
             if(@eqty<10)
	           set @tax = 2/100
             else if(@eqty>10 and @eqty<20)
                set @tax = 5/100
             else if(@eqty>20 and @eqty<30)
                set @tax = 6/100
             else 
                set @tax = 7.5/100
		 return @tax
    end



select qty, dbo.fn_BookTax(30)'Calculated tax' from sales 


 
