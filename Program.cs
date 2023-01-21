//Armstrog number in Vb.net
namespace ArmstrongNumber
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;
            Console.WriteLine("Enter the number : ");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;

            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("This is Armstrong Number !");
            }
            else
            {
                Console.WriteLine("This is nt Armstrong Number !");
            }
            Console.ReadLine();
        }
    }
}