using NAudio.Wave;

namespace AudioEditor.Classes.WaveFormVisualizing
{
    interface IPeakProvider
    {
        void Init(ISampleProvider reader, int samplesPerPixel);
        PeakInfo GetNextPeak();
    }
}
