using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_EASC_1179622LAB_PROGRA
{
    internal class Motocicleta
    {
        private int modelo = 2019;
        private double precio = 2000.00;
        private string marca = "Yamaha";
        private double iva = 0.12;

        public int Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Iva { get => iva; set => iva = value; }

        public void mostrarDatos(int _Modelo, double _Precio, string _Marca, double _Iva)
        {
            _Modelo = modelo;
            _Precio = precio;
            _Marca = marca;
            _Iva = iva;
        }
    }
}
