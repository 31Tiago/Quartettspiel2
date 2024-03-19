using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quartettspiel
{
    public class Kartendeck
    {
        List<Bitmap> bild = new List<Bitmap>();
        List<int> hubraum = new List<int>();
        List<int> ps = new List<int>();
        List<int> hoechstgeschwindigkeit = new List<int>();
        List<int> zyilinder = new List<int>();
        List<Karte> Deckliste = new List<Karte>();
        void ErstelleDeck()
        {
            



            for (int i = 0; i < 16; i++)
            {
               
                Karte karte1 = new Karte(i, bild[i], hoechstgeschwindigkeit[i], ps[i], zyilinder[i], hubraum[i]);
                Deckliste.Add(karte1);
            }
        }
        void FuegeListeEin()
        {
            //1
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //2
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //3
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //4
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //5
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //6
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //7
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //8
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //9
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //10
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //11
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //12
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //13
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //14
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //15
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
            //16
            bild.Add("");
            hubraum.Add();
            ps.Add();
            hoechstgeschwindigkeit.Add();
            zyilinder.Add();
        }
        public int deck
        {
            get => default;
            set
            {
            }
        }

        public int anzahlkarten
        {
            get => default;
            set
            {
            }
        }

        public int deckliste
        {
            get => default;
            set
            {
            }
        }

        public void KartenMischen()
        {
            throw new System.NotImplementedException();
        }

        public void KartenAufteilen()
        {
            throw new System.NotImplementedException();
        }
    }
}