using API.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API
{
    public class PublicadorManager
    {
        private const string PublicadoresDbPath = "publicadores.json";
        private readonly List<Publicador> publicadores = new();

        public PublicadorManager()
        {
            this.ReadPublicadoresDb();
        }

        public void CrearPublicador(Publicador publicador)
        {
            this.publicadores.Add(publicador);
            this.WritePublicadoresDb();
        }

        private void ReadPublicadoresDb()
        {
            var json = File.ReadAllText(PublicadoresDbPath);
            this.publicadores.AddRange(JsonSerializer.Deserialize<List<Publicador>>(json));
        }

        private void WritePublicadoresDb()
        {
            string json = JsonSerializer.Serialize(this.publicadores);
            File.WriteAllText(PublicadoresDbPath, json);
        }
    }
}
