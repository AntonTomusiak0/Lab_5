
namespace ConsoleApp7
{
    internal class CreditСard
    {
        public decimal CardSum { get; set; }
        public decimal CVC { get; set; }
        public static CreditСard operator +(CreditСard employe, decimal incr)
        {
            return new CreditСard { CardSum = employe.CardSum + incr };
        }
        public static CreditСard operator -(CreditСard employe, decimal incr)
        {
            return new CreditСard { CardSum = employe.CardSum - incr };
        }
        public static bool operator ==(CreditСard left, CreditСard right)
        {
            return left.CVC == right.CVC;
        }
        public static bool operator !=(CreditСard left, CreditСard right)
        {
            return left.CVC != right.CVC;
        }
        public static bool operator <(CreditСard left, CreditСard right)
        {
            return left.CardSum < right.CardSum;
        }
        public static bool operator >(CreditСard left, CreditСard right)
        {
            return left.CardSum > right.CardSum;
        }
        //public Employee(string pip, Data data, string phone, string email, string post, string respon)
        //{
        //    PIP = pip;
        //    BirthDay = data;
        //    Phone = phone;
        //    Email = email;
        //    Post = post;
        //    Responsib = respon;
        //}
        //public void ShowInfo()
        //{
        //    Console.WriteLine($"PIP:\t{PIP}");
        //    data.ShowData();
        //    Console.WriteLine($"Phone:\t{Phone}");
        //    Console.WriteLine($"Email:\t{Email}");
        //    Console.WriteLine($"Post:\t{Post}");
        //    Console.WriteLine($"Responsibilities:\n{Responsib}");
        //}
    }
}
