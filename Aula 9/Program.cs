MySystem.Program();


public class Curso
{
    public string Name {get; protected set;}
    public int Codigo {get; protected set;}
    public int CargaHoraria {get; protected set;}
    

    public Curso(string nome, int codigo, int horas)
    {
        this.Name = nome;
        this.Codigo = codigo;
        this.CargaHoraria = horas;
    }
}


public class Aluno 
{
    public int CodCurso {get; set;}
    public string Name {get; protected set;}
    public int Matricula {get; protected set;}
    public int Nota { get; set; }


    public Aluno(string nome, int matricula, int codigo)
    {
        this.Name = nome;
        this.CodCurso = codigo;
        this.Matricula = matricula;
    }
}


public static class MySystem
{
    public static Aluno [] Alunos {get; private set;} = new Aluno[100];
    public static Curso [] Cursos {get; private set;} = new Curso[100];


    private static int indexAluno {get; set;} = 0;
    private static int indexCurso {get; set;} = 0;



    private static bool TemCurso {get; set;} = false;



    private static int Aprovados {get; set;} = 0;
    private static int Reprovados {get; set;} = 0;

    private static void AdicionarAluno (Aluno aluno)
    {
        MySystem.Alunos[MySystem.indexAluno] = aluno;
        MySystem.indexAluno++;
    }
    private static void AdicionarCurso (Curso curso)
    {
        MySystem.Cursos[MySystem.indexCurso] = curso;
        MySystem.indexCurso++;
    }


    public static void Program()
    {
        while (true)
        {
            Console.WriteLine("\n\n\n\n1 - Cadastrar curso\n2 - Listar cursos\n3 - Cadastrar Aluno\n4 - Dar notas\n5 - Estatisticas\n6 - Sair");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do curso: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o codigo do curso: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a carga horaria: ");
                int hora = int.Parse(Console.ReadLine());

                Curso curso = new Curso(nome, codigo, hora);
                MySystem.AdicionarCurso(curso);
            }            


            else if (opcao == 2)
            {
                Console.WriteLine("Lista de Cursos: ");
                foreach (var item in Cursos)
                    if (item != null)
                        Console.WriteLine($"{item.Name} ---- {item.Codigo}");
                    else break;
            }  


            else if (opcao == 3)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();


                Console.WriteLine("Digite o codigo do curso: ");
                int codigo = int.Parse(Console.ReadLine());


                Console.WriteLine("Digite a matricula do aluno: ");
                int matricula = int.Parse(Console.ReadLine());


                TemCurso = false;
                foreach (var item in Cursos)
                {
                    if (codigo  == item?.Codigo)
                    {
                        Aluno aluno = new Aluno(nome, codigo, matricula);
                        MySystem.AdicionarAluno(aluno);
                        Console.WriteLine(aluno.CodCurso);
                        TemCurso = true;
                        break;
                    }
                }
                if (TemCurso == false)
                    Console.WriteLine("Curso inexistente!");
            }


            else if (opcao == 4)
            {

                Console.WriteLine("Digite o codigo do curso: ");
                int codigoCurso = int.Parse(Console.ReadLine());
                foreach (var item in Alunos)
                {
                    if (item != null)
                        if (item.CodCurso == codigoCurso)
                        {
                            Console.WriteLine($"Digite a nota do aluno {item.Name}: ");
                            int NotaAluno = int.Parse(Console.ReadLine());
                            item.Nota = NotaAluno;
                        }
                    else 
                    {
                        Console.WriteLine("Alguns alunos não estão matriculados em nenhum curso!");
                        break;
                    }
                }
            }


            else if (opcao == 5)
            {
                Console.WriteLine("Digite o codigo do curso: ");
                int codigoCurso = int.Parse(Console.ReadLine());
                foreach (var item in Alunos)
                {
                    if (item != null)
                        if (item?.CodCurso == codigoCurso)
                        {
                            if (item.Nota > 7)
                                Aprovados++;
                            else
                                Reprovados++;
                        }
                    else 
                    {
                        Console.WriteLine("Alguns alunos não possuem notas cadastradas!");
                        break;
                    }
                }
                Console.WriteLine($"Alunos aprovados: {Aprovados}   ///   Alunos Reprovados: {Reprovados}");
            }

            
            else if (opcao == 6)
                break;
        }
    }

}