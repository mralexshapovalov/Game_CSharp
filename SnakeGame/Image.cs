using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace SnakeGame
{
    public  class Image
    {
        public readonly static ImageSource Empty = LoadImage("");
        public readonly static ImageSource Body = LoadImage("body_horizontal.png");
        public readonly static ImageSource Head = LoadImage("head_up.png");
        public readonly static ImageSource Food = LoadImage("apple.png");
        public readonly static ImageSource DeadBody = LoadImage("");
        public readonly static ImageSource DeadHead = LoadImage("");

        private static ImageSource LoadImage(string fillName)
        {
            return new BitmapImage(new Uri($"Sprite/{fillName}", UriKind.Relative));
        }
    }
}
