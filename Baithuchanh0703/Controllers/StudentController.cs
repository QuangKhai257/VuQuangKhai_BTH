using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            //gui du lieu ve view
            ViewBag.khai = strReturn;
            return View();
            //tra ve danh sach cac sinh vien trong Database
        }

         public IActionResult Tinhtong(string Number)
        {
            int so = Convert.ToInt32(Number);
            int tong = 0;
            while(so > 0)
            {
                tong = tong + so%10;
                so = so/10;
            }
            ViewBag.Tinhtong ="Tong cac chu so cua so "+Number +"=" +tong;
            return View();
        }
         public IActionResult Gptbac2()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Gptbac2(string hesoA, string hesoB, string hesoC)
        {
            //khai bao bien
            double delta, x1, x2, a =0, b=0, c=0;
            string ketqua;
            //Giai phuong trinh
            if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
            if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
            if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
            if(a==0) ketqua = "Khong phai phuong trinh bac 2";
            else{
                //tinh delta
                delta = Math.Pow(b,2) - 4*a*c;
                // Giai phuong trinh
                if(delta<0) ketqua ="Phương trình vô nghiệm ";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phương trình có nghiệm kép = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phương trình có 2 nghiệm phân biệt : x1= "+ x1 + ", x2= "+x2;
                }
            }
            ViewBag.message = ketqua;
            return View();
        }
    }

}