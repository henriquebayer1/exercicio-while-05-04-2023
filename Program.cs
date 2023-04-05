Console.WriteLine($"Digite o seu nome:");
string nome = Console.ReadLine();

while(nome.Length == 0 )
{Console.WriteLine($"ATENCAO DIGITE ALGO COMO NOME. Digite o seu nome:");
 nome = Console.ReadLine();}

Console.WriteLine($"Digite a sua idade (Ate 100 anos):");
int idade = int.Parse(Console.ReadLine());

while(idade >= 101 )
{Console.WriteLine($"ATENCAO DIGITE UMA IDADE ATE 100 ANOS. Digite a sua idade:");
 idade = int.Parse(Console.ReadLine());}

Console.WriteLine($"Digite o seu salario:");
int salario = int.Parse(Console.ReadLine());

while(salario < 1 )
{Console.WriteLine($"ATENCAO DIGITE UM SALARIO VALIDO (positivo). Digite o seu salario:");
 salario = int.Parse(Console.ReadLine());}

Console.WriteLine($"Digite o seu estado civil 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)):");
char estadoCivil = char.Parse(Console.ReadLine());

while(estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd' )
{Console.WriteLine($"ATENCAO DIGITE UMA DAS SEGUIINTES LETRAS CORRETAMENTE: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)):");
estadoCivil = char.Parse(Console.ReadLine());}
