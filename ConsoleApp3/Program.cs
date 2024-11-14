namespace ConsoleApp2
{

    public struct Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector operator *(Vector vector, double s)
        {
            return new Vector(vector.x * s, vector.y * s, vector.z * s);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

    }

    public struct Numbers
    {
        
        public int Value { get; set; }

        
        public Numbers(int value)
        {
            Value = value;
        }

       
        public string Two()
        {
            return Convert.ToString(Value, 2); 
        }

   
        public string Eight()
        {
            return Convert.ToString(Value, 8); 
        }


        public string Sixteen()
        {
            return Convert.ToString(Value, 16);
        }

    }
    public struct RGBColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

       
        public RGBColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }


        public string ToHex()
        {
            return "#" + R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
        }


        public string ToHSL()
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            
            double max, min;

            if (r >= g && r >= b)
                max = r;
            else if (g >= r && g >= b)
                max = g;
            else
                max = b;

            if (r <= g && r <= b)
                min = r;
            else if (g <= r && g <= b)
                min = g;
            else
                min = b;

            double h = 0, s = 0, l = (max + min) / 2;

            if (max != min)
            {
                double delta = max - min;
                s = (l > 0.5) ? delta / (2.0 - max - min) : delta / (max + min);
                if (max == r)
                    h = (g - b) / delta + (g < b ? 6 : 0);
                else if (max == g)
                    h = (b - r) / delta + 2;
                else
                    h = (r - g) / delta + 4;

                h /= 6;
            }

          
            return $"{h * 360:F1}°, {s * 100:F1}%, {l * 100:F1}%";
        }

      
        public string ToCMYK()
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

        
            double k;

            if (r >= g && r >= b)
                k = 1 - r;
            else if (g >= r && g >= b)
                k = 1 - g;
            else
                k = 1 - b;

            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            if (k == 1)
            {
                c = 0;
                m = 0;
                y = 0;
            }

           
            return $"{c * 100:F1}%, {m * 100:F1}%, {y * 100:F1}%, {k * 100:F1}%";
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
