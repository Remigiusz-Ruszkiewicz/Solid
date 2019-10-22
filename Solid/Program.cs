using Solid.D;
using Solid.I;
using Solid.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        //public string SendMessages()

        //{
        //    ISender MMS = new MMS();
        //    ISender SMS = new SMS();
        //    ISender E_Mail = new E_Mail();
        //    return ;

        //}
        static void Main(string[] args)
        {
            //IPay payment = null;
            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "cash":
            //        payment = new Cash();
            //        break;
            //    case "card":
            //        payment = new Card();
            //        break;
            //    case "tr":
            //        payment = new Transfer();
            //        break;
            //    case "blik":
            //        payment = new Blik();
            //        break;
            //    default:
            //        break;
            //}
            //try
            //{
            //    Console.WriteLine(payment.Payment(13));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Door door = new Door();
            //var smart = door as IStandard;
            //Console.WriteLine(smart.Close());
            //Console.WriteLine(((IStandard)door).Open());
            ISender MMS = new MMS();
            ISender SMS = new SMS();
            ISender E_Mail = new E_Mail();
            ISender Pigeon = new Pigeon();
            Console.WriteLine($"Wysyłam widomość za pomocą: {MMS.Method()} {SMS.Method()} {E_Mail.Method()} {Pigeon.Method()}");


            Console.Read();
        }
        
        


    }
}
