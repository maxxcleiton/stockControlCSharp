// "Gostaria que o software da padaria JatubaAiDentro recebesse algumas melhorias

// irá ter um controle de estoque, que será acessado pelo menu ao digitar 0

//  onde irá entrar na parte de cadastro de estoque

// em que cada produto terá seu código de barra, a quantidade de produtos no estoque, e o seu valor, 
// ao digitar 1, o operador irá entrar na aba de vender produtos, deverá inserir o código de barras do produto e a quantidade, 

// o software irá buscar o produto desse codigo de barras, o valor do produto e realizar a multiplicação .linha 91

// fazendo o decremento dos produtos vendidos do estoque .linha 99

// adicione validação caso o produto não tenha no estoque (linha 92) ou o código de barras não exista 

// o programa deverá dar o total da compra quando o operador digitar o código de barras -1"

// Controle de estoque
// Acessado via menu - digitar 0
// Exemplo de menu inicial do programa:

// -------Padaria JabutaAiDentro-------- -
// ## Escolha uma das opções abaixo: ##
// 0 - Cadastrar estoque
// 1 - Iniciar caixa






using meuSegundoPrograma;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

List<StockProducts> stockProducts = new List<StockProducts>();

stockProducts.Add(new StockProducts() 
{
    BarCode = "4512431413123",
    Name = "Café",
    Quantity = 50,
    Amount = 10.50
});

stockProducts.Add(new StockProducts()
{
    BarCode = "4124123141",
    Name = "Arroz",
    Quantity = 50,
    Amount = 5.50
});



string MenuCHOICE = "3";
string choice2;
string choice3;

int NewQUANTITY;
int quantityVALIDATOR;

string barCode;
string quantity;



string Menu1() {
    Console.WriteLine("--------Padaria JabutaAiDentro--------");
    Console.WriteLine();
    Console.WriteLine("## Escolha uma das opções abaixo: ##");
    Console.WriteLine("0 - Cadastrar estoque");
    Console.WriteLine("1 - Iniciar caixa");
    Console.WriteLine();
    MenuCHOICE = Console.ReadLine();
    Console.WriteLine();

    return MenuCHOICE;
 }

Menu1();

while (MenuCHOICE == "1")
{
    Console.WriteLine("1 - INICIAR CAIXA");
    Console.WriteLine("CÓDIGO DE BARRAS:");
    barCode = Console.ReadLine();
    var stockProductsObject = stockProducts.Where(s => s.BarCode == barCode).FirstOrDefault();

    //  VALIDATOR //
    if (stockProductsObject == null)
    {
        Console.WriteLine("CÓDIGO DE BARRAS NÃO EXISTE");
        Console.WriteLine("INSIRA NOVAMENTE");
        Console.ReadLine();
        Menu1();

    };

    Console.WriteLine();
    Console.WriteLine("Produto: " + stockProductsObject.Name);
    Console.WriteLine("Valor do produto escolhido: R$ " + stockProductsObject.Amount);
    Console.WriteLine("Estoque atual do produto: " + stockProductsObject.Quantity + " unidades.");
    Console.WriteLine();

    Console.WriteLine("QUANTIDADE DESEJADA (EM UNIDADES):");
    quantity = Console.ReadLine();
    NewQUANTITY = Int32.Parse(quantity);
    stockProductsObject.Quantity = stockProductsObject.Quantity - NewQUANTITY;
    Console.WriteLine();

    Console.WriteLine("Deseja adicionar um novo produto?");
    Console.WriteLine("Sim (digite -1)");
    Console.WriteLine("Não (digite 2)");
    Console.WriteLine();

    choice2 = Console.ReadLine();
    if (choice2 == "-1")
    {
        Menu1();

    } else
    {

    Console.WriteLine("Valor total: R$ " + stockProductsObject.Amount * NewQUANTITY);
    Console.WriteLine();

    Console.WriteLine("Compra realizada com sucesso.");
    Console.WriteLine();
    
    Console.WriteLine();
    Console.WriteLine("1- Voltar para o menu principal");
    Console.ReadLine();
        Menu1();

    }


}



    // END VALIDATOR //
    /*

    quantityVALIDATOR = stockProductsObject.Quantity - NewQUANTITY;
    if (quantityVALIDATOR < 1)
    {
        Console.WriteLine("PRODUTO SEM ESTOQUE");
        Console.WriteLine("1 - INSERIR NOVAMENTE O CÓDIGO DE BARRAS");
        Console.WriteLine("3 - VOLTAR AO MENU PRINCIPAL");
        MenuCHOICE = Console.ReadLine();

        if (MenuCHOICE == "3")
        {
            Menu1();
        }
    }
    else
    {
        Console.WriteLine();
    }

    //Console.WriteLine(NewQUANTITY);



    Console.WriteLine("Você confirma a compra? s ou n");
    choice2 = Console.ReadLine();
    Console.WriteLine();

    if (choice2 == "s")
    {
        Console.WriteLine("Deseja efetuar uma nova compra? s ou n");
        choice3 = Console.ReadLine();
        if (choice3 == "n") { MenuCHOICE = "0"; };
    }
    else if (choice2 == "n")
    {
        Console.WriteLine("Compra encerrada.");
        Console.WriteLine();
    };

    Console.WriteLine();
}


////////////////////////////////

/*
if (choice1 == "0") {
Console.WriteLine("0 - Cadastrar estoque - Entrando...");
Console.WriteLine();
} else if (choice1 == "1") {
Console.WriteLine("1 - Iniciar caixa - Entrando...");
Console.WriteLine();
Console.WriteLine("--------Vender produtos--------");
Console.WriteLine();

// Inserção do código de barras:
Console.WriteLine("Insira o código de barras do produto: ");
barCode = Console.ReadLine();
Console.WriteLine();

// Localizar o produto via código de barras:

var stockProductsObject= stockProducts.Where(s => s.BarCode == barCode).FirstOrDefault();

if (stockProductsObject == null)
{
    Console.WriteLine("Não foi encontrado nenhum produto com o código de barras informado.");
    Console.WriteLine("Tente novamente");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------Padaria JabutaAiDentro--------");
    Console.WriteLine();
    Console.WriteLine("## Escolha uma das opções abaixo: ##");
    Console.WriteLine("0 - Cadastrar estoque");
    Console.WriteLine("1 - Iniciar caixa");
    Console.WriteLine();

    choice1 = Console.ReadLine();
} else { 

// Inserção da quantidade:
Console.WriteLine("Insira a quantidade desejada (unid): ");
quantity = Console.ReadLine();
int NewQuantity = Int32.Parse(quantity);
Console.WriteLine(NewQuantity);

// Validacao de estoque:
int quantityValidator = stockProductsObject.Quantity - NewQuantity;
    if (quantityValidator < 1)
    {
        Console.WriteLine("Produto encontra-se fora de estoque.");
        choice1 = "1";
    //    System.Environment.Exit(0);
    } else {
        Console.WriteLine();
        Console.WriteLine("Você escolheu o produto: " + stockProductsObject.Name);
        Console.WriteLine("Valor da unidade: " + stockProductsObject.Amount);
        Console.WriteLine("Valor total: " + stockProductsObject.Amount * NewQuantity);
    }

        Console.WriteLine("Você confirma a compra? s ou n");
        choice2 = Console.ReadLine();
        Console.WriteLine();

    if (choice2 == "s")
{
        stockProductsObject.Quantity = stockProductsObject.Quantity - NewQuantity;
        Console.WriteLine("A nova quantidade é: ", stockProductsObject.Quantity);
   }
else if (choice2 == "n")
{
    Console.WriteLine("Compra encerrada.");
    Console.WriteLine();
};

Console.WriteLine();
}
}



/*
foreach (var stockProduct in stockProducts)
{
Console.WriteLine();
Console.WriteLine("Seção do produto:");
Console.WriteLine("Código de Barras: " + stockProduct.BarCode);
Console.WriteLine("Nome: " + stockProduct.Name);
Console.WriteLine("Valor: " + stockProduct.Amount + "R$");
Console.WriteLine("Quantidade: " + stockProduct.Quantity + " unidades");
Console.WriteLine("---------------------------");
}
*/