using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presents
{
    class ThirdPresent : Presents
    {
        public Bitmap img;
        public string imgPath;
        public override void DrawPresent()
        {
            imgPath = @"D:\Унiвер\2 курс\ООП\Лабораторна робота №5\lab5_forGit\presents\presents\present3.png";
            img = new Bitmap(imgPath);
        }
        public override void Find_Not_My_Present()
        {
            imgPath = @"D:\Унiвер\2 курс\ООП\Лабораторна робота №5\lab5_forGit\presents\presents\sad.gif";
            img = new Bitmap(imgPath);
        }

        public override void Find_My_Present()
        {
            imgPath = @"D:\Унiвер\2 курс\ООП\Лабораторна робота №5\lab5_forGit\presents\presents\thanks.gif";
            img = new Bitmap(imgPath);
        }
    }
}
