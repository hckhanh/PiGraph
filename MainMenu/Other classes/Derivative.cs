using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PixelsGraph
{
    class Derivative
    {
        /// <summary>
        /// List factors luu danh sach cac he so.
        /// List extremalPoint luu danh sach cac cuc tri.
        /// Type la loai ham:
        /// 1: bac 1
        /// 2: bac 2
        /// 3: bac 3
        /// 4: bac 4 trung phuong
        /// 5: bac 1 / bac 1
        /// </summary>
        List<float> factors;
        List<PointF> extremalPoint;
        int type;
        public Derivative()
        {
            factors = new List<float>();
            extremalPoint = new List<PointF>();
            type = 0;
        }
        //Dao ham
        public Derivative calDerivative()
        {
            Derivative temp = new Derivative();
            if (type == 2)
            {
                temp.factors.Add(factors[0] * 2);
                temp.factors.Add(factors[1]);
                temp.type = 1;
                return temp;
            }
            if (type == 3)
            {
                temp.factors.Add(factors[0] * 3);
                temp.factors.Add(factors[1] * 2);
                temp.factors.Add(factors[2]);
                temp.type = 2;
                return temp;
            }
            if (type == 4)
            {
                temp.factors.Add(factors[0] * 4);
                temp.factors.Add(0);
                temp.factors.Add(factors[1] * 2);
                temp.type = 3;
                return temp;
            }
            if (type == 5)//Gia tri tra ve cua ham nay la mau so cua dao ham
            {
                temp.factors.Add(factors[2] * factors[2]);
                temp.factors.Add(factors[2] * factors[3] * 2);
                temp.factors.Add(factors[3] * factors[3]);
                temp.type = 2;
                return temp;
            }
            return temp;
        }
        //Tim nhung diem cuc tri
        public void ExtremalPoint()
        {
            //     Derivative temp = new Derivative();
            //     PointF rp1 = new PointF(0, 0);
            //     PointF rp2 = new PointF(0, 0);
            //     PointF rp3 = new PointF(0, 0);
            //     temp = this.calDerivative();
            //     if (type == 2)//ham bac 2
            //     {
            //         rp1.X = -temp.factors[1] / temp.factors[0];
            //         rp2.Y = factors[0] * rp1.Y * rp1.X + factors[1] * rp1.X + factors[2];
            //         this.extremalPoint.Add(rp1);
            //     }
            //     if (type == 3)//ham bac 3
            //     {
            //         if (temp.SolveP2(ref rp1.X, ref rp2.X) == 2)
            //         {
            //             rp1.Y = factors[0] * rp1.X * rp1.X * rp1.X + factors[1] * rp1.X * rp1.X + factors[2] * rp1.X + factors[3];
            //             rp2.Y = factors[0] * rp2.X * rp2.X * rp2.X + factors[1] * rp2.X * rp2.X + factors[2] * rp2.X + factors[3];
            //             this.extremalPoint.Add(rp1);
            //             this.extremalPoint.Add(rp2);
            //         }
            //     }
            //     if (type == 4)//ham bac 4 trung phuong
            //     {
            //         temp.type = 2;
            //         if (temp.SolveP2(ref rp1.X, ref rp2.X) == 2)
            //         {
            //             rp1.Y = factors[0] * rp1.X * rp1.X * rp1.X * rp1.X + factors[1] * rp1.X * rp1.X + factors[2];
            //             rp2.Y = factors[0] * rp2.X * rp2.X * rp2.X * rp2.X + factors[1] * rp2.X * rp2.X + factors[2];
            //             rp3.X = 0; rp3.Y = factors[2];
            //             this.extremalPoint.Add(rp1);
            //             this.extremalPoint.Add(rp2);
            //             this.extremalPoint.Add(rp3);
            //         }
            //         else
            //         {
            //             rp1.X = 0; rp1.Y = factors[2];
            //             this.extremalPoint.Add(rp1);
            //         }
            //     }
            // }
            ////Giai ptb2 gia tri tra ve la so nghiem
            //private int SolveP2(ref float x1,ref float x2)
            // {
            //     double delta = factors[1]*factors[1]- 4 * factors[0] * factors[2];
            //     if (delta < 0)
            //         return 0;
            //     else if (delta == 0)
            //     {
            //         x1 = -factors[1] / (2 * factors[0]);
            //         return 1;
            //     }
            //     else
            //     {
            //         x1 = (-factors[1] + (float)Math.Sqrt(delta)) / (2 * factors[0]);
            //         x2 = (-factors[1] - (float)Math.Sqrt(delta)) / (2 * factors[0]);
            //         return 2;
            //     }
        }

        //static void Main()
        //{
        //    Derivative test = new Derivative();
        //    Derivative result = new Derivative();

        //    test.factors.Add(1);
        //    test.factors.Add(8);
        //    test.factors.Add(10);
        //    test.type = 4;
        //    result = test.Derivative();
        //    test.ExtremalPoint();
        //}
    }
}
