using NAudio.Wave;
using System;
using System.IO;
using System.Threading;

namespace NeoCapitalRPG.Helpers
{
    public class AudioHelper
    {
        private WaveOutEvent _outputDevice;
        private Thread _thread;
        private volatile bool _parar = false;

        public AudioHelper()
        {
            // Inicialização do dispositivo de áudio
            _outputDevice = new WaveOutEvent();
        }

        public void Tocar(string arquivo)
        {
            // Lógica para tocar o arquivo de áudio
        }

        public void Parar()
        {
            _parar = true;
            if (_outputDevice != null)
            {
                _outputDevice.Stop();
            }
        }
    }
}