using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Alarm_Hours
{
    class Program
    {

        public string PrintZero()
        {
            string Zero = (
            "0000000000000"+
            "\n0000000000000" +
            "\n000       000" +
            "\n000       000" +
            "\n000       000" +
            "\n000       000" +
            "\n000       000" +
            "\n0000000000000" +
            "\n0000000000000");

            return Zero;

        }


        public string PrintOne()
        {
            string One = (
            "      0000000" +
            "\n      0000000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000");

            return One;

        }
        public string PrintTwo()
        {
            string Two = (
            " 00000000000 " +
            "\n0000000000000" +
            "\n        0000 " +
            "\n       0000  " +
            "\n      0000   " +
            "\n     0000    " +
            "\n   0000      " +
            "\n 000000000000" +
            "\n0000000000000");

            return Two;

        }

        public string PrintThree()
        {
            string Three = (
            "0000000000000"+
            "\n0000000000000" +
            "\n          000" +
            "\n       0000  " +
            "\n     00000   " +
            "\n        0000 " +
            "\n          000" +
            "\n0000000000000" +
            "\n0000000000000");

            return Three;

        }

        public string PrintFour()
        {
            string Four = (
            "     00000   "+
            "\n    00 000   "+
            "\n   00  000   "+
            "\n  00   000   "+
            "\n 000000000000"+
            "\n0000000000000"+
            "\n       000   "+
            "\n       000   "+
            "\n       000   ");

            return Four;

        }

        public string PrintFive()
        {
            string Five = (
            "0000000000000" +
            "\n0000000000000" +
            "\n00           " +
            "\n0000000000000" +
            "\n0000000000000" +
            "\n           00" +
            "\n           00" +
            "\n0000000000000" +
            "\n0000000000000");

            return Five;
        }

        public string PrintSix()
        {
            string Six = (
            "0000000000000"+
            "\n0000000000000"+
            "\n000          "+
            "\n000          "+
            "\n0000000000000"+
            "\n000       000"+
            "\n000       000"+
            "\n0000000000000"+
            "\n0000000000000");

            return Six;

        }

        public string PrintSeven()
        {
            string Seven = (
            "0000000000000"+
            "\n0000000000000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000" +
            "\n          000");


            return Seven;
        }

        public string PrintEight()
        {
            string Eight = (
            "0000000000000" +
            "\n0000000000000" +
            "\n000       000" +
            "\n000       000" +
            "\n0000000000000" +
            "\n000       000" +
            "\n000       000" +
            "\n0000000000000" +
            "\n0000000000000");

            return Eight;

        }

        
        public string PrintNine()
        {
            string Nine = (
            "0000000000000"+
            "\n0000000000000"+
            "\n000       000"+
            "\n000       000"+
            "\n0000000000000"+
            "\n          000"+
            "\n          000"+
            "\n0000000000000"+
            "\n0000000000000");

            return Nine;

        }

        public string PrintColon()
        {
            string Colon = (
            "             " +
            "\n             " +
            "\n     000     " +
            "\n     000     " +
            "\n             " +
            "\n             " +
            "\n     000     " +
            "\n     000     " +
            "\n             ");

            return Colon;

        }

        public string PrintM()
        {
            string M = (
            "0000   0000" +
            "\n00000 00000" +
            "\n000 000 000" +
            "\n000  0  000" +
            "\n000     000" +
            "\n000     000");

            return M;

        }

        public string PrintO()
        {
            string O = (
            "  0000000  " +
            "\n 000   000 " +
            "\n000     000" +
            "\n000     000" +
            "\n 000   000 " +
            "\n  0000000  ");

            return O;

        }

        public string PrintN()
        {
            string N = (
            "00000   000" +
            "\n000000  000" +
            "\n000 000 000" +
            "\n000  000000" +
            "\n000   00000" +
            "\n000    0000");

            return N;

        }

        public string PrintT()
        {
            string T = (
            "00000000000" +
            "\n00000000000" +
            "\n    000    " +
            "\n    000    " +
            "\n    000    " +
            "\n    000    ");

            return T;
               



        }

        public string PrintU()
        {
            string U = (
            "000     000"+
            "\n000     000"+
            "\n000     000"+
            "\n000     000"+
            "\n00000000000"+
            "\n 000000000 ");

            return U;
        }

        public string PrintE()
        {
            string E = (
            "00000000000"+
            "00         "+
            "00000000000"+
            "00000000000"+
            "00         "+
            "00000000000");

            return E;

        }

        public string PrintW()
        {
            string W = (
            "00  000  00"+
            "\n00  000  00"+
            "\n00  000  00"+
            "\n000 000 000"+
            "\n00000000000"+
            "\n 000000000 ");

            return W;

        }

        public string PrintD()
        {
            string D = (
            "00000000   " +
            "\n000    000 " +
            "\n000     000" +
            "\n000     000" +
            "\n000    000 " +
            "\n00000000   ");

            return D;
        }

        public string PrintH()
        {
            string H = (
            "000     000" +
            "\n000     000" +
            "\n00000000000" +
            "\n00000000000" +
            "\n000     000" +
            "\n000     000");

            return H;

        }

        public string PrintR()
        {
            string R = (
            "00000000   " +
            "\n000   0000 " +
            "\n000     000" +
            "\n0000000000 " +
            "\n000   000  " +
            "\n000     000");

            return R;
        }

        public string PrintF()
        {
            string F = (
            "00000000000" +
            "\n00000000000" +
            "\n000       " +
            "\n00000000000" +
            "\n000        " +
            "\n000        ");

            return F;
        }

        public string PrintI()
        {
            string I = (
            "00000000000" +
            "\n00000000000" +
            "\n    000    " +
            "\n    000    " +
            "\n00000000000" +
            "\n00000000000");

            return I;
        }

        public string PrintS()
        {
            string S = (
            " 0000000000" +
            "\n00000    00" +
            "\n  0000     " +
            "\n    000000 " +
            "\n00      000" +
            "\n0000000000 ");

            return S;
        }

        public string PrintA()
        {
            string A = (
            "  0000000  " +
            "\n 0000 0000 " +
            "\n0000   0000" +
            "\n00000000000" +
            "\n0000   0000" +
            "\n0000   0000");


            return A;
        }


        public string GetTimeAsString(string time)
        {
            string onlyTime = time.Substring(11);

             
            return onlyTime;

        }

        public string GetDateAsString(string Date)
        {
            string onlyDate = Date.Substring(0, 10);

            return onlyDate;
        }

        private static string ReadLine(string text, int lineNumber)
        {
            var reader = new StringReader(text);

            string line;
            int currentLineNumber = -1;

            do
            {
                line = reader.ReadLine();
                currentLineNumber += 1;
                
            }
            while (line != null && currentLineNumber < lineNumber);

            return (currentLineNumber == lineNumber) ? line :
                                                       string.Empty;
        }

        public string PrintHour(int hour)
        {
            
            string firstNum = "";
            string secondNum = "";
            


            string hourToString = hour.ToString();
            if (hourToString.Length == 1)
            {
                hourToString = "0" + hourToString.Substring(0);

            }

            char[] hourToChar = hourToString.ToCharArray();
            if(hourToChar.Length == 2)
            {
                for (int i = 0; i < hourToString.Length; i++)
                {
                    switch (hourToChar[0])
                    {
                        case '0':
                            firstNum = PrintZero();
                            break;
                        case '1':
                            firstNum = PrintOne();
                            break;
                        case '2':
                            firstNum = PrintTwo();
                            break;
                        case '3':
                            firstNum = PrintThree();
                            break;
                        case '4':
                            firstNum = PrintFour();
                            break;
                        case '5':
                            firstNum = PrintFive();
                            break;
                        case '6':
                            firstNum = PrintSix();
                            break;
                        case '7':
                            firstNum = PrintSeven();
                            break;
                        case '8':
                            firstNum = PrintEight();
                            break;
                        case '9':
                            firstNum = PrintNine();
                            break;

                    }


                    switch (hourToChar[1])
                    {
                        case '0':
                            secondNum = PrintZero();
                            break;
                        case '1':
                            secondNum = PrintOne();
                            break;
                        case '2':
                            secondNum = PrintTwo();
                            break;
                        case '3':
                            secondNum = PrintThree();
                            break;
                        case '4':
                            secondNum = PrintFour();
                            break;
                        case '5':
                            secondNum = PrintFive();
                            break;
                        case '6':
                            secondNum = PrintSix();
                            break;
                        case '7':
                            secondNum = PrintSeven();
                            break;
                        case '8':
                            secondNum = PrintEight();
                            break;
                        case '9':
                            secondNum = PrintNine();
                            break;

                    }



                }

            }
            string FinalHour = ""; 


            for (int i = 0; i < 10; i++)
            {
                FinalHour += ReadLine(firstNum, i) + "\t" + ReadLine(secondNum, i) + "\n";

            }
            
            return FinalHour;


        }


        public string PrintMinutes(int minutes)
        {
            string firstNum = "";
            string secondNum = "";



            string minuteToString = minutes.ToString();
            if (minuteToString.Length == 1)
            {
                minuteToString = "0" + minuteToString.Substring(0);

            }
            char[] minuteToChar = minuteToString.ToCharArray();
            if (minuteToChar.Length == 2)
            {
                for (int i = 0; i < minuteToString.Length; i++)
                {
                    switch (minuteToChar[0])
                    {
                        case ' ':
                            firstNum = PrintZero();
                            break;
                        case '0':
                            firstNum = PrintZero();
                            break;
                        case '1':
                            firstNum = PrintOne();
                            break;
                        case '2':
                            firstNum = PrintTwo();
                            break;
                        case '3':
                            firstNum = PrintThree();
                            break;
                        case '4':
                            firstNum = PrintFour();
                            break;
                        case '5':
                            firstNum = PrintFive();
                            break;
                        case '6':
                            firstNum = PrintSix();
                            break;
                        case '7':
                            firstNum = PrintSeven();
                            break;
                        case '8':
                            firstNum = PrintEight();
                            break;
                        case '9':
                            firstNum = PrintNine();
                            break;

                    }


                    switch (minuteToChar[1])
                    {
                        case '0':
                            secondNum = PrintZero();
                            break;
                        case '1':
                            secondNum = PrintOne();
                            break;
                        case '2':
                            secondNum = PrintTwo();
                            break;
                        case '3':
                            secondNum = PrintThree();
                            break;
                        case '4':
                            secondNum = PrintFour();
                            break;
                        case '5':
                            secondNum = PrintFive();
                            break;
                        case '6':
                            secondNum = PrintSix();
                            break;
                        case '7':
                            secondNum = PrintSeven();
                            break;
                        case '8':
                            secondNum = PrintEight();
                            break;
                        case '9':
                            secondNum = PrintNine();
                            break;

                    }



                }

            }
            string FinalMinute = "";


            for (int i = 0; i < 10; i++)
            {
                FinalMinute += ReadLine(firstNum, i) + "\t" + ReadLine(secondNum, i) + "\n";

            }

            return FinalMinute;



        }

        public string PrintSeconds(int seconds)
        {
            string firstNum = "";
            string secondNum = "";



            string secondsToString = seconds.ToString();
            if(secondsToString.Length == 1)
            {
                secondsToString = "0" + secondsToString.Substring(0);

            }


            char[] secondsToChar = secondsToString.ToCharArray();
            if (secondsToChar.Length == 2)
            {
                for (int i = 0; i < secondsToString.Length; i++)
                {
                    switch (secondsToChar[0])
                    {
                        case '0':
                            firstNum = PrintZero();
                            break;
                        case '1':
                            firstNum = PrintOne();
                            break;
                        case '2':
                            firstNum = PrintTwo();
                            break;
                        case '3':
                            firstNum = PrintThree();
                            break;
                        case '4':
                            firstNum = PrintFour();
                            break;
                        case '5':
                            firstNum = PrintFive();
                            break;
                        case '6':
                            firstNum = PrintSix();
                            break;
                        case '7':
                            firstNum = PrintSeven();
                            break;
                        case '8':
                            firstNum = PrintEight();
                            break;
                        case '9':
                            firstNum = PrintNine();
                            break;

                    }


                    switch (secondsToChar[1])
                    {
                        case '0':
                            secondNum = PrintZero();
                            break;
                        case '1':
                            secondNum = PrintOne();
                            break;
                        case '2':
                            secondNum = PrintTwo();
                            break;
                        case '3':
                            secondNum = PrintThree();
                            break;
                        case '4':
                            secondNum = PrintFour();
                            break;
                        case '5':
                            secondNum = PrintFive();
                            break;
                        case '6':
                            secondNum = PrintSix();
                            break;
                        case '7':
                            secondNum = PrintSeven();
                            break;
                        case '8':
                            secondNum = PrintEight();
                            break;
                        case '9':
                            secondNum = PrintNine();
                            break;

                    }



                }

            }
            string FinalSecond = "";


            for (int i = 0; i < 10; i++)
            {
                FinalSecond += ReadLine(firstNum, i) + "\t" + ReadLine(secondNum, i) + "\n";

            }

            return FinalSecond;



        }

        public string PrintDay(string Day)
        {
            
            string firstLetter = "";
            string secondLetter = "";
            string thirdLetter = "";
            string dayAsString = Day.Substring(0, 3);
            char[] dayString = dayAsString.ToCharArray();
            for (int i = 0; i < dayString.Length; i++)
            {
                if (i == 0)
                {
                    switch (dayString[0])
                    {
                        case 'M':
                            firstLetter = PrintM();
                            break;
                        case 'O':
                            firstLetter = PrintO();
                            break;
                        case 'N':
                            firstLetter = PrintN();
                            break;
                        case 'T':
                            firstLetter = PrintT();
                            break;
                        case 'U':
                            firstLetter = PrintU();
                            break;
                        case 'E':
                            firstLetter = PrintE();
                            break;
                        case 'W':
                            firstLetter = PrintW();
                            break;
                        case 'D':
                            firstLetter = PrintD();
                            break;
                        case 'H':
                            firstLetter = PrintH();
                            break;
                        case 'R':
                            firstLetter = PrintR();
                            break;
                        case 'F':
                            firstLetter = PrintF();
                            break;
                        case 'I':
                            firstLetter = PrintI();
                            break;
                        case 'S':
                            firstLetter = PrintS();
                            break;
                        case 'A':
                            firstLetter = PrintA();
                            break;

                    }


                }

                if(i==1)
                {
                    switch (dayString[1])
                    {
                        case 'M':
                            secondLetter = PrintM();
                            break;
                        case 'O':
                            secondLetter = PrintO();
                            break;
                        case 'N':
                            secondLetter = PrintN();
                            break;
                        case 'T':
                            secondLetter = PrintT();
                            break;
                        case 'U':
                            secondLetter = PrintU();
                            break;
                        case 'E':
                            secondLetter = PrintE();
                            break;
                        case 'W':
                            secondLetter = PrintW();
                            break;
                        case 'D':
                            secondLetter = PrintD();
                            break;
                        case 'H':
                            secondLetter = PrintH();
                            break;
                        case 'R':
                            secondLetter = PrintR();
                            break;
                        case 'F':
                            secondLetter = PrintF();
                            break;
                        case 'I':
                            secondLetter = PrintI();
                            break;
                        case 'S':
                            secondLetter = PrintS();
                            break;
                        case 'A':
                            secondLetter = PrintA();
                            break;

                    }

                }

                if(i==2)
                {
                    switch (dayString[2])
                    {
                        case 'M':
                            thirdLetter = PrintM();
                            break;
                        case 'O':
                            thirdLetter = PrintO();
                            break;
                        case 'N':
                            thirdLetter = PrintN();
                            break;
                        case 'T':
                            thirdLetter = PrintT();
                            break;
                        case 'U':
                            thirdLetter = PrintU();
                            break;
                        case 'E':
                            thirdLetter = PrintE();
                            break;
                        case 'W':
                            thirdLetter = PrintW();
                            break;
                        case 'D':
                            thirdLetter = PrintD();
                            break;
                        case 'H':
                            thirdLetter = PrintH();
                            break;
                        case 'R':
                            thirdLetter = PrintR();
                            break;
                        case 'F':
                            thirdLetter = PrintF();
                            break;
                        case 'I':
                            thirdLetter = PrintI();
                            break;
                        case 'S':
                            thirdLetter = PrintS();
                            break;
                        case 'A':
                            thirdLetter = PrintA();
                            break;

                    }
                }

            }

            string FinalDayText = "";


            for (int i = 0; i < 7; i++)
            {
                FinalDayText += "\t\t\t\t\t\t\t\t\t\t\t\t"+ ReadLine(firstLetter, i) + "\t" + ReadLine(secondLetter, i) + "\t" + ReadLine(thirdLetter, i) + "\n";

            }

            return FinalDayText;

        }

        //public string PrintDate(int Day, int Month, int Year)
        //{
        //    string firstNumDay = "";
        //    string secondNumDay = "";
            

        //    string firstNumMonth = "";
        //    string secondNumMonth = "";

        //    string firstNumYear = "";
        //    string secondNumYear = "";


        //    string DayToString = Day.ToString();
        //    char[] DayToStringChar = DayToString.ToCharArray();

        //    if (DayToStringChar.Length == 2)
        //    {
        //        for (int i = 0; i < DayToStringChar.Length; i++)
        //        {
        //            switch (DayToStringChar[0])
        //            {
        //                case ' ':
        //                    firstNumDay = PrintZero();
        //                    break;
        //                case '0':
        //                    firstNumDay = PrintZero();
        //                    break;
        //                case '1':
        //                    firstNumDay = PrintOne();
        //                    break;
        //                case '2':
        //                    firstNumDay = PrintTwo();
        //                    break;
        //                case '3':
        //                    firstNumDay = PrintThree();
        //                    break;
        //                case '4':
        //                    firstNumDay = PrintFour();
        //                    break;
        //                case '5':
        //                    firstNumDay = PrintFive();
        //                    break;
        //                case '6':
        //                    firstNumDay = PrintSix();
        //                    break;
        //                case '7':
        //                    firstNumDay = PrintSeven();
        //                    break;
        //                case '8':
        //                    firstNumDay = PrintEight();
        //                    break;
        //                case '9':
        //                    firstNumDay = PrintNine();
        //                    break;

        //            }

        //            switch (DayToStringChar[1])
        //            {
        //                case '0':
        //                    secondNumDay = PrintZero();
        //                    break;
        //                case '1':
        //                    secondNumDay = PrintOne();
        //                    break;
        //                case '2':
        //                    secondNumDay = PrintTwo();
        //                    break;
        //                case '3':
        //                    secondNumDay = PrintThree();
        //                    break;
        //                case '4':
        //                    secondNumDay = PrintFour();
        //                    break;
        //                case '5':
        //                    secondNumDay = PrintFive();
        //                    break;
        //                case '6':
        //                    secondNumDay = PrintSix();
        //                    break;
        //                case '7':
        //                    secondNumDay = PrintSeven();
        //                    break;
        //                case '8':
        //                    secondNumDay = PrintEight();
        //                    break;
        //                case '9':
        //                    secondNumDay = PrintNine();
        //                    break;

        //            }




        //        }


        //    }

        //    string DayText = "";
        //    for (int i = 0; i < 10; i++)
        //    {
        //        DayText += ReadLine(firstNumDay, i) + "\t" + ReadLine(secondNumDay, i);

        //    }




        //    string MonthToString = Month.ToString();
        //    char[] MonthToStringChar = MonthToString.ToCharArray();

        //    if (MonthToStringChar.Length == 2)
        //    {
        //        for (int i = 0; i < MonthToStringChar.Length; i++)
        //        {
        //            switch (MonthToStringChar[0])
        //            {
        //                case ' ':
        //                    firstNumMonth = PrintZero();
        //                    break;
        //                case '0':
        //                    firstNumMonth = PrintZero();
        //                    break;
        //                case '1':
        //                    firstNumMonth = PrintOne();
        //                    break;
        //                case '2':
        //                    firstNumMonth = PrintTwo();
        //                    break;
        //                case '3':
        //                    firstNumMonth = PrintThree();
        //                    break;
        //                case '4':
        //                    firstNumMonth = PrintFour();
        //                    break;
        //                case '5':
        //                    firstNumMonth = PrintFive();
        //                    break;
        //                case '6':
        //                    firstNumMonth = PrintSix();
        //                    break;
        //                case '7':
        //                    firstNumMonth = PrintSeven();
        //                    break;
        //                case '8':
        //                    firstNumMonth = PrintEight();
        //                    break;
        //                case '9':
        //                    firstNumMonth = PrintNine();
        //                    break;

        //            }

        //            switch (MonthToStringChar[1])
        //            {
        //                case '0':
        //                    secondNumMonth = PrintZero();
        //                    break;
        //                case '1':
        //                    secondNumMonth = PrintOne();
        //                    break;
        //                case '2':
        //                    secondNumMonth = PrintTwo();
        //                    break;
        //                case '3':
        //                    secondNumMonth = PrintThree();
        //                    break;
        //                case '4':
        //                    secondNumMonth = PrintFour();
        //                    break;
        //                case '5':
        //                    secondNumMonth = PrintFive();
        //                    break;
        //                case '6':
        //                    secondNumMonth = PrintSix();
        //                    break;
        //                case '7':
        //                    secondNumMonth = PrintSeven();
        //                    break;
        //                case '8':
        //                    secondNumMonth = PrintEight();
        //                    break;
        //                case '9':
        //                    secondNumMonth = PrintNine();
        //                    break;

        //            }




        //        }


        //    }

        //    string MonthText = "";
        //    for (int i = 0; i < 10; i++)
        //    {
        //        MonthText += ReadLine(firstNumMonth, i) + "\t" + ReadLine(secondNumMonth, i);

        //    }


        //    string YearToString = Year.ToString();
        //    char[] YearToStringChar = YearToString.ToCharArray();

        //    if (YearToStringChar.Length == 2)
        //    {
        //        for (int i = 0; i < YearToStringChar.Length; i++)
        //        {
        //            switch (YearToStringChar[0])
        //            {
        //                case ' ':
        //                    firstNumYear = PrintZero();
        //                    break;
        //                case '0':
        //                    firstNumYear = PrintZero();
        //                    break;
        //                case '1':
        //                    firstNumYear = PrintOne();
        //                    break;
        //                case '2':
        //                    firstNumYear = PrintTwo();
        //                    break;
        //                case '3':
        //                    firstNumYear = PrintThree();
        //                    break;
        //                case '4':
        //                    firstNumYear = PrintFour();
        //                    break;
        //                case '5':
        //                    firstNumYear = PrintFive();
        //                    break;
        //                case '6':
        //                    firstNumYear = PrintSix();
        //                    break;
        //                case '7':
        //                    firstNumYear = PrintSeven();
        //                    break;
        //                case '8':
        //                    firstNumYear = PrintEight();
        //                    break;
        //                case '9':
        //                    firstNumYear = PrintNine();
        //                    break;

        //            }

        //            switch (YearToStringChar[1])
        //            {
        //                case '0':
        //                    secondNumYear = PrintZero();
        //                    break;
        //                case '1':
        //                    secondNumYear = PrintOne();
        //                    break;
        //                case '2':
        //                    secondNumYear = PrintTwo();
        //                    break;
        //                case '3':
        //                    secondNumYear = PrintThree();
        //                    break;
        //                case '4':
        //                    secondNumYear = PrintFour();
        //                    break;
        //                case '5':
        //                    secondNumYear = PrintFive();
        //                    break;
        //                case '6':
        //                    secondNumYear = PrintSix();
        //                    break;
        //                case '7':
        //                    secondNumYear = PrintSeven();
        //                    break;
        //                case '8':
        //                    secondNumYear = PrintEight();
        //                    break;
        //                case '9':
        //                    secondNumYear = PrintNine();
        //                    break;

        //            }




        //        }


        //    }

        //    string YearText = "";
        //    for (int i = 0; i < 10; i++)
        //    {
        //        YearText += ReadLine(firstNumYear, i) + "\t" + ReadLine(secondNumYear, i);

        //    }

        //    string DateText = "";
        //    for (int i = 0; i < 10; i++)
        //    {
                
        //        DateText += ReadLine(DayText, i) + "\t" + ReadLine(MonthText, i) + "\t" + ReadLine(YearText, i) +"\n";

        //    }

        //    return DateText;


        //}


        public void ShowTime()
        {


            while (true)
            {
                var timeNoww = DateTime.Now;
                int day = timeNoww.Day;
                int month = timeNoww.Month;
                int year = timeNoww.Year;
                int hour = timeNoww.Hour;
                int minute = timeNoww.Minute;
                int second = timeNoww.Second;
                string dayOfWeek = System.DateTime.Now.DayOfWeek.ToString().ToUpper();


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                string finalTimeText = "";
                string hourText = PrintHour(hour);
                string minuteText = PrintMinutes(minute);
                string secondsText = PrintSeconds(second);
                string colonText = PrintColon();
                string dayText = PrintDay(dayOfWeek);
                //string dateText = PrintDate(day, month, year);

                for (int i = 0; i < 10; i++)
                {
                    finalTimeText += "\t\t"+ ReadLine(hourText, i) + "\t"+ ReadLine(colonText, i)+ "\t" + ReadLine(minuteText, i) + "\t" + ReadLine(colonText, i) + "\t" + ReadLine(secondsText, i) + "\n";

                }

                Console.WriteLine(finalTimeText);

                Thread.Sleep(1000);
                Console.Clear();

            }
            

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            ThreadStart TS = new ThreadStart(program.ShowTime);
            Thread t = new Thread(TS);
            t.Start();
            Console.ReadLine();


            
        }
    }
}
