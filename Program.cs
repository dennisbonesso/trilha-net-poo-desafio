using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia1 = new Nokia("123","abc","dcd", 123);
nokia1.InstalarAplicativo("Uber");
nokia1.Ligar();

Iphone iphone1 = new Iphone("1234","abcd","dcdc", 1234);
iphone1.InstalarAplicativo("Ifood");
iphone1.ReceberLigacao();
