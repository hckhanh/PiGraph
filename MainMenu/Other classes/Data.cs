using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using PixelsGraph;
using Telerik.WinControls;

namespace PixelsGraph
{
    class Data
    {
        public Data()
        {
            FunctionList = new BindingSource();
        }

        public BindingSource FunctionList
        {
            get;
            set;
        }

        public bool Save(string FileName)
        {
            bool flag = true;
            StreamWriter writer = null;
            try
            {
                if (File.Exists(FileName))
                {
                    writer = new StreamWriter(File.Open(FileName, FileMode.Truncate), Encoding.UTF8);
                }
                else
                {
                    writer = new StreamWriter(File.Open(FileName, FileMode.CreateNew), Encoding.UTF8);
                }

                foreach (Function f in FunctionList)
                {
                    string s = string.Format("{0},{1},{2},{3},{4}", (int)f.FunctionType, (int)f.FunctionForm, f.Color.ToArgb(), f.Note, f.Values.Length);

                    foreach (float value in f.Values)
                    {
                        s += string.Format(",{0}", value);
                    }
                    writer.WriteLine(s);
                }

            }
            catch (Exception e)
            {
                flag = false;
                RadMessageBox.Show(string.Format("Không thể ghi dữ liệu vào tệp!\r\n\r\nLỗi: {0}", e.Message), "Lỗi", MessageBoxButtons.OK, RadMessageIcon.Error);
                return flag;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return flag;
        }

        public bool Load(string FileName)
        {
            if (!File.Exists(FileName))
            {
                return false;
            }

            bool flag = true;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.OpenRead(FileName));
            }
            catch (Exception e)
            {
                RadMessageBox.Show(string.Format("Không thể mở tệp!\r\n\r\nLỗi: {0}\r\nĐường dẫn: {1}", e.Message, FileName), "Lỗi", MessageBoxButtons.OK, RadMessageIcon.Error);
                return false;
            }

            string a = null;

            try
            {
                do
                {
                    a = reader.ReadLine();
                    if (string.IsNullOrEmpty(a))
                    {
                        break;
                    }
                    string[] functionStrings = a.Split(',');

                    Function funct = new Function();

                    LoaiHam type = (LoaiHam)int.Parse(functionStrings[0]);
                    funct.FunctionForm = (DangHam)int.Parse(functionStrings[1]);
                    funct.Color = Color.FromArgb(int.Parse(functionStrings[2]));
                    funct.Note = functionStrings[3];
                    int n = int.Parse(functionStrings[4]);

                    float[] values = new float[n];
                    for (int i = 0; i < n; i++)
                    {
                        values[i] = float.Parse(functionStrings[5 + i]);
                    }
                    funct.SetFunctionParamsAndType(type, values);

                    FunctionList.Add(funct);
                } while (a != null);


            }
            catch (Exception e)
            {
                flag = false;
                RadMessageBox.Show(string.Format("Dữ liệu trong tệp không đúng định dạng hoặc đã bị lỗi!\r\n\r\nLỗi: {0}", e.Message), "Lỗi", MessageBoxButtons.OK, RadMessageIcon.Error);
                FunctionList.Clear();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return flag;
        }

        public void Clear()
        {
            if (FunctionList != null)
            {
                FunctionList.Clear();
            }
        }
    }
}
