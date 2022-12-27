using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorConverter
{
    public struct CMYK
    {
        public string text;
        public double c;
        public double m;
        public double y;
        public double k;
    }

    public struct HSL
    {
        public string text;
        public double h;
        public double s;
        public double l;
    }

    public struct HSV
    {
        public string text;
        public double h;
        public double s;
        public double v;
    }

    //  Convert RGB to CMYK
    public static CMYK RGBtoCMYK(int red, int green, int blue)
    {
        double r_ = (double)red / 255;
        double g_ = (double)green / 255;
        double b_ = (double)blue / 255;

        double k = 1 - Math.Max(r_, Math.Max(g_, b_));
        double c = (1 - r_ - k) / (1 - k);
        double m = (1 - g_ - k) / (1 - k);
        double y = (1 - b_ - k) / (1 - k);

        if (k == 1)
        {
            c = 0;
            m = 0;
            y = 0;
        }

        var cmykResult = new CMYK
        {
            text = "CMYK(" + Math.Round((c * 100)) + "%," + Math.Round((m * 100)) + "%," + Math.Round((y * 100)) + "%," + Math.Round((k * 100)) + "%)",
            c = c,
            m = m,
            y = y,
            k = k
        };

        return cmykResult;
    }

    //  Convert RGB to HSL
    public static HSL RGBtoHSL(int red, int green, int blue)
    {
        double r_ = (double)red / 255;
        double g_ = (double)green / 255;
        double b_ = (double)blue / 255;

        double Cmax = Math.Max(r_, Math.Max(g_, b_));
        double Cmin = Math.Min(r_, Math.Min(g_, b_));

        double delta = Cmax - Cmin;

        double h = 0;
        double s = 0;
        double l = (Cmax + Cmin) / 2;

        if (delta == 0)
        {
            h = 0;
        }
        else if (Cmax == r_)
        {
            h = 60 * (((g_ - b_) / delta) % 6);
        }
        else if (Cmax == g_)
        {
            h = 60 * (((b_ - r_) / delta) + 2);
        }
        else if (Cmax == b_)
        {
            h = 60 * (((r_ - g_) / delta) + 4);
        }

        if (h < 0)
        {
            h += 360;
        }

        if (delta == 0)
        {
            s = 0;
        }
        else
        {
            s = delta / (1 - Math.Abs(2 * l - 1));
        }

        var hslResult = new HSL
        {
            text = "HSL(" + Math.Round(h) + "°," + Math.Round((s * 100)) + "%," + Math.Round((l * 100)) + "%)",
            h = h,
            s = s,
            l = l
        };

        return hslResult;
    }

    //  Convert RGB to HSV
    public static HSV RGBtoHSV(int red, int green, int blue)
    {
        double r_ = (double)red / 255;
        double g_ = (double)green / 255;
        double b_ = (double)blue / 255;

        double Cmax = Math.Max(r_, Math.Max(g_, b_));
        double Cmin = Math.Min(r_, Math.Min(g_, b_));

        double delta = Cmax - Cmin;

        double h = 0;
        double s = 0;
        double v = Cmax;

        if (delta == 0)
        {
            h = 0;
        }
        else if (Cmax == r_)
        {
            h = 60 * (((g_ - b_) / delta) % 6);
        }
        else if (Cmax == g_)
        {
            h = 60 * (((b_ - r_) / delta) + 2);
        }
        else if (Cmax == b_)
        {
            h = 60 * (((r_ - g_) / delta) + 4);
        }

        if (h < 0)
        {
            h += 360;
        }

        if (delta == 0)
        {
            s = 0;
        }
        else
        {
            s = delta / v;
        }

        var hsvResult = new HSV
        {
            text = "HSV(" + Math.Round(h) + "°," + Math.Round((s * 100)) + "%," + Math.Round((v * 100)) + "%)",
            h = h,
            s = s,
            v = v
        };

        return hsvResult;
    }
}
