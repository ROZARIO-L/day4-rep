using System;
public class Person
{
	public void Greet()
	{
		Console.WriteLine("hello");
	}
	public void Set_age(int age) 
	{
		Console.WriteLine("my age is " + age);
	}
}
public class Student:Person
{
	public void study()
	{
	Console.WriteLine("i'm studying from the screen");
	}
}
public class Professor:Person
{
	public void Explain()
	{
	Console.WriteLine(" I'm explaining on the screen");
	}
}
public class StudentProfessorTest
{
 public static void Main()
    {
	 Person rozario =new Person();
	 rozario.Greet();
	 Student hanish = new Student();
	 hanish.Set_age(22);
	 hanish.Greet();
	 hanish.study();
	 Professor vikas = new Professor();
	 vikas.Set_age(40);
	 vikas.Greet();
	 vikas.Explain();     
    }   
}