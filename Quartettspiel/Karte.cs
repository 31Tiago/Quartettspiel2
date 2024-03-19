using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Quartettspiel
{
    public class Karte
    {
        public Karte(int pnummer, Bitmap pbild, int phoechstgeschwindigkeit, int pps, int pzylinder, int phubraum) 
        {
            nummer = pnummer;
            bild = pbild;
            hoechstgeschwindigkeit = phoechstgeschwindigkeit;
            ps = pps;
            zylinder = pzylinder;
            hubraum = phubraum;

        }  
        private int nummer;
        public Bitmap bild
        {
            get => default;
            set
            {
            }
        }

        public int hoechstgeschwindigkeit
        {
            get => default;
            set
            {
            }
        }
        public int hubraum
        {
            get => default;
            set
            {
            }
        }

        public int ps
        {
            get => default;
            set
            {
            }
        }

        public int zylinder
        {
            get => default;
            set
            {
            }
        }
    }
}