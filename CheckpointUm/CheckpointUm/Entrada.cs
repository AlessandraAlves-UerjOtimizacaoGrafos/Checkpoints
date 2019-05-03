using Checkpoint;
using NLog;
using System;

namespace CheckpointUm
{
    internal class Entrada
    {
        private Configuracao ParametrosExecucao { get; } = new Configuracao();

        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public Entrada() => this.SetupLogger();

        private static void Main(string[] args)
        {
            var self = new Entrada();

            try
            {
                foreach (var teste in self.ParametrosExecucao.Testes)
                {
                    Console.WriteLine(teste.ToString());

                    var grafo = new GrafoMatrizAdjacencia(teste);

                    grafo.
                }
            }
            catch (Exception ex)
            {
                self._logger.Error(ex);
            }
            finally
            {
                LogManager.Shutdown();
            }

            Console.Read();
        }

        /// <summary>
        /// Qualquer problema vou gravar no arquivo
        /// </summary>
        private void SetupLogger() =>
            AppDomain.CurrentDomain.UnhandledException += (s, e) => this._logger.Error(e.ExceptionObject);


    }
}