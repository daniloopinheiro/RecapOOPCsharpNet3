using System;

namespace BOol
{
    public class GetBool
    {
        private bool verdadeiro;
        private bool falso;
        private bool assinado;
        private byte valor;
        public bool Verdadeiro { get => true; set => Verdadeiro = value; }
        public bool Falso { get => falso; set => Falso = value;}
        public string Titulo {
            get => $"Assinatura: {assinado}, Bytes: {valor.ToString("1/2")}, Valores Possiveis: {Verdadeiro}/{Falso}"; 
            set => Titulo = value;
        }
    }
}
