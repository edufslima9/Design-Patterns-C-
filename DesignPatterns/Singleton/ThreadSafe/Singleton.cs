using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    // Esta implementação de Singleton é chamada de "bloqueio de verificação dupla". É seguro
    // em ambiente multithread e fornece inicialização lenta para o
    // Objeto singleton.
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        // Agora temos um objeto de bloqueio que será usado para sincronizar threads
        // durante o primeiro acesso ao Singleton.
        private static readonly object _lock = new object();

        public static Singleton GetInstance(string value)
        {
            // Esta condicional é necessária para evitar que os threads tropecem no
            // bloqueio quando a instância está pronta.
            if (_instance == null)
            {
                // Agora, imagine que o programa acabou de ser lançado. Desde a
                // não há instância de Singleton ainda, vários threads podem
                // passa simultaneamente a condicional anterior e alcança isso
                // aponte quase ao mesmo tempo. O primeiro deles irá adquirir
                // bloqueia e prossegue, enquanto o resto espera aqui.
                lock (_lock)
                {
                    // O primeiro segmento a adquirir o bloqueio chega a este
                    // condicional, entra e cria o Singleton
                    // instância. Uma vez que sai do bloco de bloqueio, um segmento que
                    // pode estar esperando a liberação do bloqueio pode então
                    // entrar nesta seção. Mas como o campo Singleton é
                    // já inicializado, o thread não criará um novo
                    // objeto.
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        // Usaremos esta propriedade para provar que nosso Singleton realmente funciona.
        public string Value { get; set; }
    }
}
