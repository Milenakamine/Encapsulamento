using System;

namespace Encapsulamento
{
    public class MasterCard: Cartao
    {
        public int parcelas { get; set; }   

        public void ComprarComDescontoMasterCard (float desconto)  {
        Console.WriteLine($"Compra realizada com {parcelas} parcelas e R${desconto} de desconto");
        }
    }
}