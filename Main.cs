
class Tt_Bank_Interface{
                                                                                  

    // Painel de escolhas do usuario 
    public static void Main(){
            while (true)
            {
                        Console.Clear();
                       Banner();
                       
                       string escolha_usuario = Console.ReadLine();
                       switch (int.Parse(escolha_usuario))
                       {
                        case 1:
                            Console.WriteLine("Insira o valor que deseja sacar abaixo ");
                            string valor = Console.ReadLine();
                            TtBank_Backend.Sacar(decimal.Parse(valor));
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        case 2:
                            Console.WriteLine(Environment.NewLine);
                            TtBank_Backend.Ver_Saldo();

                            continue ;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("insira seu nome abaixo para criar uma conta ");
                            string nome = Console.ReadLine();
                            Console.Clear();
                            TtBank_Backend.Criar_conta(nome);
                            continue;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Insira o valor do deposito abaixo ");
                            var deposito = Console.ReadLine();
                            try
                            {
                            TtBank_Backend.Depositar(decimal.Parse(deposito));
                                
                            }
                            catch (System.Exception)
                            {
                                
                                Console.WriteLine("Caractere invalido inserido");
                                Console.ReadKey();
                            }
                            continue;
                            case 5:
                                Environment.Exit(0);
                                break;
                        default:
                            Console.WriteLine("Opcao invalida inserida, aperte enter para continuar");
                            Console.ReadKey();
                            continue;
                       }   
                              
            }
    }
    // banner do programa
    public static void Banner(){
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("                    ███████████ ███████████    ███████████    █████████   ██████   █████ █████   ████░ ");
                Console.WriteLine("                   ░█░░░███░░░█░█░░░███░░░█   ░░███░░░░░███  ███░░░░░███ ░░██████ ░░███ ░░███   ███░   ");
                Console.WriteLine("                    ░   ░███  ░ ░   ░███  ░     ░███    ░███ ░███    ░███  ░███░███ ░███  ░███  ███    ");
                Console.WriteLine("                        ░███        ░███        ░██████████  ░███████████  ░███░░███░███  ░███████     ");
                Console.WriteLine("                        ░███        ░███        ░███░░░░░███ ░███░░░░░███  ░███ ░░██████  ░███░░███    ");
                Console.WriteLine("                        ░███        ░███        ░███    ░███ ░███    ░███  ░███  ░░█████  ░███ ░░███   ");
                Console.WriteLine("                        █████       █████       ███████████  █████   █████ █████  ░░█████ █████ ░░████ ");
                Console.WriteLine("                        ░░░░░       ░░░░░       ░░░░░░░░░░░  ░░░░░   ░░░░░ ░░░░░    ░░░░░ ░░░░░   ░░░░ ");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("                        [1] Sacar            [2] Ver Saldo        [3] Criar Conta        [4] Depositar  [5] Sair ");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("                         Escolha uma opção: ");

                


    }
                
}
// Definindo as funcoes do banco 
public class TtBank_Backend{
    static private bool Conta_criada = false;
    static public decimal Saldo { get; private set;}

    // funcao para registrar uma conta 
    public static bool Criar_conta(string nome){  
        if(nome.Length >= 2 && Conta_criada == false)
        {
            try{
                int.Parse(nome);
                Console.WriteLine($"Insira um nome valido{Environment.NewLine}");
                Solicitar_enter();
            }
            catch(SystemException){
            Conta_criada = true;
            Console.Clear();
            Console.WriteLine("Conta criada com sucesso");
            Saldo = 0;
            Solicitar_enter();
            return true;    
            }

            }
        if (Conta_criada){
            Console.WriteLine("Erro, Voce ja possui uma conta criada");
            Solicitar_enter();
            return false;
        }
        Console.WriteLine("Nome invalido inserido");
            Solicitar_enter();
        return false;
    }

    // funcao para realizar um deposito e verificar a conta 
    public static bool Depositar(decimal valor){
        if (Conta_criada && valor > 0){
            Saldo = Saldo += valor;
            Console.WriteLine($"Saldo adicionado com sucesso, seu saldo atual e R$ : {Saldo}");
            Solicitar_enter();
            return true;
        }
        if ( Conta_criada == false) 
        {
            Console.WriteLine("Voce nao e um dos nossos clientes e n pode ter acesso a isto");
            Solicitar_enter();

            return false;

        }
        Console.WriteLine("deposito invalido, Tente novamente");
        Solicitar_enter();

        return false;
    }
    // funcao para verificar e realizar o saque 
    public static bool Sacar(decimal valor){
        Console.Clear();
        if (Conta_criada == false){
            Console.WriteLine("Voce nao e um dos clientes do banco, crie uma conta para continuar ");
            Solicitar_enter();

            return false;
        }
        if (Conta_criada && valor < Saldo ){
            Saldo = Saldo - valor;
            Console.Clear();
            Console.WriteLine($"Saldo sacado com sucesso {Environment.NewLine} seu saldo atual e : R$ {Saldo} {Environment.NewLine}");
            Solicitar_enter();
            return true;
        }
        if (Saldo <= 0 ){
            Console.WriteLine($"Erro, voce nao tem saldo suficiente para sacar {Environment.NewLine} Seu Saldo e : {Saldo} {Environment.NewLine}");
            Solicitar_enter();
            return false;
        }
        return false;
    }
    // funcao para ver o saldo atual 
    static public bool Ver_Saldo(){
        Console.Clear();
        if (Conta_criada){
            Console.WriteLine($"{Environment.NewLine}Seu Saldo atual e : R$ {Saldo} {Environment.NewLine}");
            Solicitar_enter();

            return true;
        }
        else{
            Console.WriteLine("Voce nao e nosso cliente, crie uma conta e tente novamente");
            Solicitar_enter();

            return false;
        }
        }
        // solicita a interacao do usuario 
        public static void Solicitar_enter(){
                Console.WriteLine("Pressione Enter para continuar ");
                Console.ReadKey();
        }
}
