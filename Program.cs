using Mini_Mundo;
using System.IO.Pipes;
public class Program : Methods
{
    public static void Main(string[] args)
    {
        Methods Execute = new Methods();
        List<Student> ListOfStudents = new List<Student>();

        Console.WriteLine("BEM VINDO AO GERENCIADOR DE ALUNOS DO UNIARAXÁ");

    MainMenu:
        Console.WriteLine("_ MENU DE OPÇÕES _");
        Console.WriteLine("1. Cadastrar aluno");
        Console.WriteLine("2. Exibir lista de alunos");
        Console.WriteLine("3. Pesquisar aluno");
        Console.WriteLine("4. Pesquisar curso");


        int ManagingMenu = Convert.ToInt32(Console.ReadLine());

        switch (ManagingMenu)
        {
            //
            case 1:
                Student NewStudent = new();
                ListOfStudents.Add(NewStudent);

                Console.WriteLine("Nova operação 1. Sim | 2. Não: ");
                int TurnToMenu = Convert.ToInt32(Console.ReadLine());
                if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };
            //
            case 2:
                foreach (var item in ListOfStudents)
                {
                    Console.WriteLine("- FICHA DO ALUNO - \n" +
                        "");

                    Console.Write("Nome: ");
                    Console.WriteLine(item.name);

                    Console.Write("RA: ");
                    Console.WriteLine(item.RA);

                    Console.Write("CPF: ");
                    Console.WriteLine(item.CPF);

                    Console.Write("CURSO: ");
                    Console.WriteLine(item.ClassName);

                    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                }
                Console.WriteLine("Nova operação 1. Sim | 2. Não: ");
                TurnToMenu = Convert.ToInt32(Console.ReadLine());
                if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };
            //
            case 3:

                Console.Write("PESQUISAR POR \n" +
                    "1. Nome\n" +
                    "2. RA\n" +
                    "3. Curso\n" +
                    "");
                int Asnwer = int.Parse(Console.ReadLine());
                switch (Asnwer)
                {
                    case 1:
                        Console.Write("Nome do aluno: ");
                        string StudentName = Console.ReadLine();

                        var ReturnName = ListOfStudents.Where(ListOfStudents => ListOfStudents.name == StudentName);


                        foreach (var nome in ReturnName)
                        {
                            Console.Write("- FICHA DO ALUNO -");
                            Console.Write("Nome: ");
                            Console.WriteLine(nome.name);

                            Console.Write("RA: ");
                            Console.WriteLine(nome.RA);

                            Console.Write("CPF: ");
                            Console.WriteLine(nome.CPF);

                            Console.Write("CURSO: ");
                            Console.WriteLine(nome.ClassName);
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }

                        Console.WriteLine("Nova operação 1. Sim | 2. Não: ");
                        TurnToMenu = Convert.ToInt32(Console.ReadLine());
                        if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };

                    case 2:
                        Console.Write("RA do aluno: ");
                        int StudentRA = int.Parse(Console.ReadLine());
                        var ReturnRA = ListOfStudents.Where(ListOfStudents => ListOfStudents.RA == StudentRA);


                        foreach (var nome in ReturnRA)
                        {
                            Console.Write("- FICHA DO ALUNO -");
                            Console.Write("Nome: ");
                            Console.WriteLine(nome.name);

                            Console.Write("RA: ");
                            Console.WriteLine(nome.RA);

                            Console.Write("CPF: ");
                            Console.WriteLine(nome.CPF);

                            Console.Write("CURSO: ");
                            Console.WriteLine(nome.ClassName);
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        Console.WriteLine("Nova operação 1. Sim | 2. Não: ");
                        TurnToMenu = Convert.ToInt32(Console.ReadLine());
                        if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };
                       
                    case 3:
                        Console.Write("Nome do curso: ");
                        string StudentCourse = Console.ReadLine();

                        var ReturnCourse = ListOfStudents.Where(ListOfStudents => ListOfStudents.name == StudentCourse);


                        foreach (var nome in ReturnCourse)
                        {
                            Console.Write("- FICHA DO ALUNO -");
                            Console.Write("Nome: ");
                            Console.WriteLine(nome.name);

                            Console.Write("RA: ");
                            Console.WriteLine(nome.RA);

                            Console.Write("CPF: ");
                            Console.WriteLine(nome.CPF);

                            Console.Write("CURSO: ");
                            Console.WriteLine(nome.ClassName);
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        Console.WriteLine("Nova operação 1. Sim | 2. Não: ");
                        TurnToMenu = Convert.ToInt32(Console.ReadLine());
                        if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };

                }
                break;
            //
            case 4:
                Console.WriteLine("- CURSO -  \n" +
            "1. Sistemas De Informação\n" +
            "2. Direito Constitucional\n" +
            "3. Enfermagem\n" +
            "4. Arquitetura\n" +
            "5. Bio-Medicina\n" +
            "6. Educação Física\n" +
            "7. Psicologia");
                int CourseChoice = int.Parse(Console.ReadLine());
                Execute.DefineCourse(CourseChoice);

                
                Console.WriteLine("Nova operação 1. Sim | 2. Não: ");

                TurnToMenu = Convert.ToInt32(Console.ReadLine());
                if (TurnToMenu == 1) { goto MainMenu; } else { goto EndScript; };
        }
    EndScript:;
    }
}
