using System.Linq;

namespace AudioEditor.Classes.WaveFormVisualizing
{
    class MaxPeakProvider : PeakProvider
    {
        public override PeakInfo GetNextPeak()
        {
            var samplesRead = Provider.Read(ReadBuffer, 0, ReadBuffer.Length);
            var max = ReadBuffer.Take(samplesRead).Max();
            var min = ReadBuffer.Take(samplesRead).Min();
            return new PeakInfo(min, max);
        }
    }
}
