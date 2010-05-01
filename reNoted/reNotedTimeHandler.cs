using System;
using System.Collections.Generic;
using System.Text;

namespace reNoted
{
    class reNotedTimeHandler
    {
        private string makeNumberTwoDigits(string inNum)
        {
            string toReturn;
            // this is ugly, there must be a better way
            switch (inNum)
            {
                case "0":
                    toReturn = "00";
                    break;
                case "1":
                    toReturn = "01";
                    break;
                case "2":
                    toReturn = "02";
                    break;
                case "3":
                    toReturn = "03";
                    break;
                case "4":
                    toReturn = "04";
                    break;
                case "5":
                    toReturn = "05";
                    break;
                case "6":
                    toReturn = "06";
                    break;
                case "7":
                    toReturn = "07";
                    break;
                case "8":
                    toReturn = "08";
                    break;
                case "9":
                    toReturn = "09";
                    break;
                default:
                    toReturn = inNum;
                    break;
            }
            return toReturn;
        }

        // timeYesOrNo should have some groovy enum
        public string convertDateTimeToSortableString(DateTime inDateTime, string timeYesOrNo)
        {
            string yayOrNay = timeYesOrNo.ToLower();
            string y, m, d;
            y = inDateTime.Year.ToString();
            m = makeNumberTwoDigits(inDateTime.Month.ToString());
            d = makeNumberTwoDigits(inDateTime.Day.ToString());
            string outString = y + "/" + m + "/" + d;

            if (yayOrNay == "yes")
            {
                string h, min, s;
                h = makeNumberTwoDigits(inDateTime.Hour.ToString());
                min = makeNumberTwoDigits(inDateTime.Minute.ToString());
                s = makeNumberTwoDigits(inDateTime.Second.ToString());
                outString = outString + " " + h + ":" + min + ":" + s;
            }
            return outString;
        }
    }
}
