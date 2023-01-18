using System.Globalization;
using ExercicioPoo3;
using System;
using System.Reflection;

namespace ExercicioPoo3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Leão meuLeao = new Leão();
            meuLeao.nome = "Simba";
            meuLeao.dataDeNascimento = new DateTime(2005, 06, 11);
            meuLeao.idade = 18;
            meuLeao.sexo = 'M';
            meuLeao.carnivoro = true;
            meuLeao.peconhento = false;
            meuLeao.qtdeDeMamas = 8;
            meuLeao.pelos = true;
            meuLeao.corDoPelo = "Bege";

            Console.WriteLine("Olá, você cadastrou o animal Leão! O nome dele é " + meuLeao.nome + '\n' + "Data de nascimento: " + meuLeao.dataDeNascimento
            + '\n' + "Idade em anos: " + meuLeao.idade + '\n' + "Sexo " + meuLeao.sexo + '\n' + "Animal mamífero. Quantidade de mamas: " 
            + meuLeao.qtdeDeMamas + '\n' + "Cor do pêlo: " + meuLeao.corDoPelo);

            meuLeao.Alimentar();
            meuLeao.Movimentar();
            meuLeao.Comunicar();
            
            Console.WriteLine("__________________________________________________");


            Chacal meuChacal = new Chacal();
            meuChacal.nome = "Lulu";
            meuChacal.dataDeNascimento = new DateTime(2012, 10, 21);
            meuChacal.idade = 11;
            meuChacal.sexo = 'F';
            meuChacal.carnivoro = false;
            meuChacal.peconhento = false;
            meuChacal.qtdeDeMamas = 8;
            meuChacal.pelos = true;
            meuChacal.corDoPelo = "Bege";

            Console.WriteLine("Olá, você cadastrou o animal Chacal! O nome dele é " + meuChacal.nome + '\n' + "Data de nascimento: " + meuChacal.dataDeNascimento
            + '\n' + "Idade em anos: " + meuChacal.idade + '\n' + "Sexo " + meuChacal.sexo + '\n' + "Animal mamífero. Quantidade de mamas: "
            + meuChacal.qtdeDeMamas + '\n' + "Cor do pêlo: " + meuChacal.corDoPelo);

            meuChacal.Movimentar();
            meuChacal.Comunicar();
            meuChacal.Alimentar();
            meuChacal.Amamentar();

            Console.WriteLine("__________________________________________________");


            Morcego meuMorcego = new Morcego();
            meuMorcego.nome = "Batman";
            meuMorcego.dataDeNascimento = new DateTime(2022, 01, 04);
            meuMorcego.idade = 1;
            meuMorcego.sexo = 'M';
            meuMorcego.carnivoro = false;
            meuMorcego.peconhento = false;
            meuMorcego.qtdeDeMamas = 2;
            meuMorcego.pelos = true;
            meuMorcego.corDoPelo = "Preto";
            meuMorcego.altitudeMaximaEmMetros = 10;
            meuMorcego.velocidadeDoVoo = 160.0;

            Console.WriteLine("Olá, você cadastrou o animal Morcego! O nome dele é " + meuMorcego.nome + '\n' + "Data de nascimento: " + meuMorcego.dataDeNascimento
            + '\n' + "Idade em anos: " + meuMorcego.idade + '\n' + "Sexo " + meuMorcego.sexo + '\n' + "Animal mamífero. Quantidade de mamas: "
            + meuMorcego.qtdeDeMamas + '\n' + "Cor do pêlo: " + meuMorcego.corDoPelo + '\n' + "Altitude máxima alcançada em metros: " + meuMorcego.altitudeMaximaEmMetros + 
            '\n' + "Velocidade de vôo: " + meuMorcego.velocidadeDoVoo);


            meuMorcego.Voar(); 
            meuMorcego.Movimentar();
            meuMorcego.Comunicar();
            meuMorcego.Alimentar();

            Console.WriteLine("__________________________________________________");
            

            Cisne meuCisne = new Cisne();
            meuCisne.nome = "Cirilla";
            meuCisne.dataDeNascimento = new DateTime(2011, 10, 20);
            meuCisne.idade = 11;
            meuCisne.sexo = 'F';
            meuCisne.carnivoro = false;
            meuCisne.peconhento = false;
            meuCisne.rapina = false;
            meuCisne.corPena = "Branco";
            meuCisne.viveEmTerra = true;
            meuCisne.mergulho = true;
            meuCisne.aguaDoce = true;
            meuCisne.altitudeMaximaEmMetros = 9;
            meuCisne.velocidadeDoVoo = 80.0;


            Console.WriteLine("Olá, você cadastrou o animal Cisne! O nome dele é " + meuCisne.nome + '\n' + "Data de nascimento: " + meuCisne.dataDeNascimento
            + '\n' + "Idade em anos: " + meuCisne.idade + '\n' + "Sexo " + meuCisne.sexo + '\n' + "Cor das penas: "
            + meuCisne.corPena + '\n' + "Animal capaz de viver em terra e de viver em água doce. Além da capacidade de mergulhar!" + '\n' +
             "Altitude máxima alcançada em metros: " + meuCisne.altitudeMaximaEmMetros + '\n' + "Velocidade de vôo: " + meuCisne.velocidadeDoVoo);

            meuCisne.Voar(); 
            meuCisne.Movimentar();
            meuCisne.Comunicar();
            meuCisne.Alimentar();
            meuCisne.Botar();
            meuCisne.Chocar();

            Console.WriteLine("__________________________________________________");


            Arara minhaArara = new Arara();
            minhaArara.nome = "Aurora";
            minhaArara.dataDeNascimento = new DateTime(2000, 08, 01);
            minhaArara.idade = 22;
            minhaArara.sexo = 'F';
            minhaArara.carnivoro = false;
            minhaArara.peconhento = false;
            minhaArara.rapina = false;
            minhaArara.corPena = "Vermelha";
            minhaArara.altitudeMaximaEmMetros = 11000;
            minhaArara.velocidadeDoVoo = 160;


            Console.WriteLine("Olá, você cadastrou o animal Arara! O nome dele é " + minhaArara.nome + '\n' + "Data de nascimento: " + minhaArara.dataDeNascimento
            + '\n' + "Idade em anos: " + minhaArara.idade + '\n' + "Sexo " + minhaArara.sexo + '\n' + "Cor das penas: "
            + minhaArara.corPena + '\n' + "Altitude máxima alcançada em metros: " + minhaArara.altitudeMaximaEmMetros + '\n' + "Velocidade de vôo: " + minhaArara.velocidadeDoVoo);

            meuCisne.Voar();
            meuCisne.Movimentar();
            meuCisne.Comunicar();
            meuCisne.Alimentar();
            meuCisne.Botar();
            meuCisne.Chocar();

            Console.WriteLine("__________________________________________________");


            DragãodeKomodo meuDragao = new DragãodeKomodo();
            meuDragao.nome = "Banguela";
            meuDragao.dataDeNascimento = new DateTime(2022, 01, 17);
            meuDragao.idade = 01;
            meuDragao.sexo = 'F';
            meuDragao.carnivoro = true;
            meuDragao.peconhento = true;
            meuDragao.viveEmTerra = true;
            meuDragao.mergulho = true;
            meuDragao.aguaDoce = false;
            meuDragao.temEscamas = true;
            meuDragao.temCasco = false; 
          

            Console.WriteLine("Olá, você cadastrou o animal Dragão de Komodo! O nome dele é " + meuDragao.nome + '\n' + "Data de nascimento: " + meuDragao.dataDeNascimento
            + '\n' + "Idade em anos: " + meuDragao.idade + '\n' + "Sexo " + meuDragao.sexo + '\n' + "Animal peçonhento, cuidado!" + '\n' + 
            "Animal capaz de viver em terra,além da capacidade de mergulhar!" + '\n' + "Animal possui escamas!");

            meuDragao.Movimentar();
            meuDragao.Comunicar();
            meuDragao.Alimentar();
            meuDragao.Botar();
            meuDragao.Chocar();

            Console.WriteLine("__________________________________________________");


            Lontra minhaLontra = new Lontra();
            minhaLontra.nome = "Fofinho";
            minhaLontra.dataDeNascimento = new DateTime(2020, 05, 23);
            minhaLontra.idade = 02;
            minhaLontra.sexo = 'M';
            minhaLontra.carnivoro = true;
            minhaLontra.peconhento = false;
            minhaLontra.viveEmTerra = true;
            minhaLontra.mergulho = true;
            minhaLontra.aguaDoce = true;
            minhaLontra.qtdeDeMamas = 6;
            minhaLontra.corDoPelo = "Cinza";

            Console.WriteLine("Olá, você cadastrou o animal Lontra! O nome dele é " + minhaLontra.nome + '\n' + "Data de nascimento: " + minhaLontra.dataDeNascimento
            + '\n' + "Idade em anos: " + minhaLontra.idade + '\n' + "Sexo " + minhaLontra.sexo + '\n' + "Animal capaz de viver em terra e de viver em água doce. Além da capacidade de mergulhar!" 
            + '\n' + "Animal mamífero. Quantidade de mamas: " + minhaLontra.qtdeDeMamas + '\n' + "Cor do pêlo: " + minhaLontra.corDoPelo);

            minhaLontra.Movimentar();
            minhaLontra.Comunicar();
            minhaLontra.Alimentar();

            Console.WriteLine("__________________________________________________");


            Pinguim meuPinguim = new Pinguim();
            meuPinguim.nome = "Pingo";
            meuPinguim.dataDeNascimento = new DateTime(2013, 10, 3);
            meuPinguim.idade = 19;
            meuPinguim.sexo = 'F';
            meuPinguim.carnivoro = true;
            meuPinguim.peconhento = false;
            meuPinguim.rapina = false;
            meuPinguim.corPena = "Preto";
            meuPinguim.viveEmTerra = true;
            meuPinguim.mergulho = true;
            meuPinguim.aguaDoce = false;


            Console.WriteLine("Olá, você cadastrou o animal Pinguim! O nome dele é " + meuPinguim.nome + '\n' + "Data de nascimento: " + meuPinguim.dataDeNascimento
            + '\n' + "Idade em anos: " + meuPinguim.idade + '\n' + "Sexo " + meuPinguim.sexo + '\n' + "Cor das penas: "
            + meuCisne.corPena + '\n' + "Animal capaz de viver em terra e de mergulhar!");

            meuPinguim.Movimentar();
            meuPinguim.Comunicar();
            meuPinguim.Alimentar();
            meuPinguim.Botar();
            meuPinguim.Chocar();

            Console.WriteLine("__________________________________________________");


            Coruja minhaCoruja = new Coruja();
            minhaCoruja.nome = "Edwirges";
            minhaCoruja.dataDeNascimento = new DateTime(2015, 07, 25);
            minhaCoruja.idade = 7;
            minhaCoruja.sexo = 'F';
            minhaCoruja.carnivoro = true;
            minhaCoruja.peconhento = false;
            minhaCoruja.rapina = true;
            minhaCoruja.corPena = "Branco";
            minhaCoruja.altitudeMaximaEmMetros = 9000;
            minhaCoruja.velocidadeDoVoo = 15.0;


            Console.WriteLine("Olá, você cadastrou o animal Coruja! O nome dele é " + minhaCoruja.nome + '\n' + "Data de nascimento: " + minhaCoruja.dataDeNascimento
            + '\n' + "Idade em anos: " + minhaCoruja.idade + '\n' + "Sexo " + minhaCoruja.sexo + '\n' + "Cor das penas: "
            + minhaCoruja.corPena + '\n' + "Considerada uma ave de rapina!" + '\n' +
             "Altitude máxima alcançada em metros: " + minhaCoruja.altitudeMaximaEmMetros + '\n' + "Velocidade de vôo: " + minhaCoruja.velocidadeDoVoo);

            minhaCoruja.Voar();
            minhaCoruja.Movimentar();
            minhaCoruja.Comunicar();
            minhaCoruja.Alimentar();
            minhaCoruja.Botar();
            minhaCoruja.Chocar();

            Console.WriteLine("__________________________________________________");


            Elefante meuElefante = new Elefante();
            meuElefante.nome = "Dumbo";
            meuElefante.dataDeNascimento = new DateTime(2004, 11, 17);
            meuElefante.idade = 17;
            meuElefante.sexo = 'F';
            meuElefante.carnivoro = false;
            meuElefante.peconhento = false;
            meuElefante.qtdeDeMamas = 2;
            meuElefante.pelos = true;
            meuElefante.corDoPelo = "Cinza";

            Console.WriteLine("Olá, você cadastrou o animal Elefante! O nome dele é " + meuElefante.nome + '\n' + "Data de nascimento: " + meuElefante.dataDeNascimento
            + '\n' + "Idade em anos: " + meuElefante.idade + '\n' + "Sexo " + meuElefante.sexo + '\n' + "Animal mamífero. Quantidade de mamas: "
            + meuElefante.qtdeDeMamas + '\n' + "Cor do pêlo: " + meuElefante.corDoPelo);

            meuElefante.Alimentar();
            meuElefante.Movimentar();
            meuElefante.Comunicar();
            meuElefante.Amamentar();

            Console.WriteLine("__________________________________________________");


            Jacaré meuJacare = new Jacaré();
            meuJacare.nome = "Croc";
            meuJacare.dataDeNascimento = new DateTime(2021, 01, 09);
            meuJacare.idade = 02;
            meuJacare.sexo = 'M';
            meuJacare.carnivoro = true;
            meuJacare.peconhento = false;
            meuJacare.viveEmTerra = true;
            meuJacare.mergulho = true;
            meuJacare.aguaDoce = true;
            meuJacare.temEscamas = true;
            meuJacare.temCasco = false;


            Console.WriteLine("Olá, você cadastrou o animal Jacaré! O nome dele é " + meuJacare.nome + '\n' + "Data de nascimento: " + meuJacare.dataDeNascimento
            + '\n' + "Idade em anos: " + meuJacare.idade + '\n' + "Sexo " + meuJacare.sexo + '\n' + "Animal capaz de viver em terra e de viver em água doce. Além da capacidade de mergulhar!" 
            + '\n' + "Animal possui escamas!");

            meuJacare.Movimentar();
            meuJacare.Comunicar();
            meuJacare.Alimentar();

            Console.WriteLine("__________________________________________________");


            Ornitorrinco meuOrnitorrinco = new Ornitorrinco();
            meuOrnitorrinco.nome = "Aika";
            meuOrnitorrinco.dataDeNascimento = new DateTime(2016, 08, 24);
            meuOrnitorrinco.idade = 06;
            meuOrnitorrinco.sexo = 'F';
            meuOrnitorrinco.carnivoro = true;
            meuOrnitorrinco.peconhento = true;
            meuOrnitorrinco.qtdeDeMamas = 0;
            meuOrnitorrinco.pelos = true;
            meuOrnitorrinco.corDoPelo = "Bege";
            meuOrnitorrinco.viveEmTerra = true;
            meuOrnitorrinco.mergulho = true;
            meuOrnitorrinco.aguaDoce = true;

            Console.WriteLine("Olá, você cadastrou o animal Ornitorrinco! O nome dele é " + meuOrnitorrinco.nome + '\n' + "Data de nascimento: " + meuOrnitorrinco.dataDeNascimento
            + '\n' + "Idade em anos: " + meuOrnitorrinco.idade + '\n' + "Sexo " + meuOrnitorrinco.sexo + '\n' + "Animal peçonhento, cuidado!" + '\n' +  "Animal mamífero. Quantidade de mamas: "
            + meuOrnitorrinco.qtdeDeMamas + '\n' + "Cor do pêlo: " + meuOrnitorrinco.corDoPelo + '\n' + "Animal capaz de viver em terra e de viver em água doce. Além da capacidade de mergulhar!");

            meuOrnitorrinco.Movimentar();
            meuOrnitorrinco.Comunicar();
            meuOrnitorrinco.Alimentar();
            meuOrnitorrinco.Amamentar();

        }
    }
}