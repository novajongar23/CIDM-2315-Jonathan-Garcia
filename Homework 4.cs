namespace Homework4;
class Program
{
    static void Main(string[] args)
{
   // get rows and shape from keyboard
      Console.WriteLine("Please input rows");
      string str_rows = Console.ReadLine();
      Console.WriteLine("Please input direction of shape");
      int rows = Convert.ToInt16(str_rows);
      string shape = Console.ReadLine();
      Triangle(rows,shape);

     Console.Write("a = ");
     int a = int.Parse(Console.ReadLine());

     Console.Write("b = ");
     int b = int.Parse(Console.ReadLine());

     Console.WriteLine($"Largest number is:" + Largest(a,b));

 }
   static void Triangle(int n, string shape) 
   {
   if(shape == "right")
   {
      int i, j, k ;  
      for (i = 1; i <= n; i++)  
      {  
      for (j = 1; j <= n-i; j++)  
      {  
      Console.Write(" ");  
      }  
      for (k = 1; k <= i; k++)  
      {  
      Console.Write("*");  
      }  
      Console.WriteLine("");  
      }  
      Console.ReadLine();  
   }


      if(shape == "left")
   {
      int i,j,k;
      for(i = 1; i <= n; i++)
      {

      for(j = 1; j <= i; j++)
      {


      Console.Write("");


      }

      for (k=1; k <= i; k++)
      {
         Console.Write("*");
      }
      Console.WriteLine("");
      }

      }
}


     static int Largest(int a, int b)
     {
         if(a > b)
     {
         return a;
     }

     else 
         return b;
    }
}
