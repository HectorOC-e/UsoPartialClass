using System;

namespace UsoCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();

            Console.WriteLine(coche2.GetInfoCoche());
            Console.WriteLine(coche1.GetInfoCoche());

            Coche coche3= new Coche(4500.25, 1200.35);
            Console.WriteLine(coche3.GetInfoCoche());

            //coche3.SetExtras(true, "Cuero");

            Console.WriteLine(coche3.GetExtras());

        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            climatizador = true;
            tapiceria = "Tela";
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }

    }

    partial class Coche 
    { 
        public String GetInfoCoche() => $"Información del coche: \nRuedas: {ruedas}, Largo: {largo}, Ancho: {ancho}";
        
        public void SetExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string GetExtras() => $"Extras del coche:\nClimatizador: {(climatizador ? "Tiene a/c" : "No tiene a/c")}\nTapicería: {tapiceria}";

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;


    }
}
