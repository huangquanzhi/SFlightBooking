using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{
    class Validation
    {
        /// <summary>
        /// Date validate
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Time validate
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Phone validate
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
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
