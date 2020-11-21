using System;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Dynamic;

namespace JTejero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q085()______________________________________________

            //Console.WriteLine("\nCHECKED output value is: {0}", Q085.CheckedMethod());
            //Console.WriteLine("UNCHECKED output value is: {0}", Q085.UncheckedMethod());

            //Q090 _________________________________________________  DA ERROR DE COMPILACIÓN
            /* ArrayList samplesList = new ArrayList();
            if (Q090.SetupCategory())
            {
                return;
            }
              
            Q090.CreateCounters();
            Q090.CollectSamples(samplesList);
            Q090.CalculateResults(samplesList);
            */

            // Q156 _____________________DA FALLOS DE COMPILACION________________________________________________
            // Q156 OPCIÓN C
           // var message = new { From = "Jon Morris", To = "Mary North", Content = "Hello World" };
           //Q156.SendMessage(message);

            // Q156 OPCIÓN D
           /*
           dynamic message = new ExpandoObject();
           message.From = "Jon Morris"; 
​			message.To = "Mary North";
​			message.Content = "Hello World";
            Q156.SendMessage(message);
            */



            // _QUESTION 162_________________________________________________________________________

            //new Q162().DoWork();


            // QUESTION 262______________________FALLO DE COMPILACIÓN _____________________
            //Q262.DoWork1();
            Console.WriteLine(Q262.DoWork());
           
            // QUESTION 278
            //new Q278.DoWork();
        }
    }
}
