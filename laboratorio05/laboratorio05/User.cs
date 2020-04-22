using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace laboratorio05
{
    public class User
    {
        public delegate void DeEmailVerified(object source, RegisterEventArgs args);
        public event DeEmailVerified EmailVerified;
        protected virtual void OnEmailVerified()
        {
            // Verifica si hay alguien suscrito al evento
            if (EmailVerified != null)
            {
                // Engatilla el evento
                EmailVerified(this, new RegisterEventArgs() { });
            }
        }


        public void OnEmailSent(object source, RegisterEventArgs args)
        {

            string respuesta;
            Console.WriteLine("Desea verificar su correo? si o no");
            respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Se ha verificado el correo");
                Thread.Sleep(2000);
                OnEmailVerified();
            }
            

        }


    }
}
