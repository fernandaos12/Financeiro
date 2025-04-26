namespace Financeiro.Domain.Services
{
    public class QRCodeCodBarrasService
    {
        //           foreach (var item in retorno)
        //         { 
        //       if (item.LinhaDigitavel.Length <= 1)
        //       {
        //           throw new Exception("Erro ao processar a fatura. Dados insuficientes ou inválidos. Verifique gateway de pagamento.");
        //     }

        //       try
        //       {

        //           if (item.LinhaDigitavel != null)
        //           {
        //               var linha_digitavel = item.LinhaDigitavel;

        //     //gerar codigo de barras da fatura 
        //     BarcodeWriterPixelData barcodewriter = new BarcodeWriterPixelData();
        //     barcodewriter.Format = BarcodeFormat.CODE_128;
        //               barcodewriter.Options = new ZXing.Common.EncodingOptions
        //               {
        //                   Height = 50,
        //                   Width = 900,
        //                   PureBarcode = false,
        //                   Margin = 1
        //               };

        // String linhadigitavelretorno = Convert.ToString(linha_digitavel);

        // var codigo = barcodewriter.Write(linhadigitavelretorno);
        // var bitmap = new Bitmap(codigo.Width, codigo.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        // var ms = new System.IO.MemoryStream();
        // var bitmapData = bitmap.LockBits(new Rectangle(0, 0, codigo.Width, codigo.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

        // try
        // {
        //     System.Runtime.InteropServices.Marshal.Copy(codigo.Pixels, 0, bitmapData.Scan0, codigo.Pixels.Length);
        // }
        // finally
        // {
        //     bitmap.UnlockBits(bitmapData);
        // }

        // bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

        // ViewBag.CodigoBarras = "data:image/jpeg;base64," + Convert.ToBase64String(ms.ToArray());

        // //QRcode
        // var qrcode = Qqrcode(Convert.ToString(item.LinhaDigitavel));
        // ViewBag.QRCode = qrcode;

        // ViewBag.LinhaDigitavel = linha_digitavel;

        // ViewBag.IdFaturamentoCliente = Ids_Faturamento_Cliente;
        //           }

        //       }
        //       catch (Exception ex)
        //       {
        //           throw new Exception(ex.Message);
        //       }


        //         private byte[] Qqrcode(string text)

        // //Gera QRCode da fatura
        // {
        //     Byte[] byteArray;
        //     var width = 100;
        //     var height = 100;
        //     var margin = 0;
        //     var qrCodeWriter = new ZXing.BarcodeWriterPixelData
        //     {
        //         Format = ZXing.BarcodeFormat.QR_CODE,
        //         Options = new QrCodeEncodingOptions
        //         {
        //             Height = height,
        //             Width = width,
        //             Margin = margin
        //         }
        //     };
        //     var qrCodepxl = qrCodeWriter.Write(text);
        //     var bitmapQrcode = new Bitmap(qrCodepxl.Width, qrCodepxl.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

        //     using (var ms = new System.IO.MemoryStream())
        //     {
        //         var bitmapDataQrcode = bitmapQrcode.LockBits(new Rectangle(0, 0, qrCodepxl.Width, qrCodepxl.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

        //         try
        //         {
        //             System.Runtime.InteropServices.Marshal.Copy(qrCodepxl.Pixels, 0, bitmapDataQrcode.Scan0, qrCodepxl.Pixels.Length);
        //         }
        //         finally
        //         {
        //             bitmapQrcode.UnlockBits(bitmapDataQrcode);
        //         }

        //         bitmapQrcode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //         byteArray = ms.ToArray();
        //         var resultado = "data:image/jpeg;base64," + Convert.ToBase64String(ms.ToArray());

        //         return byteArray;
        //     }
    }
}
