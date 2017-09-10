<Query Kind="Statements">
  <Connection>
    <ID>3ae3f2a1-31be-4180-bec4-adfafbf22ab2</ID>
    <Persist>true</Persist>
    <Server>CHOUHANS-PC</Server>
    <Database>Employee</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//select * from Customer

//Query based Syntax
//from c in Customers 
//select c

//Where condition
//from c in Customers where c.Custid>105 
//select c

// Method based Syntax
//Customers.Select(c=>c)

//Customers.Where(c=>(c.Custid>105))

//Deffered execution
//var q = from c in Customers 
//		where c.Custid>102 
//		select c;
//q.Dump();
	
//Immediate execution
//var q = (from c in Customers 
	//	where c.Custid>102 
	//	select c).ToList();
	//q.Dump();

//differnece b/w var and generics 

//var q = (from c in Customers 
//		where c.Custid>102 
//		select new {
//		c.Cname,
//		c.Balance
//		}
//		).ToList();
//	q.Dump();
	
//List<Customer> q1 = (from c in Customers 
//		where c.Custid>102 
//		select new Customer {
//		Cname=c.Cname,
//		Balance=c.Balance
//		}).ToList();
//		q1.Dump();

//Joins
		//Inner join
		//Group Join
		//Left Join
		//Cross Join

//	 Inner Join

//var q = from c in Emps join t in Depts 
//		on c.Deptno equals t.Deptno
//		join dd in DeptDetails 
//		on t.Deptno equals dd.Deptno
//		orderby t.Deptno
//		select new {
//			c.Ename,
//			c.Job,
//			t.Loc,
//			t.Deptno,
//			t.DName,
//			dd.Comments
//			};
//	q.Dump();


//var q = from e in Emps 
//		from t in Depts
//		where ( e.Deptno == t.Deptno )
//		select new {
//		e.Ename,
//		t.DName
//		};
//	q.Dump();

	
	//group Join
//	
//	var q = from c in Emps join t in Depts 
//		on c.Deptno equals t.Deptno
//		into gp
//		select new {
//			c.Ename,
//			c.Job,
//			gp
//			};
//	q.Dump();
//
//	var q = from c in Emps join t in Depts 
//		on c.Deptno equals t.Deptno
//		into gp
//		select new {
//			c.Ename,
//			c.Job,
//			data = from g in gp select new {g.DName}
//			};
//	q.Dump();

//Left Join

//	var q = from c in Emps join t in Depts 
//		on c.Deptno equals t.Deptno
//		into gp
//		from g in gp.DefaultIfEmpty()
//		select new {
//			c.Ename,
//			c.Job,
//			g.DName
//			};
//	q.Dump();

//Cross Join

//	var q = from c in Customers
//			from t in Depts 
//			select new {
//			c.Custid,
//			c.Balance,
//			c.Cname,
//			t.DName
//			};
//		
//	q.Dump();





// Aggegate
//Console.WriteLine(Customers.Sum(x=>x.Custid));
//Console.WriteLine(Customers.Average(x=>x.Custid));

//Element Operators

//Console.WriteLine(Customers.First(x=>x.Cname =="Zane"));
//To check with the goup of values and give the result of first one
//Console.WriteLine(Customers.First(x=>x.Balance >12000));

//To check with the one value and give the result of first one
//Console.WriteLine(Customers.SingleOrDefault(x=>x.Balance ==12000));

//Difference between Select and SelectAll
//class Employee { public string Name { get; set; } 
//public List<string> Skills { get; set; } } 
//class Program { static void Main(string[] args) 
//{ List<Employee> employees = new List<Employee>();
//Employee emp1 = new Employee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
//Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } }; 
//Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } }; 
//employees.Add(emp1); employees.Add(emp2); employees.Add(emp3);
//// Query using Select() IEnumerable<List<String>> resultSelect = employees.Select(e=> e.Skills); Console.WriteLine("Using Select():\n");
//{ foreach (string skill in skillList)
//{ Console.WriteLine(skill); } Console.WriteLine(); } 
////Query using SelectMany() IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills); 
//Console.WriteLine("Using SelectMany():"); // Only one foreach loop is required to iterate through the results 
//// since query returns a one-dimensional collection. foreach (string skill in resultSelectMany) 
//{ Console.WriteLine(skill); } Console.ReadKey(); } }

//difference among Any, All and Contains

//All - It checks whether all the elements in a collection satisfy a specified condition. It returns true if all the elements satisfy the condition else returns false if they do not.
//Console.WriteLine(Customers.All(name=>name.Balance > 21000)); //return False, all balances cant be 21000

//Any - It checks whether at least one element in a collection satisfy a specified condition. It returns true if at least one element satisfy the condition else returns false if they do not.
//Console.WriteLine(Customers.Any(name=>name.Balance > 21000));  //return True, all alteast once cant be greater then 21000

//Contains - It checks whether at least one element in a collection satisfy a specified condition. It returns true if at least one element satisfy the condition else returns false if they do not.
//string[] hobbies = { "Swimming", "Cricket", "Singing", "Watching Moview"};
//bool IsHobby = hobbies.Contains("Swimming");

//	var q = from c in Emps join t in Depts 
//		on c.Deptno equals t.Deptno
//		into gp
//		select new {
//			c.Ename,
//			c.Job,
//			gp
//			};
//	q.Dump();

//	var q = from c in Emps 
//			group c by new {c.Ename}
//			into gp 
//			select new {
//			EmployeeName = from g in gp select new {
//			g.Ename,
//			g.Job
//			}};
//	  
//	  
//	q.Dump();


//Having in Linq

//var q1 =  from c in Emps
//			group c by c.Ename into gp
//			select new {
//			groupeddata =from g in gp select new {
//			g.Ename,
//			g.Job
//			
//			}
//	};
//		
//	q1.Dump();


//var q2= from cust in Customers
//		 group cust by new { cust.Cname, cust.Custid }
//		 into groupingEmp 
//		let avgsalary = (groupingEmp.Sum(gEmp => gEmp.Balance) / groupingEmp.Count()) 
//		select new { 
//			EmployeeName =  from gp in groupingEmp 
//								select new {
//								gp.Cname
//								},
//			avgsalary
//			};
//
//q2.Dump();

//query to find 2nd highest salary?
//
//DataContext context = new DataContext();
//					var q= context.tblEmployee.GroupBy(ord => ord.Salary) .
//							OrderByDescending(f => f.Key) .Skip(1) //second, third ..nth highest salary where n=1,2...n-1 
//							.First() 
//							.Select(ord=>ord.Salary) 
//							.Distinct();




















	





	
	 



