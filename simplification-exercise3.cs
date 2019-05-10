public class Employee
{
	public double MonthlySalary {get; set;}
	public double Commission {get; set;}
	public double Bonus {get; set;}

	public Employee () {}

	public int GetPaymentAmount()
	{
		//Engineer does not add any new behavior so it does not have a particular class
		return MonthlySalary;
	}
}

public class Salesman : Employee
{
	//override
	public int GetPaymentAmount()
	{
		return MonthlySalary + Commission;
	}
}

public class Manager : Employee
{
	//override
	public int GetPaymentAmount()
	{
		return MonthlySalary + Bonus;
	}
}