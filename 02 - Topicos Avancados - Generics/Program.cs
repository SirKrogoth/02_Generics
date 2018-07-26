using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02___Topicos_Avancados___Generics.Modelo;
using System.IO;

namespace _02___Topicos_Avancados___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { marca = "FIAT", modelo = "UNO" };
            Casa casa = new Casa() { cidade = "Brasilia", endereco = "QSSQ 400" };
            Usuario usuario = new Usuario() { nome = "João", email = "joao@teleconsistemas.com.br", senha = "12345678" };

            Serializacao.Serializar(carro);
            Serializacao.Serializar(casa);
            Serializacao.Serializar(usuario);

            Carro carro2 = Serializacao.Deserializar();
            Casa casa2 = Serializacao.Deserializar();
            Usuario usuario2 = Serializacao.Deserializar();
        }
    }
}
