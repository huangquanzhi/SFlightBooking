using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{
    class Validation
    {
        public static bool DateValidate(string date)
        {
            try
            {

                DateTime.ParseExact(date, "yyyy-mm-dd", System.Globalization.CultureInfo.CurrentCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool TimeValidate(string time)
        {
            try
            {

                DateTime.ParseExact(time, "mm:ss", System.Globalization.CultureInfo.CurrentCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool PhoneValidate(string phone)
        {
            try
            {
                int num = int.Parse(phone);
                if (phone.Length == 10)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

    }
}
