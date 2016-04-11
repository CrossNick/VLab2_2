using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLab2_2
{
    class Oct
    {
        private string num;

        public Oct()
        {
            num = "0";
        }
        public Oct(string s)
        {
            this.Num = s;
        }

        public static bool operator == (Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) == Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }
        public static bool operator !=(Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) != Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }
        public static bool operator >(Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) > Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }
        public static bool operator <(Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) < Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }
        public static bool operator >=(Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) >= Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }
        public static bool operator <=(Oct o1, Oct o2)
        {
            if (Convert.ToInt32(o1.num) <= Convert.ToInt32(o2.num))
                return true;
            else
                return false;
        }

        public int toDex()
        {
            int dex=0, octx=Convert.ToInt32(num);
            int len = num.Length;
            for(int i = 0;i< len;i++)
            {
                dex += (octx%10) * Convert.ToInt32(Math.Pow(8, i));
                octx /= 10;
            }
            return dex;
        }

        public string Num
        {
            get
            {
                return num;
            }
            set
            {
                bool chk = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(value[i]) == 8 || Convert.ToInt32(value[i]) == 9)
                    {
                        chk = false;
                    }
                }
                if (chk == true)
                    num = value;
                else
                    throw new FormatException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Oct oct = new Oct();
            Console.WriteLine("Введите восьмеричное число:");
            oct.Num = Console.ReadLine();
            int dex = oct.toDex();
            Console.WriteLine("Число в десятично форме:");
            Console.WriteLine(dex);

        }
    }
}
