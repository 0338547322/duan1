using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
        { 
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5D",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71C46"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            // Nếu Hệ số hiệu chỉnh (correctionFactor) nhỏ hơn 0, màu sẽ đậm hơn
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red = red * correctionFactor;
                green = green * correctionFactor;
                blue = blue * correctionFactor;
            }
            else
            {
                // Nếu Hệ số hiệu chỉnh (correctionFactor) lớn hơn 0, hãy làm sáng màu
                red = (225 - red) * correctionFactor + red;
                green = (225 - green) * correctionFactor + green;
                blue = (225 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
