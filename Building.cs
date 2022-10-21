using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        string address;
        int lenght;
        int width;
        int height;

        string Address
        {
            get
            { return address; }
            set
            {
                address = value;
            }
        }
        int Lenght
        {
            get { return lenght; }
            set
            {
                if (value > 0)
                    lenght = value;
                else
                    lenght = 1;
            }
        }
        int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    width = 1;
            }
        }
         int Height
        {
            get { return height; }

            set
            {
                if (value > 0)
                    height = value;
                else
                    height = 1;
            }
        }

        public Building(string a, int l, int w, int h)
        {
            Address = a;
            Lenght = l;
            Width = w;
            Height = h; 
        }
        public string Print()
        {
            return $"Адрес:{Address}, Длина: {Lenght}, Ширина: {Width}, Высота: {Height}";
        }
    }
}
