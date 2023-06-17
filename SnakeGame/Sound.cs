using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace SnakeGame
{
    class Sound
    {

        public void SoundPlayerEat()
        {

            SoundPlayer soundPlayer = new SoundPlayer();

            soundPlayer.SoundLocation = "@C:\\Users\\Александр\\source\\repos\\Game_CSharp\\SnakeGame\\Sound\\ukus-zvonkiy.wav";
            soundPlayer.Play();




        }



        
            
            




    }
}
