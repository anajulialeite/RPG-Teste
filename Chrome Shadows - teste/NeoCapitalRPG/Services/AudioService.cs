using NAudio.Wave;
using NeoCapitalRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NeoCapitalRPG.Helpers;

namespace NeoCapitalRPG.Servicos
{
    // Resolve: AudioService não pode ser encontrado
    public class AudioService
    {
        private AudioHelper _audioHelper;

        public AudioService()
        {
            _audioHelper = new AudioHelper();
        }

        public void PararMusica(string nome)
        {
            _audioHelper.Parar();
        }
    }
}