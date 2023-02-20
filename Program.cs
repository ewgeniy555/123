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
            
            while(b<=99|b>=1000){
            
            if (b<99|b>=1000){
                 Console.WriteLine("в ведите число 3-х значное чило");
                 b =int.Parse (Console.ReadLine());
                 
                 }
                  if (b<99){
                 Console.WriteLine("вы в вели двух значное число");
                 
                 
                 }
                 if(b >999){
                    Console.WriteLine("вы в вели 4 знака !!!");}
             
            }        
            c=razr(b);
            b=0;
            Console.WriteLine("результат");
            Console.WriteLine(c);
            Console.WriteLine("===========================================");
            
            
            
            
             Console.WriteLine(" программа которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
               static int razr3(int a)
            {
               a = a / 100;
                
               return  a;
            }
            int input=0,rezult;
            
            while(input<=99|input>=1000){
            
            if (input<99|input>=1000){
                 Console.WriteLine("в ведите число 3-х значное чило");
                 input =int.Parse (Console.ReadLine());
                
                 
                 }
                  if (input<99){
                 Console.WriteLine("вы в вели двух значное число");
                 
                 
                 }
                 if(input>999){
                    Console.WriteLine("вы в вели 4 знака");
                 }
             
            }        
            rezult=razr3(input);
            Console.WriteLine("результат");
            Console.WriteLine(rezult);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            
            
            Console.WriteLine(" программa которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
           int dey;

           static void weec (int dey){
           if(dey>=1 & dey<=7){
            if(dey>=1 & dey<=5){Console.WriteLine("день рабочий");}
            else{Console.WriteLine("Выходной!!!!");}
           }
           else{Console.WriteLine("в неделе 7 дней будьте внимательны");}
        
           }
           Console.WriteLine("в ведеите номер дня недели от 1-го до 7-и");
           dey = int. Parse (Console.ReadLine());
           weec(dey);

            
           


           
        
    }
}