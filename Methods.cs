using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Mundo
{
    public class Methods
    {
        public void DefineCourse(int parameter)
        {
            if (parameter == 1)
            {
                SIF sIF = new SIF();
                Console.WriteLine(sIF.Name);
                Console.WriteLine(sIF.Nature);
                Console.WriteLine($"Tempo total: {sIF.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(sIF.Time)}");

            }
            if (parameter == 2)
            {
                Direito Direito = new Direito();
                Console.WriteLine(Direito.Name);
                Console.WriteLine(Direito.Nature);
                Console.WriteLine($"Tempo total: {Direito.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(Direito.Time)}");
            }
            if (parameter == 3)
            {
                Enfermagem enfermagem = new Enfermagem();
                Console.WriteLine(enfermagem.Name);
                Console.WriteLine(enfermagem.Nature);
                Console.WriteLine($"Tempo total: {enfermagem.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(enfermagem.Time)}");
            }
            if (parameter == 4)
            {
               Arquitetura arquitetura = new Arquitetura();
                Console.WriteLine(arquitetura.Name);
                Console.WriteLine(arquitetura.Nature);
                Console.WriteLine($"Tempo total: {arquitetura.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(arquitetura.Time)}");
            }
            if (parameter == 5)
            {
                BioMed biomedic = new BioMed();
                Console.WriteLine(biomedic.Name);
                Console.WriteLine(biomedic.Nature);
                Console.WriteLine($"Tempo total: {biomedic.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(biomedic.Time)}");
            }
            if (parameter == 6)
            {
                EdFis edfisica = new EdFis();
                Console.WriteLine(edfisica.Name);
                Console.WriteLine(edfisica.Nature);
                Console.WriteLine($"Tempo total: {edfisica.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(edfisica.Time)}");
            }
            if (parameter == 7)
            {
                Psicologia psicologia = new Psicologia();
                Console.WriteLine(psicologia.Name);
                Console.WriteLine(psicologia.Nature);
                Console.WriteLine($"Tempo total: {psicologia.Time} meses");
                Console.WriteLine($"Valor Total do curso: R${CalculatePrice(psicologia.Time)}");
            }
        }
        public double CalculatePrice(double parameter)
        {
            return parameter * 622.68;
        }
    }
}
