
namespace ConsoleApp7
{
    internal class City
    {
        public decimal Popular { get; set; }
        public static City operator +(City employe, decimal incr)
        {
            return new City { Popular = employe.Popular + incr };
        }
        public static City operator -(City employe, decimal incr)
        {
            return new City { Popular = employe.Popular - incr };
        }
        public static bool operator ==(City left, City right)
        {
            return left.Popular == right.Popular;
        }
        public static bool operator !=(City left, City right)
        {
            return left.Popular != right.Popular;
        }
        public static bool operator <(City left, City right)
        {
            return left.Popular < right.Popular;
        }
        public static bool operator >(City left, City right)
        {
            return left.Popular > right.Popular;
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
