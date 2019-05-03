using System;
using System.Collections.Generic;

namespace Checkpoint.Model
{
    public class Configuracao
    {
        private IEnumerable<ushort> _testes;

        public IEnumerable<ushort> Testes
        {
            get
            {
                var result = new List<ushort>(this._prof.Count + 1) { this.M };

                result.AddRange(this._prof);

                return _testes ?? (_testes = result);
            }
        }

        private readonly IList<ushort> _prof = new List<ushort> { 5, 6, 7, 8, 9, 10, 20, 50, 100, 200, 500, 1000 };

        /// <summary> https://stackoverflow.com/questions/17080112/generate-random-uint </summary>
        private ushort M => (ushort)new Random(DateTime.Now.Millisecond).Next(1, 10000);

        public override string ToString() => $"Os testes para esta execução foram: {string.Join(", ", this.Testes)}";
    }
}