using System;
					
 public class myException:ApplicationException
{
	 public  void nullexception()
	 {
	  Console.WriteLine("Exception occured,object value shoud not be null");
	 }
 }
public class Class1
{ 
	public static void Main()
	{
		Class1 c=null;
		try
		{
		if(c==null)
		{
			throw new myException();
		}
	}
		catch (myException ex)
		{
		ex.nullexception();
		}
		Console.WriteLine();
	}
}