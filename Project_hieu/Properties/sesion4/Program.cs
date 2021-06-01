using System;

namespace Project_hieu.Properties.sesion4
{
    public delegate void ShowString(string s); 
    public class Program
    {
        public static ShowString ss = new ShowString(DemoDeltegate.ShowMsg);
        public static void Main(string[] args)
        {
            //DemoDeltegate.ShowMsg("Xin chao");
            //DemoDeltegate dd = new DemoDeltegate();
            //dd.ShowInfo("xin chao moi nguoi");
            ShowString ss = new ShowString(DemoDeltegate.ShowMsg);
            ss += new ShowString(DemoDeltegate.ShowMsg);
            ss("xin chao moi nguoi");
            Calculate c = new Calculate(Calcutation.Add);
        }
    }

    public class Calculate
    {
        public Calculate(Func<int, int, int> add)
        {
            throw new NotImplementedException();
        }
    }
}