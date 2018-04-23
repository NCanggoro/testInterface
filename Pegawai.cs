using System;

namespace tugas
{
    public class Pegawai : IPegawai
    {
        private int _gaji;
        private string _job;

        public int gaji
        {
            get {return _gaji;}
            set{_gaji=value;}
        }

        public string job
        {
            get{return  _job;}
            set{_job=value;}

        }
        
        public void pegawaiGaji(string jobs,int salary)
        {
            gaji = salary;
            job = jobs  ;

            System.Console.WriteLine("Jobs = "+jobs);
            System.Console.WriteLine("Salary = "+salary);     
    
        }

        
    }
}