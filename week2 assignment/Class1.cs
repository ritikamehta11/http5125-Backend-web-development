using System;

public class AddTenController : ApiController
	public int GET(int id)
	{
	int sum1 = id + 10;
	return sum1;
	}
}
