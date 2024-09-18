// See https://aka.ms/new-console-template for more information
//RandomGenerate rg= new RandomGenerate();
//rg.printToScreen();
//rg.printToprivateLy();
//rg.printToScreenInternal();
//printScreen2 printScreen = new printScreen2();
//printScreen.printToScreenInternal();
//printScreen.printProtected();

//class RandomGenerate {
//Random myRandomGen = new Random();
//    public void printToScreen()
//    {
//        Console.WriteLine("Public " + myRandomGen.Next());
//    }
//    private void printToScreenPrivate()
//    {
//        Console.WriteLine("Private " + myRandomGen.Next());

//    }
//    protected void printToSreenProtected()
//    {
//        Console.WriteLine("Protected " + myRandomGen.Next());
//    }
//    public void printToprivateLy()
//    {
//        printToScreenPrivate();
//    }
//    internal void printToScreenInternal()
//    {
//        Console.WriteLine("printToScreenInternal " + myRandomGen.Next());
//    }
//}
//class printScreen2 : RandomGenerate {
//public void printProtected()
//    {
//       printToSreenProtected();
//    }
//}
using Lesson_2_OOP;

QLCB qLCB = new QLCB();
bool chay = true;

while (chay)
{
    Console.WriteLine("1. Them cac bo");
    Console.WriteLine("2. Tim kiem cac bo");
    Console.WriteLine("3. Hien thi danh sach cac bo");
    Console.WriteLine("4. Thoat");
    Console.Write("Chon chuc nang: ");
    string luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            Console.Write("Nhap loai cac bo (1: Cong nhan, 2: Ky su, 3: Nhan vien): ");
            int loai = int.Parse(Console.ReadLine());
            CanBo canBo = null;

            if (loai == 1)
            {
                canBo = new CongNhan();
                Console.Write("Nhap bac: ");
                ((CongNhan)canBo).Bac = int.Parse(Console.ReadLine());
            }
            else if (loai == 2)
            {
                canBo = new KySu();
                Console.Write("Nhap nganh dao tao: ");
                ((KySu)canBo).NganhDaoTao = Console.ReadLine();
            }
            else if (loai == 3)
            {
                canBo = new NhanVien();
                Console.Write("Nhap cong viec: ");
                ((NhanVien)canBo).CongViec = Console.ReadLine();
            }

            Console.Write("Nhap ho ten: ");
            canBo.hoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            canBo.tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            canBo.gioiTinh = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            canBo.diaChi = Console.ReadLine();

            qLCB.themCanBo(canBo);
            break;

        case "2":
            Console.Write("Nhap ho ten can tim: ");
            string hoTen = Console.ReadLine();
            CanBo found = qLCB.Timkiem(hoTen);
            if (found != null)
            {
                found.HienThi();
            }
            else
            {
                Console.WriteLine("Khong tim thay can bo phu hop.");
            }
            break;

        case "3":
            qLCB.hienThiDS();
            break;

        case "4":
            chay = false;
            break;

        default:
            Console.WriteLine("Chon khong hop le, vui long thu lai.");
            break;
    }
}

