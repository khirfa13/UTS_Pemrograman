using System;

namespace Dosen
{
    class Program
    {
        public int id;
        public string name;
        public string gender;
        public int nik;
        public string course;
        public string dosen;
        public string NamaDosen;
        public string Matkul;
        public Program(int id, string name, string gender, string course, int nik, string dosen)

        {

            this.id = id;
            this.name = name;
            this.nik = nik;
            this.gender = gender;
            this.course = course;
            this.dosen = dosen;

        }

        public void DosenInfo()
        {
            Console.WriteLine("Nama Dosen Pengampu: {0}", NamaDosen);
            Console.WriteLine("Matkul: {0}", Matkul);
        }

        public void attDosen()

        {

            Console.Write("Masukan ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nama Dosen:");
            name = Console.ReadLine();
            Console.Write("Masukan NIK:");
            nik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Gender:");
            gender = Console.ReadLine();
            Console.Write("Masukan Course:");
            course = Console.ReadLine();

            dosen = "ID:" + id + "\n" + "Nama Dosen:" + name + "\n" + "Nik:" + nik + "\n" + "Gender:" + gender + "\n" + "Course:" + course + "\n";
        }

        public void addCourse()
        {
            Console.Write(dosen);
        }

        static void Main(string[] args)
        {
            Program program = new Program(1, "name", "gender", "course", 1, "dosen");

            program.NamaDosen = "Kamarudin, M.Kom";
            program.Matkul = "Pemrograman";

            program.DosenInfo();
            Console.WriteLine("\n");
            program.attDosen();
            Console.WriteLine("\n");
            program.addCourse();
            Console.WriteLine("\n");
        }
    }
}
