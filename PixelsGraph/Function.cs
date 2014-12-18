using System.Drawing;

namespace PixelsGraph
{
    /// <summary>
    /// Lớp chứa các dữ liệu về hàm số.
    /// </summary>
    public class Function
    {
        #region Attributes

        /// <summary>
        /// Chuỗi thể hiện cho phương trình hàm số.
        /// </summary>
        string functionString;
        /// <summary>
        /// Kiểu hàm số.
        /// </summary>
        LoaiHam typeOfFunction;
        /// <summary>
        /// Dạng hàm của hàm số: y = f(x), y = f(|x|), y = |f(x)|
        /// </summary>
        DangHam functionForm;
        /// <summary>
        /// Các thông số của hàm số.
        /// </summary>
        float[] values;
        /// <summary>
        /// Màu sắc của hàm số.
        /// </summary>
        Color colorOfFunction;
        /// <summary>
        /// Ghi chú cho hàm số.
        /// </summary>
        string note;

        public static readonly Function Empty;

        #endregion

        #region Methods

        /// <summary>
        /// Hàm khởi tạo các giá trị cho hàm số.
        /// </summary>
        public Function()
        {
            this.functionString = null;
            this.typeOfFunction = PixelsGraph.LoaiHam.Undefined;
            this.functionForm = DangHam.NonAbs;
            this.values = null;
            this.colorOfFunction = Color.Empty;
        }

        /// <summary>
        /// Hàm khởi tạo các giá trị cho hàm số.
        /// </summary>
        /// <param name="FunctionString">Chuỗi thể hiện cho phương trình hàm số.</param>
        /// <param name="color">Màu sắc của hàm số.</param>
        /// <param name="type">Kiểu hàm số.</param>
        /// <param name="form">Dạng hàm số.</param>
        /// <param name="discontinuited">Nếu hàm số là đường thẳng (hàm số bậc nhất),
        /// biến thể hiện đường thẳng có phải là đứt nét hay không.
        /// Lưu ý: biến chỉ nhận giá trị truyền vào nếu hàm số là đường thẳng (hàm bậc nhất).</param>
        /// <param name="values">Các thông số của hàm số.</param>
        public Function(Color color, LoaiHam type, DangHam form, bool discontinuited,
            string note, params float[] values)
        {
            this.functionString = Function.Format(type, values);
            this.typeOfFunction = type;
            this.functionForm = form;
            this.note = note;
            this.values = values;
            this.colorOfFunction = color;
        }

        /// <summary>
        /// Gán đối số và loại hàm của hàm đó.
        /// </summary>
        /// <param name="functionType">Kiểu hàm</param>
        /// <param name="Params">Các đối số của hàm</param>
        /// <returns>Trả về true nếu hàm không gặp lỗi, ngược lại trả về false.</returns>
        public bool SetFunctionParamsAndType(LoaiHam functionType, float[] Params)
        {
            if (Params == null)
            {
                return false;
            }

            try
            {
                functionString = Format(functionType, Params);
            }
            catch
            {
                return false;
            }

            values = Params;
            this.typeOfFunction = functionType;

            return true;
        }

        /// <summary>
        /// Gán thông số hàm từ hàm này sang hàm khác.
        /// </summary>
        /// <param name="funct">Hàm số cần lấy giá trị.</param>
        /// <returns>Phương thức trả về true nếu không gặp lỗi, ngược lại trả về false.</returns>
        public bool SetFunctionParamsAndType(Function funct)
        {
            if (funct == null)
            {
                return false;
            }

            try
            {
                functionString = Format(funct.typeOfFunction, funct.values);
            }
            catch
            {
                return false;
            }

            values = funct.values;
            this.typeOfFunction = funct.typeOfFunction;

            return true;
        }

        /// <summary>
        /// Phương thức tính hệ số góc tiếp tuyến của hàm số.
        /// </summary>
        /// <param name="TangentialPoint">Tiếp điểm của hàm số</param>
        /// <param name="TangetialLineFunction">Biến truyền vào là một hàm bậc nhất kiểu Function.</param>
        public void ComputeTangentialLine(PointF TangentialPoint, ref Function TangetialLineFunction)
        {
            float[] Params = new float[2];

            switch (FunctionType)
            {
                case LoaiHam.BacHai:
                    Params[0] = 2 * Values[0] * TangentialPoint.X + Values[1];//tính đạo hàm
                    Params[1] = Params[0] * -1 * TangentialPoint.X + TangentialPoint.Y;
                    break;
                case LoaiHam.BacBa:
                    Params[0] = 3 * Values[0] * TangentialPoint.X * TangentialPoint.X + 2 * Values[1] * TangentialPoint.X + Values[2];//tính đạo hàm
                    Params[1] = Params[0] * -1 * TangentialPoint.X + TangentialPoint.Y;
                    break;
                case LoaiHam.TrungPhuong:
                    Params[0] = 4 * Values[0] * TangentialPoint.X * TangentialPoint.X * TangentialPoint.X + 2 * Values[1] * TangentialPoint.X + Values[2];//tính đạo hàm
                    Params[1] = Params[0] * -1 * TangentialPoint.X + TangentialPoint.Y;
                    break;
            }

            TangetialLineFunction.SetFunctionParamsAndType(LoaiHam.BacNhat, Params);
        }

        /// <summary>
        /// Lấy chuỗi thể hiện cho phương trình hàm số.
        /// </summary>
        /// <returns>Trả về chuỗi thể hiện cho phương trình hàm số.</returns>
        public override string ToString()
        {
            return functionString;
        }

        public override bool Equals(object obj)
        {
            Function temp = obj as Function;
            if (temp != null)
            {
                return this.functionString == temp.functionString;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Static Methods

        /// <summary>
        /// Trả về chuỗi thể hiện cho phương trình hàm số thông qua loại hàm số và các thông số tương ứng.
        /// </summary>
        /// <param name="functionType">Kiểu hàm số.</param>
        /// <param name="Params">Các thông số của hàm số.</param>
        /// <returns>Trả về chuỗi thể hiện cho phương trình hàm số.</returns>
        public static string Format(LoaiHam functionType, params float[] Params)
        {
            switch (functionType)
            {
                case LoaiHam.BacNhat:
                    {
                        return "y = " + FunctionFormat(Params, "{0:0.##}x", " + {0:0.##}");
                    }
                case LoaiHam.BacHai:
                    {
                        return "y = " + FunctionFormat(Params, "{0:0.##}x²", " + {0:0.##}x", " + {0:0.##}");
                    }
                case LoaiHam.BacBa:
                    {
                        return "y = " + FunctionFormat(Params, "{0:0.##}x³", " + {0:0.##}x²", " + {0:0.##}x", " + {0:0.##}");
                    }
                case LoaiHam.TrungPhuong:
                    {
                        return "y = " + FunctionFormat(Params, "{0:0.##}x⁴", " + {0:0.##}x²", " + {0:0.##}");
                    }
                case LoaiHam.PhanThuc:
                    {
                        if (Params[0] == Params[2] && Params[1] == Params[3])
                        {
                            return "y = 1";
                        }

                        return "y = (" + FunctionFormat(new float[] { Params[0], Params[1] }, "{0:0.##}x", " + {0:0.##}") + ") / (" + FunctionFormat(new float[] { Params[2], Params[3] }, "{0:0.##}x", " + {0:0.##}") + ")";
                    }
                case LoaiHam.Sin:
                    {
                        return "y = " + FunctionFormat(new float[] { Params[0], Params[3] }, "{0:0.##}.sin(" + FunctionFormat(new float[] { Params[1], Params[2] }, "{0:0.##}x", " + {0:0.##}") + ")", " + {0:0.##}");
                    }
                case LoaiHam.Cos:
                    {
                        return "y = " + FunctionFormat(new float[] { Params[0], Params[3] }, "{0:0.##}.cos(" + FunctionFormat(new float[] { Params[1], Params[2] }, "{0:0.##}x", " + {0:0.##}") + ")", " + {0:0.##}");
                    }
                case LoaiHam.Log:
                    {
                        return string.Format("y = log(x) / log({0:0.##})", Params[0]);
                    }
                case LoaiHam.CanThuc:
                    {
                        return "y = √(" + FunctionFormat(Params, "{0:0.##}x", " + {0:0.##}") + ")";
                    }
                default:
                    return null;
            }
        }

        /// <summary>
        /// Trả về chuỗi thể hiện cho phương trình hàm số thông qua danh sách tham số và chuỗi định dạng tương ứng.
        /// </summary>
        /// <param name="Params">Danh sách thông số.</param>
        /// <param name="Formats">Chuỗi định dạng tương ứng.</param>
        /// <returns>Trả về chuỗi thể hiện cho phương trình hàm số</returns>
        private static string FunctionFormat(float[] Params, params string[] Formats)
        {
            string s = string.Empty;

            if (Params.Length != Formats.Length)
            {
                return s;
            }

            for (int i = 0; i < Params.Length; i++)
            {
                if (Params[i] != 0)
                {
                    s += string.Format(Formats[i], Params[i]);
                }
            }

            while (s.IndexOf("1x") != -1)
            {
                s = s.Replace("1x", "x");
            }

            while (s.IndexOf("1.") != -1 && !char.IsDigit(s[s.IndexOf("1.") + 1]))
            {
                s = s.Replace("1.", string.Empty);
            }

            while (s.IndexOf("+ -") != -1)
            {
                s = s.Replace("+ -", "- ");
            }

            if (s.IndexOf(" + ") == 0 && Params.Length > 1)
            {
                s = s.Remove(0, 3);
            }

            if (s == "")
            {
                s = "0";
            }

            return s;
        }

        public static bool operator ==(Function funct1, Function funct2)
        {
            return Equals(funct1, funct2);
        }

        public static bool operator !=(Function funct1, Function funct2)
        {
            return !(funct1 == funct2);
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Trả về giá trị chuỗi thể hiện cho phương trình hàm số.
        /// </summary>
        public string FunctionString
        {
            get
            {
                return functionString;
            }
        }

        /// <summary>
        /// Trả về giá trị kiểu hàm số.
        /// </summary>
        public LoaiHam FunctionType
        {
            get
            {
                return typeOfFunction;
            }
        }

        /// <summary>
        /// Trả hoặc nhận về dạng hàm số.
        /// </summary>
        public DangHam FunctionForm
        {
            get
            {
                return functionForm;
            }
            set
            {
                functionForm = value;
            }
        }

        /// <summary>
        /// Trả về giá trị các thông số của hàm số.
        /// </summary>
        public float[] Values
        {
            get
            {
                return values;
            }
        }

        /// <summary>
        /// Trả hoặc nhận về giá trị màu sắc của hàm số.
        /// </summary>
        public Color Color
        {
            get
            {
                return colorOfFunction;
            }
            set
            {
                colorOfFunction = value;
            }
        }

        /// <summary>
        /// Trả hoặc nhận về chuỗi ghi chú của hàm.
        /// </summary>
        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                if (value != null)
                {
                    note = value;
                }
            }
        }

        public bool HasTangentialLine
        {
            get
            {
                return ((LoaiHam.BacHai <= FunctionType) && (FunctionType <= LoaiHam.TrungPhuong));
            }
        }

        #endregion
    }
}
