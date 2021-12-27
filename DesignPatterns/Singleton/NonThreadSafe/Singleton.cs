using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.NonThreadSafe
{
    // A classe Singleton define o método `GetInstance` que serve como um
    // alternativa ao construtor e permite que os clientes acessem a mesma instância de
    // esta classe indefinidamente.

    // PT: O Singleton deve ser sempre uma classe 'selada' para evitar a classe
    // herança por meio de classes externas e também por meio de classes aninhadas.
    public sealed class Singleton
    {
        // O construtor do Singleton deve ser sempre privado para evitar
        // chamadas de construção diretas com o operador `new`.
        private Singleton() { }

        // A instância do Singleton é armazenada em um campo estático. Existem existem
        // várias maneiras de inicializar este campo, todas elas têm vários prós
        // e cons. Neste exemplo, mostraremos a forma mais simples,
        // que, no entanto, não funciona muito bem em um programa multithread.
        private static Singleton _instance;

        // Este é o método estático que controla o acesso ao singleton
        // instância. Na primeira execução, ele cria um objeto singleton e coloca
        // para o campo estático. Em execuções subsequentes, ele retorna o cliente
        // objeto existente armazenado no campo estático.
        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        // Finalmente, qualquer singleton deve definir alguma lógica de negócios, que pode
        // ser executado em sua instância.
        public static void someBusinessLogic()
        {
            // ...
        }
    }
}
