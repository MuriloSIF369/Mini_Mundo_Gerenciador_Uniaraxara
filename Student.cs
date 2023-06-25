using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Mini_Mundo
{
     public class Student : Courses
    {
        public string name { get; set; }
        public int RA { get; set; }
        public string CPF { get; set; }
        public string ClassName { get; set; }
        

        public Student()
        {
            Console.Write("Nome: ");
            name = Console.ReadLine();

            Console.Write("RA: ");
            RA = int.Parse(Console.ReadLine());

            Console.Write("CPF: ");
            CPF = Console.ReadLine();

            CourseRegister();

        }
        public override void CourseRegister()
        {
            Console.WriteLine("- CURSO DESEJADO - \n" +
                "");

            Console.WriteLine("1. SISTEMAS DE INFORMAÇÃO");
            Console.WriteLine("2. DIREITO");
            Console.WriteLine("3. ENFERMAGEM");
            Console.WriteLine("4. ARQUITETURA");
            Console.WriteLine("5. EDUCAÇÃO FÍSICA");
            Console.WriteLine("6. BIO-MEDIDICINA");
            Console.WriteLine("7. PSICOLOGIA");

            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                SIF ChoiceOfClass = new SIF();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 2)
            {
                Direito ChoiceOfClass = new Direito();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 3)
            {
                Enfermagem ChoiceOfClass = new Enfermagem();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 4)
            {
                Arquitetura ChoiceOfClass = new Arquitetura();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 5)
            {
                BioMed ChoiceOfClass = new BioMed();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 6)
            {
                EdFis ChoiceOfClass = new EdFis();
                ClassName = ChoiceOfClass.Name;
            }
            if (Choice == 7)
            {
                Psicologia ChoiceOfClass = new Psicologia();
                ClassName = ChoiceOfClass.Name;
            }
        }
    }
}
