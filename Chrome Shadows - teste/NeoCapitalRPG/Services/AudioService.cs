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

namespace NeoCapitalRPG.Servicos
{
    private Thread _thread;
    private bool _parar;


    public void TocarMusicaEmLoop(string caminhoArquivo, float volume = 1.0f)
    {
        try
        {
            if (_thread != null && _thread.IsAlive) return;


            _parar = false;
            _thread = new Thread(() =>
            {
                try
                {
                    using (var audioFile = new AudioFileReader(caminhoArquivo))
                    using (var output = new WaveOutEvent())
                    {
                        output.Init(audioFile);
                        output.Volume = volume;


                        while (!_parar)
                        {
                            audioFile.Position = 0;
                            output.Play();


                            while (output.PlaybackState == PlaybackState.Playing && !_parar)
                            {
                                Thread.Sleep(100);
                            }


                            output.Stop();
                        }
                    }
                }
                catch
                {
                    // falha em tocar áudio não deve travar o jogo
                }
            });


            _thread.IsBackground = true;
            _thread.Start();
        }
        catch { }
    }


    public void PararMusica()
    {
        _parar = true;
        try { _thread?.Join(300); } catch { }
        _thread = null;
    }
}
