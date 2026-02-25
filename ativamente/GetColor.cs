using System.Drawing;
using System;

class Program {
    static void Main() {
        Bitmap b = new Bitmap(@"c:\Users\Admin\Documents\Maiara\Antigravity\imagens\mockup.png");
        Color c = b.GetPixel(0, 0); // Top-left pixel
        Color cr = b.GetPixel(b.Width - 1, b.Height - 1); // Bottom-right pixel
        Console.WriteLine("TL: " + c.R + "," + c.G + "," + c.B);
        Console.WriteLine("BR: " + cr.R + "," + cr.G + "," + cr.B);
    }
}
