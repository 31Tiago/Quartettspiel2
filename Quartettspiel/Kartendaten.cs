using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Quartettspiel
{
    public class Kartendaten
    {

        List<Bitmap> bild = new List<Bitmap>();
        List<int> hubraum = new List<int>();
        List<int> ps = new List<int>();
        List<int> hoechstgeschwindigkeit = new List<int>();
        List<int> zyilinder = new List<int>();
        public Kartendaten(int pnummer) 
        {

            nummer = pnummer;

        }
        public int nummer;
        void ErstelleKartenDaten()
        {
            bild.Add(new Bitmap(""));
        }
    }
}