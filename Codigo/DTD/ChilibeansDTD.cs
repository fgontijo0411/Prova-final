using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAVIO_12_3A1.Codigo.DTD
{
    class chilibeansDTO
    {
        private int _id;
        private string _oculos;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Oculos { get => _oculos; set => _oculos = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
