

namespace MethodOverloading
{
    public  class Program
    {






        //two integers and returns the sum of those two integers




        public static int Add(int num1, int num2)


        {

            return num1 + num2;

        }

        //create an overload of the Add method to account for being able to add two decimals together


        public static decimal Add( decimal num1, decimal num2)

        {
            return num1 + num2;

        }


        //method that returns a string and accepts 3 parameters: 2 integers and 1 boolean


        public static string Add(int num1, int num2, bool isTrue)

        {

      
        
            if (isTrue)
            {
                 var sum = num1 + num2;
                if (sum == 1)

                {

                  return $"{sum} Dollar.";


                }

                else
                {

                    return $"{sum} Dollars.";
                }

            } return "";

           
        } 




        static void Main(string[] args)
        {


            // **** testing the mothds ****

            var name = true;
            
           
            var total1 = 4;
            var total2 = 1;
            var total3 = 4.3489m;
            var total4 = 4.34890m;

            var result1 = Add(total3, total4);// decimal
            var result2 = Add(total1,total2,name);// string , int , bool

            Console.WriteLine($"{result1}");
            Console.WriteLine($"{result2}");



        }









    }
}
