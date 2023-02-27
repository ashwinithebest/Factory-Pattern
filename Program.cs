
using System;
namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
//using System;
//namespace FactoryDesignPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

//            if (cardDetails != null)
//            {
//                Console.WriteLine("CardType : " + cardDetails.GetCardType());
//                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//            }
//            else
//            {
//                Console.Write("Invalid Card Type");
//            }

//            Console.ReadLine();
//        }
//    }
//}