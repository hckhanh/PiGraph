
/// PixelsGraph library
/// Thư viện chứa các lớp định nghĩa chung cho hệ thống chương trình.
namespace PixelsGraph
{
    /// <summary>
    /// Tập hợp các hàm số trong không gian tên PixelsGraph
    /// </summary>
    public enum LoaiHam
    {
        /// <summary>
        /// y = ax + b
        /// </summary>
        BacNhat,
        /// <summary>
        /// y = ax² + bx + c
        /// </summary>
        BacHai,
        /// <summary>
        /// y = ax³ + bx² + cx + d
        /// </summary>
        BacBa,
        /// <summary>
        /// y = ax⁴ + bx² + c
        /// </summary>
        TrungPhuong,
        /// <summary>
        /// y = (ax + b) / (cx + d)
        /// </summary>
        PhanThuc,
        /// <summary>
        /// y = a*sin(b*x + c) + d
        /// </summary>
        Sin,
        /// <summary>
        /// y = a*cos(b*x + c) + d
        /// </summary>
        Cos,
        /// <summary>
        /// y = log(x) / log(a)
        /// </summary>
        Log,
        /// <summary>
        /// y = √(ax + b)
        /// </summary>
        CanThuc,
        /// <summary>
        /// Undefined function.
        /// </summary>
        Undefined
    }

    /// <summary>
    /// Lớp KyTuDacBiet chứa các ký tự đặc biệt được sử dụng trong chương trình.
    /// </summary>
    public class KyTuDacBiet
    {
        /// <summary>
        /// Ký tự bình phương '²'
        /// </summary>
        public const char Bac_2 = '²';
        /// <summary>
        /// Ký tự lập phương '³'
        /// </summary>
        public const char Bac_3 = '³';
        /// <summary>
        /// Ký tự lũy thừa bậc 4 - '⁴'
        /// </summary>
        public const char Bac_4 = '⁴';
        /// <summary>
        /// Ký tự căn bậc hai '√'
        /// </summary>
        public const char CanBacHai = '√';
    }

    public enum DangHam
    {
        /// <summary>
        /// y = f(x)
        /// </summary>
        NonAbs,
        /// <summary>
        /// y = |f(x)|
        /// </summary>
        Absf_x,
        /// <summary>
        /// y = f(|x|)
        /// </summary>
        Absx
    }
}
