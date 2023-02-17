internal class Program
{
    private static void Main(string[] args)
    {
        
        
            Console.WriteLine("принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            static int razr(int a)
            {
                
            
            
               a = a / 10; 
               a = a % 10;
                return  a;
            }
            int b=0,c;
            
            while(b<=99){
            
            if (b<99){
                 Console.WriteLine("в ведите число 3-х значное чило");
                 b =int.Parse (Console.ReadLine());
                 
                 }
                  if (b<99){
                 Console.WriteLine("вы в вели двух значное число");
                 
                 
                 }
             
            }        
            c=razr(b);
            b=0;
            Console.WriteLine("результат");
            Console.WriteLine(c);

            




           
        
    }
}