using System;
using System.Collections.Generic;

namespace projeto.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public int NivelBateria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            NivelBateria = 100; // Nível de bateria começa em 100%
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void FazerChamada(string numeroDestino)
        {
            Console.WriteLine($"Fazendo chamada para {numeroDestino}...");
        }

        public void EnviarMensagem(string numeroDestino, string mensagem)
        {
            Console.WriteLine($"Enviando mensagem para {numeroDestino}: {mensagem}");
        }

        public void ReproduzirMusica(string nomeMusica)
        {
            Console.WriteLine($"Reproduzindo a música: {nomeMusica}");
        }

        
        public void ConfigurarBrilhoTela(int nivelBrilho)
        {
            Console.WriteLine($"Configurando brilho da tela para {nivelBrilho}%");
        }

        public void AjustarVolume(int nivelVolume)
        {
            Console.WriteLine($"Ajustando o volume para {nivelVolume}%");
        }

        public void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo: {nomeApp}");
        }
    }
}
