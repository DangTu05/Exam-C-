using System;

public class PTBH
{
    private double a, b, c;

    public PTBH(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public bool Giai(out double x1, out double x2, out string ketQua)
    {
        x1 = x2 = 0;
        if (a == 0)
        {
            if (b == 0)
            {
                ketQua = (c == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                return false;
            }
            else
            {
                x1 = -c / b;
                ketQua = $"Nghiệm x = {x1:0.##}";
                return true;
            }
        }

        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            ketQua = "Phương trình vô nghiệm";
            return false;
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            ketQua = $"Nghiệm kép x = {x1:0.##}";
            return true;
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            ketQua = $"Nghiệm x1 = {x1:0.##}, x2 = {x2:0.##}";
            return true;
        }
    }
}
