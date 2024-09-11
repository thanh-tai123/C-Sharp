// See https://aka.ms/new-console-template for more 
int choice;
while (true)
{
    start:
    Console.WriteLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Bai 1: Kieu du lieu, bien, hang so") ;
    Console.WriteLine("1. In thong tin ca nhan") ;
    Console.WriteLine("2. Tinh chu vi va dien tich hinh tron");
    Console.WriteLine("3. Tinh chu vi va dich tich hinh chu nhat");
    Console.WriteLine("4. Nhap ngay sinh va tinh tuoi");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Bai 2: Vong lap va dieu kien");
    Console.WriteLine("5. Kiem tra so co Lon Hon hoac Nhon Hon 50");
    Console.WriteLine("6. Tinh tong cac so chan tu 1 -> 100");
    Console.WriteLine("7. In ra bang cuu chuong bang vong lap while");
    Console.WriteLine("8. Nhap mot so va hien tu 1 den so do");
    Console.WriteLine("9. Kiem tra so hoan hao");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Bai 3: Phuong thuc va ham");
    Console.WriteLine("10. Viet phuong thuc tinh giai thua");
    Console.WriteLine("11. Viet phuong thuc kiem tra co phai la so nguyen to hay khong");
    Console.WriteLine("12. Viet phuong thuc tinh tong so cac phan tu trong mang");
    Console.WriteLine("13. Tim gia tri lon nhat trong mang");
    Console.WriteLine("14. Viet phuong thuc dao nguoc chuoi");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Bai 4: Xu li ngoai le");
    Console.WriteLine("15. Viet chuong trinh nhap so nguyen, neu sai thi bao loi");
    Console.WriteLine("16. Tinh thuong cua hai so, try-catch cho truong hop chia het cho 0");
    Console.WriteLine("17. Viet chuong trinh nhap so duong, neu nhap so am thi bao loi");
    Console.WriteLine("18. Nhap vao mot chuo, neu co so thi bao loi");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("19. Thoat chuong trinh");
    Console.WriteLine("Chon chuong trinh muon thuc hien ");
    Console.WriteLine();
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Nhap sai dinh dang, vui long nhap mot so.");
        goto start; 
    }
    switch (choice)
    {
        case 1:
            string Name = "Nguyen Thanh Tai";
            int Age = 20;
            float height = 1.65f;
            Boolean gender = true;
            //string genderString = gender ? "Male" : "Female";
            //Console.WriteLine($"Gender: {genderString}");
            Console.WriteLine($"My name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
            break;
        case 2:
            const double pi = 3.14159;
            Console.Write("Nhap ban kinh hinh tron: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double chuvi = 2 * pi * r;
            double dientich = pi * r * r;
            Console.WriteLine($"Chu vi hinh tron la  {chuvi}");
            Console.WriteLine($"Dien tich hinh tron la  {dientich}");
            break;
        case 3:
            Console.Write("Nhap chieu dai hinh chu nhat ");
            double cd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat ");
            double cr = Convert.ToDouble(Console.ReadLine());
            double ChuViHCN = cd * cr;
            double DienTichHCN = (cd + cr) * 2;

            Console.WriteLine($"ChuViHCN: {ChuViHCN}");
            Console.WriteLine($"DienTichHCN: {DienTichHCN}");
            break;
        case 4:

            DateTime birthDate = new DateTime(2004, 3, 29);
            Console.WriteLine($"Ngay sinh cua ban: {birthDate.ToString("dd/MM/yyyy")}");
            int age = DateTime.Now.Year - birthDate.Year;
            Console.WriteLine($"Tuoi hien tai {age}");

            break;
        case 5:

            int number;
            do
            {
                Console.WriteLine("Hay nhap 1 so tu 1 -> 100");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number > 100 || number < 0);
            if (number > 50)
            {
                Console.WriteLine($"Lon Hon");
            }
            else
            {
                Console.WriteLine($"Nho Hon");
            }
            break;
        case 6:

            int sumCase6 = 0;
            for (int i6 = 1; i6 <= 100; i6++)
            {
                if (i6 % 2 == 0)
                {
                    sumCase6 += i6;
                }
            }
            Console.WriteLine($"Tong:{sumCase6}");
            break;
        case 7:

            int i7 = 1;
            while (i7 <= 9)
            {
                Console.WriteLine($"Banh cuu chuong {i7}");
                int j7 = 1;
                while (j7 <= 9)
                {
                    Console.WriteLine($"{i7} x {j7} = {i7 * j7}");
                    j7++;
                }
                Console.WriteLine();
                i7++;
            }

            break;
        case 8:
           
            int numberCase8;
            do
            {
                Console.WriteLine("Hay nhap 1 so tu 1 -> 100");
                numberCase8 = Convert.ToInt32(Console.ReadLine());
            }
            while (numberCase8 > 100 || numberCase8 < 0);
            for (int i8 = 1; i8 <= numberCase8; i8++)
            {
                if (i8 % 2 == 0)
                {
                    Console.WriteLine($"{i8} La so chan");
                }
                else
                {
                    Console.WriteLine($"{i8} La so le");
                }
            }
            break;
        case 9:
            
            Console.Write("Nhập một số nguyên: ");
            int numberCase9 = Convert.ToInt32(Console.ReadLine());
            int sumCase9 = 0;
            for (int i9 = 1; i9 < numberCase9; i9++)
            {
                if (numberCase9 % i9 == 0)
                {
                    sumCase9 += i9;

                }
            }
            if (sumCase9 == numberCase9)
            {
                Console.WriteLine($"{numberCase9} la so hoan hao, vi tong uoc cua {numberCase9} la {sumCase9}");
            }
            else
            {
                Console.WriteLine($"{numberCase9} khong la so hoan hao, vi tong uoc cua {numberCase9} la {sumCase9}");
            }
            break;
        case 10:

            static long GiaiThua(int nCase10)
            {
                if (nCase10 == 0 || nCase10 == 1)
                {
                    return 1;
                }
                return nCase10 * GiaiThua(nCase10 - 1);
            }
            Console.Write("Nhập một số nguyên: ");
            int numberCase10 = Convert.ToInt32(Console.ReadLine());
            long giaithua = GiaiThua(numberCase10);
            Console.WriteLine($"Giai thua cua {numberCase10} la {giaithua}");
            break;
        case 11:

            static bool SoNguyenTo(int nCase11)
            {
                if (nCase11 < 2)
                {
                    Console.WriteLine($"{nCase11} khong la so nguyen to");
                    return false;

                }
                for (int i11 = 2; i11 < nCase11; i11++)
                {
                    if (nCase11 % i11 == 0)
                    {
                        Console.WriteLine($"{nCase11} khong la so nguyen to");
                        return false;
                        ;
                    }
                }
                Console.WriteLine($"{nCase11} la so nguyen to");
                return true;
            }
            Console.Write("Nhap mot so nguyen: ");
            int numberCase11 = Convert.ToInt32(Console.ReadLine());
            bool SNT = SoNguyenTo(numberCase11);

            break;
        case 12:
            
            Console.Write("Nhap so phan tu co trong mang: ");
            int nCase12 = Convert.ToInt32(Console.ReadLine());
            int[] numberCase12 = new int[nCase12];
            for (int i12 = 0; i12 < nCase12; i12++)
            {
                Console.Write($"Phan tu thu: {i12 + 1} ");
                numberCase12[i12] = int.Parse(Console.ReadLine());
            }
            int tongArray = sumCase12(numberCase12);
            static int sumCase12(int[] numbersCase12)
            {
                int sumCase12 = 0;
                foreach (int numberCase12 in numbersCase12)
                {
                    sumCase12 += numberCase12;
                }
                Console.WriteLine($"Tong mang: {sumCase12} ");
                return sumCase12;
            }

            break;
        case 13:
            
            Console.Write("Nhap so phan tu co trong mang: ");
            int nCase13 = Convert.ToInt32(Console.ReadLine());
            int[] numberCase13 = new int[nCase13];
            for (int i13 = 0; i13 < nCase13; i13++)
            {
                Console.Write($"Phan tu thu: {i13 + 1} ");
                numberCase13[i13] = int.Parse(Console.ReadLine());
            }
            SortArray(numberCase13);
            Console.WriteLine($"So lon nhat la: {numberCase13[0]}");
            static void SortArray(int[] numbersCase13)
            {
                int tempCase13;
                for (int i13 = 0; i13 < numbersCase13.Length - 1; i13++)
                {
                    for (int j13 = 0; j13 < numbersCase13.Length - 1 - i13; j13++)
                    {
                        if (numbersCase13[j13] < numbersCase13[j13 + 1])
                        {
                            tempCase13 = numbersCase13[j13];
                            numbersCase13[j13] = numbersCase13[j13 + 1];
                            numbersCase13[j13 + 1] = tempCase13;
                        }
                    }
                }
            }
            break;
        case 14:

            string str, strReverse = "";
            int l14, i14;
            Console.WriteLine("Nhap vao mot chuoi: ");
            str = Console.ReadLine();
            l14 = str.Length - 1;
            for (i14 = l14; i14 >= 0; i14--)
            {
                strReverse = strReverse + str[i14];
            }
            Console.WriteLine($"Chuoi sau khi dao {strReverse}");
            break;
        case 15:

            int numberCase15;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap mot so nguyen: ");
                    numberCase15 = Convert.ToInt32(Console.ReadLine());
                    //if(number<0)
                    //{
                    //    Console.WriteLine($"So ban vua nhap la : {number} la so am");
                    //    Console.WriteLine("Nhap so nguen, hay nhap lai ");
                    //    Console.WriteLine();
                    //    continue;
                    //}
                    Console.WriteLine($"So ban vua nhap la : {numberCase15}");
                    break;
                }
                catch
                {
                    Console.WriteLine("Nhap so nguen, hay nhap lai ");
                    Console.WriteLine();
                }

            }
            break;
        case 16:

            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap so bi chia: ");
                    int number1Case16 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so chia: ");
                    int number2Case16 = Convert.ToInt32(Console.ReadLine());

                    double resultCase16 = number1Case16 / number2Case16;
                    Console.WriteLine($"Ket qua: {resultCase16}");
                    break;
                }
                catch
                {
                    Console.WriteLine("So chia khong duoc bang 0, Hay nhap lai");
                    Console.WriteLine();
                }
            }
            break;
        case 17:

            int numberCase17;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap mot so nguyen duong: ");
                    numberCase17 = Convert.ToInt32(Console.ReadLine());
                    if (numberCase17 < 0)
                    {
                        throw new Exception("Hay nhap so duong, Hay nhap lai");

                    }
                    Console.WriteLine($"So ban vua nhap la : {numberCase17}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang, Nhap so nguen duong");
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Nhap so nguen duong, hay nhap lai ");
                    Console.WriteLine();
                }
            }
            break; 
        case 18:
            string inputCase18;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap mot chuoi: ");
                    inputCase18 = Console.ReadLine();
                    if (ContainsDigit(inputCase18))
                    {
                        throw new Exception("Chuoi khong duoc chua so.");
                    }
                    Console.WriteLine($"Chuoi ban vua nhap la {inputCase18}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }

                catch
                {
                    Console.WriteLine("Co loi xay ra hay kiem tra lai");
                }
            }

            static bool ContainsDigit(string strCase18)
            {
                foreach (char c in strCase18)
                {
                    if (char.IsDigit(c))
                    {
                        return true;
                    }
                }
                return false;
            }
            break;
        case 19:
            Console.WriteLine("Thoat chuong trinh.");
            return;
        default: Console.WriteLine("Sai cu phap"); continue;
    }

    Console.WriteLine("Ban co muon tiep tuc? (y/n): ");
    char continueChoice = Console.ReadKey().KeyChar;
    Console.WriteLine(); 

    if (continueChoice != 'y' && continueChoice != 'Y')
    {
        Console.WriteLine("Thoat chuong trinh.");
        return; 
    }


    goto start;
    Console.WriteLine();
}
