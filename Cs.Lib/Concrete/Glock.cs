﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class Glock : Tabanca
    {

        public Glock()
        {
            this.Fiyat = 200m;
            this.Ulke = "Avusturya";
            this._sarjorKapasitesi = 24;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.Glock;
            this.Hasar = 24;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Glock_Ates);
                soundPlayer.Play();
                Thread.Sleep(300);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(100);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {

            new SoundPlayer(Properties.Resources.Glock_Reload).Play();
            Thread.Sleep(1000);
            this._kalanFisek = this.SarjorKapatisesi;
            return KalanFisek;
        }
    }


}

