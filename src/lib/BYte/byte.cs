using System;

namespace BYte
{
    public class GetByte
    {
        private byte nMaximo;
        private byte nMinimo;
        private bool assinado;
        private byte valor = 1;
        public byte ByteMax { get => nMaximo; set => nMaximo = value; }
        public byte ByteMin { get => nMinimo; set => nMinimo = value; }
        public string Titulo {
            get => $"Assinatura: {assinado}, Bytes: {valor}, Valores Possiveis: {ByteMin = byte.MaxValue} à {ByteMax = byte.MinValue}";
            set => Titulo = value;
        }
    }
}
