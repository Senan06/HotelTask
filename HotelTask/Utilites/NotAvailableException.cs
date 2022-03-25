using System;


namespace HotelTask.Utilites
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException()
        {
        }

        public NotAvailableException(string mesagge):base(mesagge)
        {

        }
        
    }
}
