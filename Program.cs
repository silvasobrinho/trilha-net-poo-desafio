using DesafioPOO.Models;

var celularNokia = new Nokia("24992999999", "Tijolão Max Turbo 12", "2136753746512677",32);
var celularIphone = new Iphone("24992888888", "Maça Pro Supimpa 33", "7346365432849727",64);

celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("Zap-zap");

celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Telegram 2.0");