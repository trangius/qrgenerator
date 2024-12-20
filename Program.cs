using System;
using QRCoder;
using SkiaSharp;

class Program
{
    static void Main()
    {
        string url = "https://www.sativada.se";

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

        PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeImage = qrCode.GetGraphic(20);

        System.IO.File.WriteAllBytes("qr_code.png", qrCodeImage);
        Console.WriteLine("QR-kod genererad och sparad som qr_code.png");
    }
}
