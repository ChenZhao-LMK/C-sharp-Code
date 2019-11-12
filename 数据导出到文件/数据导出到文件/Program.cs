using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Matlab;
using System.Numerics;

namespace 数据导出到文件
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 保存txt文件格式

            //decimal[] myValue = new decimal[] { 1.111111888m, 2.111111888m, 3.111111888m, 4.111111888m };
            //double[] myValueDb = new double[myValue.Length];
            //for (int i = 0; i < myValue.Length; i++)
            //{
            //    myValueDb[i] = (double)decimal.Round(myValue[i], 6);
            //}
            //string[] mydateTime = new string[] { DateTime.Now.ToString("F"), DateTime.Now.ToString("F"), DateTime.Now.ToString("F"), DateTime.Now.ToString("F") };

            //string fileName = @"C:\Users\asus\Desktop\1.txt";
            //using (FileStream fs = File.Open(fileName, FileMode.Create))
            //{

            //    StreamWriter sw = new StreamWriter(fs);
            //    sw.Write("序号|");
            //    sw.Write("          时间           |");
            //    sw.WriteLine("   值    ");
            //    sw.WriteLine();
            //    for (int i = 0; i < myValue.Length; i++)
            //    {
            //        sw.Write(" " + (i + 1) + "  |" + mydateTime[i].ToString() + "   |");
            //        sw.WriteLine("   " + myValueDb[i].ToString());
            //    }
            //    sw.Flush();
            //    sw.Close();
            //}

            #endregion

            #region 保存csv文件格式
            //string[] mydateTime = new string[] { DateTime.Now.ToString("F"), DateTime.Now.ToString("F"), DateTime.Now.ToString("F"), DateTime.Now.ToString("F") };
            //decimal[] myValue = new decimal[] { 1.1111118m, 2.1111118m, 3.1111118m, 4.1111118m };
            //double[] myValueDb = new double[myValue.Length];

            //for (int i = 0; i < myValue.Length; i++)
            //{
            //    myValueDb[i] = (double)decimal.Round(myValue[i], 6);
            //}

            //string fileName = @"C:\Users\asus\Desktop\1.csv";
            //StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);

            //sw.Write("序号" + "," + "时间" + "," + "值");
            //sw.Write(Environment.NewLine);
            //for (int i = 0; i < myValue.Length; i++)
            //{
            //    sw.Write((i + 1) + "," + mydateTime[i] + "," + myValueDb[i]);
            //    sw.Write(Environment.NewLine);
            //}

            //sw.Flush();
            //sw.Close();
            #endregion

            #region 保存mat格式

            FileStream fs = File.Create(@"C:\Users\asus\Desktop\collection2.mat");
            fs.Close();
            double[] X = new double[] { 1.1111118f, 2.1111118f, 3.1111118f, 4.1111118f, 5.1111118f };
            double[] Y = new double[] { 9.1111118f, 9.1111118f, 9.1111118f, 9.1111118f, 10.1111118f};
            double[,] X_Y = new double[5, 2];
            for (int i = 0; i < X.Length; i++)
            {

                X_Y[i, 0] = Math.Round(X[i], 7);
                X_Y[i, 1] = Math.Round(Y[i], 7);

            }
            var mb = Matrix<double>.Build;


            var myMatrix = mb.Dense(X.Length, 2, (i, j) => X_Y[i, j]);
            MatlabWriter.Write<double>(@"C:\Users\asus\Desktop\collection2.mat", myMatrix, "a");
            Console.WriteLine(myMatrix.ToString("0.000000"));
            Console.ReadKey();

            #endregion

        }
    }
}
