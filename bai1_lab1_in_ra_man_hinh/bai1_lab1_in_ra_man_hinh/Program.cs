using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập hiển thị tiếng Việt có dấu trên Console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int chon = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("    TRƯỜNG ĐẠI HỌC CÔNG NGHỆ ĐÔNG Á - KHOA CNTT   ");
                Console.WriteLine("      BÀI THỰC HÀNH LAB 1: LẬP TRÌNH CONSOLE      ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1.  Nhập thông tin cá nhân");
                Console.WriteLine("2.  Tính toán hình trụ");
                Console.WriteLine("3.  Xếp loại kết quả học tập");
                Console.WriteLine("4.  Menu tính tổng & bảng cửu chương");
                Console.WriteLine("5.  Xử lý ngoại lệ phép chia");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("6.  Giải phương trình bậc hai");
                Console.WriteLine("7.  Thống kê dãy số");
                Console.WriteLine("8.  In các số nguyên tố <= n");
                Console.WriteLine("9.  Đọc số từ 0 đến 99 bằng tiếng Việt");
                Console.WriteLine("10. Vẽ hình bằng ký tự *");
                Console.WriteLine("0.  Thoát chương trình");
                Console.WriteLine("==================================================");
                Console.Write("Mời bạn chọn bài tập (0-10): ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    chon = -1;
                }

                Console.WriteLine("\n--------------------------------------------------");
                switch (chon)
                {
                    case 1: BaiTap1(); break;
                    case 2: BaiTap2(); break;
                    case 3: BaiTap3(); break;
                    case 4: BaiTap4(); break;
                    case 5: BaiTap5(); break;
                    case 6: BaiTap6(); break;
                    case 7: BaiTap7(); break;
                    case 8: BaiTap8(); break;
                    case 9: BaiTap9(); break;
                    case 10: BaiTap10(); break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng thử lại.");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                }

            } while (chon != 0);
        }

        #region BÀI TẬP CÓ HƯỚNG DẪN (1 - 5)

        // Bài 1: Nhập thông tin cá nhân
        static void BaiTap1()
        {
            Console.WriteLine("=== BÀI 1: NHẬP THÔNG TIN CÁ NHÂN ===");
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh;
            if (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh > DateTime.Now.Year || namSinh < 1900)
            {
                Console.WriteLine("Năm sinh không hợp lệ.");
                return;
            }

            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);
        }

        // Bài 2: Tính toán hình trụ
        static void BaiTap2()
        {
            Console.WriteLine("=== BÀI 2: TÍNH TOÁN HÌNH TRỤ ===");
            double r, h;

            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Bán kính phải là số dương hợp lệ.");
                return;
            }

            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Chiều cao phải là số dương hợp lệ.");
                return;
            }

            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;

            Console.WriteLine("Diện tích xung quanh Sxq = {0:N2}", dienTichXQ);
            Console.WriteLine("Thể tích V = {0:N2}", theTich);
        }

        // Bài 3: Xếp loại kết quả học tập
        static void BaiTap3()
        {
            Console.WriteLine("=== BÀI 3: XẾP LOẠI KẾT QUẢ HỌC TẬP ===");
            Console.Write("Nhập điểm học tập (0 - 10): ");
            double diem;

            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm phải thuộc khoảng [0, 10].");
            }
            else if (diem >= 9) Console.WriteLine("Xếp loại: Xuất sắc");
            else if (diem >= 8) Console.WriteLine("Xếp loại: Giỏi");
            else if (diem >= 6.5) Console.WriteLine("Xếp loại: Khá");
            else if (diem >= 5) Console.WriteLine("Xếp loại: Trung bình");
            else Console.WriteLine("Xếp loại: Yếu");
        }

        // Bài 4: Menu xử lý bằng switch và vòng lặp
        static void BaiTap4()
        {
            Console.WriteLine("=== BÀI 4: MENU XỬ LÝ SWITCH & DO-WHILE ===");
            int subChon;
            do
            {
                Console.WriteLine("\n-- SUB MENU BÀI 4 --");
                Console.WriteLine("1. Tính tổng từ 1 đến n");
                Console.WriteLine("2. In bảng cửu chương 7");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Lựa chọn: ");

                int.TryParse(Console.ReadLine(), out subChon);

                switch (subChon)
                {
                    case 1:
                        Console.Write("Nhập n = ");
                        int n;
                        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                        {
                            int tong = 0;
                            for (int i = 1; i <= n; i++) tong += i;
                            Console.WriteLine($"Tổng 1..{n} = {tong}");
                        }
                        else
                        {
                            Console.WriteLine("n phải là số nguyên dương.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("BẢNG CỬU CHƯƠNG 7:");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("7 x {0,2} = {1,2}", i, 7 * i);
                        }
                        break;
                }
            } while (subChon != 0);
        }

        // Bài 5: Xử lý ngoại lệ phép chia
        static void BaiTap5()
        {
            Console.WriteLine("=== BÀI 5: XỬ LÝ NGOẠI LỆ PHÉP CHIA ===");
            try
            {
                Console.Write("Nhập số nguyên a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhập số nguyên b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Kết quả a / b = " + (a / b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Dữ liệu nhập vào phải là số nguyên.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Lỗi: Không thể chia cho 0.");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính.");
            }
        }

        #endregion

        #region BÀI TẬP TỰ THỰC HIỆN (6 - 10)

        // Bài 6: Giải phương trình bậc hai ax^2 + bx + c = 0
        static void BaiTap6()
        {
            Console.WriteLine("=== BÀI 6: GIẢI PHƯƠNG TRÌNH BẬC HAI (ax² + bx + c = 0) ===");
            double a, b, c;

            Console.Write("Nhập a = ");
            if (!double.TryParse(Console.ReadLine(), out a)) { Console.WriteLine("Hệ số a không hợp lệ."); return; }

            Console.Write("Nhập b = ");
            if (!double.TryParse(Console.ReadLine(), out b)) { Console.WriteLine("Hệ số b không hợp lệ."); return; }

            Console.Write("Nhập c = ");
            if (!double.TryParse(Console.ReadLine(), out c)) { Console.WriteLine("Hệ số c không hợp lệ."); return; }

            if (a == 0)
            {
                // Giải phương trình bậc nhất bx + c = 0
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("Phương trình có vô số nghiệm.");
                    else Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình bậc nhất có 1 nghiệm: x = {0:F2}", x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:F2}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("  x1 = {0:F2}", x1);
                    Console.WriteLine("  x2 = {0:F2}", x2);
                }
            }
        }

        // Bài 7: Thống kê dãy số
        static void BaiTap7()
        {
            Console.WriteLine("=== BÀI 7: THỐNG KÊ DÃY SỐ ===");
            Console.Write("Nhập số lượng phần tử n = ");
            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Số lượng n phải là số nguyên dương.");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write($"Giá trị không hợp lệ. Nhập lại phần tử thứ {i + 1}: ");
                }
            }

            int tong = 0;
            int max = arr[0];
            int min = arr[0];
            int soChanCount = 0;

            foreach (int item in arr)
            {
                tong += item;
                if (item > max) max = item;
                if (item < min) min = item;
                if (item % 2 == 0) soChanCount++;
            }

            double trungBinh = (double)tong / n;

            Console.WriteLine("\n--- KẾT QUẢ THỐNG KÊ ---");
            Console.WriteLine($"Tổng dãy số        : {tong}");
            Console.WriteLine($"Trung bình cộng    : {trungBinh:F2}");
            Console.WriteLine($"Số lớn nhất (Max)  : {max}");
            Console.WriteLine($"Số nhỏ nhất (Min)  : {min}");
            Console.WriteLine($"Số lượng số chẵn   : {soChanCount}");
        }

        // Bài 8: Kiểm tra và in số nguyên tố <= n
        static void BaiTap8()
        {
            Console.WriteLine("=== BÀI 8: IN CÁC SỐ NGUYÊN TỐ <= n ===");
            Console.Write("Nhập n = ");
            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 2)
            {
                Console.WriteLine("Không có số nguyên tố nào <= " + Console.ReadLine());
                return;
            }

            Console.WriteLine($"Các số nguyên tố không vượt quá {n} là:");
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        // Hàm hỗ trợ kiểm tra số nguyên tố tối ưu (kiểm tra đến sqrt)
        static bool KiemTraNguyenTo(int k)
        {
            if (k < 2) return false;
            int limit = (int)Math.Sqrt(k);
            for (int i = 2; i <= limit; i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }

        // Bài 9: Đọc số từ 0 đến 99 bằng tiếng Việt
        static void BaiTap9()
        {
            Console.WriteLine("=== BÀI 9: ĐỌC SỐ TỪ 0 ĐẾN 99 ===");
            Console.Write("Nhập số nguyên (0 - 99): ");
            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 99)
            {
                Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng chọn trong khoảng [0, 99].");
                return;
            }

            Console.WriteLine($"Cách đọc số {n}: \"{DocSoTIengViet(n)}\"");
        }

        static string DocSoTIengViet(int n)
        {
            if (n == 0) return "Không";

            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int chuc = n / 10;
            int donVi = n % 10;

            if (chuc == 0)
            {
                return VietHoaChutDau(chuSo[donVi]);
            }
            else if (chuc == 1)
            {
                string dvText = "";
                switch (donVi)
                {
                    case 0: dvText = ""; break;
                    case 5: dvText = "lăm"; break;
                    default: dvText = chuSo[donVi]; break;
                }
                return "Mười" + (dvText != "" ? " " + dvText : "");
            }
            else
            {
                string chucText = chuSo[chuc] + " mươi";
                string dvText = "";
                switch (donVi)
                {
                    case 0: dvText = ""; break;
                    case 1: dvText = "mốt"; break;
                    case 4: dvText = "tư"; break;
                    case 5: dvText = "lăm"; break;
                    default: dvText = chuSo[donVi]; break;
                }
                return VietHoaChutDau(chucText + (dvText != "" ? " " + dvText : ""));
            }
        }

        static string VietHoaChutDau(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        // Bài 10: Vẽ hình bằng ký tự *
        static void BaiTap10()
        {
            Console.WriteLine("=== BÀI 10: VẼ HÌNH BẰNG KÝ TỰ * ===");
            Console.WriteLine("1. Tam giác vuông đặc");
            Console.WriteLine("2. Tam giác vuông rỗng");
            Console.WriteLine("3. Hình vuông rỗng");
            Console.Write("Chọn hình muốn vẽ: ");

            int loai;
            if (!int.TryParse(Console.ReadLine(), out loai) || loai < 1 || loai > 3)
            {
                Console.WriteLine("Lựa chọn hình không hợp lệ.");
                return;
            }

            Console.Write("Nhập kích thước (h hoặc a): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
            {
                Console.WriteLine("Kích thước phải lớn hơn 1.");
                return;
            }

            Console.WriteLine("\nKẾT QUẢ VẼ HÌNH:\n");
            switch (loai)
            {
                case 1: // Tam giác vuông đặc
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                    break;

                case 2: // Tam giác vuông rỗng
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j == 1 || j == i || i == n)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3: // Hình vuông rỗng
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }

        #endregion
    }
}