using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 95;
            master.ComprarComDescontoMasterCard(75f);
            // protect da para acessar nas classes filhas e pai, já a private só dá para acessar na classe pai
        }
    }
}
