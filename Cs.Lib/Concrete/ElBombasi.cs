using Cs.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class ElBombasi : Firlatilan
    {
        public ElBombasi()
        {
            this.Fiyat = 350;
            this.Hasar = 80;
            this.SilahResmi.Image = Properties.Resources.Bomba;
            this.Ulke = "Türkiye";
        }
        public override int Firlat()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bomb);
            soundPlayer.Play();
            Thread.Sleep(500);

            return Hasar;
        }
    }
}
