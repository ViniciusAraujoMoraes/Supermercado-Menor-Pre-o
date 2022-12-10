using orientação_ao_objeto_desafio_1___supermercado;

Produto Produto1 = new Produto();

Produto1.nome = "Banana Nanica";
Produto1.fabricante = "MD Alimentos";
Produto1.codigoDeBarras = 001;
Produto1.valorUnitario = 2.25;
Produto1.valorDeCompra = 1.75;
Produto1.quantidade = 80;

Produto Produto2 = new Produto();

Produto2.nome = "Cenoura";
Produto2.fabricante = "MD Alimentos";
Produto2.codigoDeBarras = 002;
Produto2.valorUnitario = 1.90;
Produto2.valorDeCompra = 1.25;
Produto2.quantidade = 70;

Produto Produto3 = new Produto();

Produto3.nome = "Batata";
Produto3.fabricante = "MD Alimentos";
Produto3.codigoDeBarras = 003;
Produto3.valorUnitario = 2.50;
Produto3.valorDeCompra = 1.85;
Produto3.quantidade = 20;

double totalDaCompra = (Produto3.valorDeCompra + Produto2.valorDeCompra + Produto1.valorDeCompra);


Console.WriteLine("o valor da compra é " + totalDaCompra);
