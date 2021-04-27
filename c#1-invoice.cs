using System;

public class Product
        {
        public string p_name;
        public double price;
        public int quantity;
        public double  total;
        


 public static void Main()
    {
        Product soap = new Product();
        soap.total=soap.price*soap.quantity;
   	
	 	Console.WriteLine("enter the product name");
        soap.p_name =Console.ReadLine();
        Console.WriteLine("enter the quantity");
        soap.quantity =Convert.ToInt32(Console.ReadLine());
        soap.total=(soap.price)*(soap.quantity);
	Console.WriteLine("enter the price");
        soap.price = Convert.ToDouble(Console.ReadLine());
        
	   
        
         Console.Write("1  ");
         Console.Write(soap.p_name+"   ");
         Console.Write(soap.price + "  ");
         Console.Write(soap.quantity+" "  );
         Console.Write(soap.total  );
        
    }   
        
    }