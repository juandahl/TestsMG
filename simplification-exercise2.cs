public class Product
{
	UOM UOMType;
	...

	public decimal Price()
	{
		UOMType.Price();
	}
}

public class UOM 
{
	...
	// if Quantity is used just for calculing the final price, it should be a protected variable declared in this class
	// if not, it should be a parameter in Price method.
	public decimal Price()
	{
		return 0m;
	}
}

public class Grams : UOM
{
	...
	public decimal Price()
	{
		return Quantity * 6m / 1000;
	}
}

public class Bottle : UOM
{
	...
	public decimal Price()
	{
		return Quantity * 3m;
	}
}

public class bag : UOM
{
	...
	public decimal Price()
	{
		var total += Quantity * .2m;

		var setsOfFour = Quantity / 4;
		total -= setsOfFour * .15m; //discount on groups of 4 items
		return total;
	}
}













