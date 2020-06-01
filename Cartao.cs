using System;

namespace Encapsulamento
{
    public class Cartao
    {
        // expansao é tudo aquilo que desejamos que a classe filha nao tenha acesso
        public string numero { get; set; }  
        // set premissao de leitura, get permissao de escrita; prop é de propriedade
        //se nao colocar a assinatura, ele se torna private automaticamente

        public string titular { get; set; }

        public string bandeira { get; set; }

       private string token = "65465465465465465313213465465469879879845545545454545";
// variavel do tipo privado é quando eu nao pretendo editar ela
       protected string cvv {get; set;}
    //cvv codigo de segurança

       public void AprovarCompra(){
        Console.WriteLine("Compra aprovada!"); 
       }
        //  void = metodo em retorno, pode trabalhar com numero e console(nao recomendavel)

        private bool ValidarToken(){
        if (token !=null){
               return true;
           } 
           return false;
        
        
        }

        private bool ValidarCartao(){
            return true;
        }
    }
}