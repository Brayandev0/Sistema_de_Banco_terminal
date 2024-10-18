``` 

                    ███████████ ███████████    ███████████    █████████   ██████   █████ █████   ████░ 
                   ░█░░░███░░░█░█░░░███░░░█   ░░███░░░░░███  ███░░░░░███ ░░██████ ░░███ ░░███   ███░   
                    ░   ░███  ░ ░   ░███  ░     ░███    ░███ ░███    ░███  ░███░███ ░███  ░███  ███    
                        ░███        ░███        ░██████████  ░███████████  ░███░░███░███  ░███████     
                        ░███        ░███        ░███░░░░░███ ░███░░░░░███  ░███ ░░██████  ░███░░███    
                        ░███        ░███        ░███    ░███ ░███    ░███  ░███  ░░█████  ░███ ░░███   
                        █████       █████       ███████████  █████   █████ █████  ░░█████ █████ ░░████ 
                        ░░░░░       ░░░░░       ░░░░░░░░░░░  ░░░░░   ░░░░░ ░░░░░    ░░░░░ ░░░░░   ░░░░ 
```

 O projeto TT Bank é uma aplicação bancária simples desenvolvida em C#. 
 Esta aplicação baseada em terminal permite que os usuários interajam com diversas funcionalidades bancárias, como criar contas, visualizar saldos, realizar saques e depósitos.

## Funcionalidades
- **Criar Conta** Permite ao usuário criar uma nova conta.
- **Depósito** O usuário pode depositar dinheiro em sua conta.
- **Saque** O usuário pode sacar dinheiro da sua conta, desde que tenha saldo suficiente.
- **Ver Saldo** Exibe o saldo atual da conta do usuário.
- **Sair** O usuário pode sair da aplicação.

O TT bank possui um menu facil e interativo de usar, para cada operacao escolha o numero no menu 
``` 
                        [1] Sacar            [2] Ver Saldo        [3] Criar Conta        [4] Depositar  [5] Sair 


                         Escolha uma opção: 
```

## Estrutura do Projeto

**Classe Tt_Bank_Interface** Contém o menu de interação e o loop principal da aplicação. Permite que o usuário escolha uma operação bancária.
**Classe TtBank_Backend** Define as funcionalidades bancárias como criação de contas, depósitos, saques e exibição de saldo. Ela também mantém o estado da conta do usuário.


## Operacoes 
**Criar Conta** Ao selecionar a opção 3, o usuário deve fornecer um nome válido. O sistema irá verificar e, se for válido, a conta será criada.


**Depósito** Para fazer um depósito, o usuário deve selecionar a opção 4 e inserir o valor desejado. O valor será adicionado ao saldo.


**Saque** Para sacar, o usuário seleciona a opção 1, insere o valor e, se houver saldo suficiente, o saque será realizado com sucesso.


**Ver Saldo** A opção 2 exibirá o saldo atual da conta.
