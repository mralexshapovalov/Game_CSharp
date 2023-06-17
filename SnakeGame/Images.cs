﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace SnakeGame
{
    public  static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("apple.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");

        private static ImageSource LoadImage(string fillName) => new BitmapImage(new Uri($"Sprite/{fillName}", UriKind.Relative)); 

        //Здесь происходит загрузка спрайтов в проект
    }
}
