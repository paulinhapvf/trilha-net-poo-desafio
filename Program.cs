using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//intanciando os objetos dos tipos Nokia e Iphone, respectivamente.
Nokia c1 = new Nokia("11995959595","Galaxy a54", "1234567876", 8);
Iphone c2 = new Iphone("11996969696","Galaxy G4", "6787654321", 4);

//testando os métodos Ligar e ReceberLigação, ambos herdados da classe Smartphone
//testando o método InstalarAplicativo, herdado da classe Smartphone, porém sobrescrito nas
//classes Nokia e Iphone para atender as especificidades.
c1.Ligar();
c1.ReceberLigacao();
c1.InstalarAplicativo("WhatsApp");
Console.WriteLine("---------------------------------");
c2.Ligar();
c2.InstalarAplicativo("Discord");
c2.ReceberLigacao();