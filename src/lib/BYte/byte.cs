using System;

namespace BYte
{
    public class GetByte
    {
        private byte nMaximo = byte.MaxValue;
        private byte nMinimo = byte.MinValue;
        private bool assinado;
        private byte valor = 1;
        public byte ByteMax { get => nMaximo; set => nMaximo = value; }
        public byte ByteMin { get => nMinimo; set => nMinimo = value; }
        public string Titulo {
            get => $"Assinatura: {assinado}, Bytes: {valor}, Valores Possiveis: {ByteMin} à {ByteMax}";
            set => Titulo = value;
        }
    }
}
