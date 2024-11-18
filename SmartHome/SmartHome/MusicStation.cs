using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class MusicStation
    {
        private int _currentTrack;
        public bool IsTurnedOn { get; set; }
        public List<string> Tracks { get; set; }
        public int CurrentTrack { get { return _currentTrack; } set { if (value < 0) { _currentTrack = 0; } else if (value > Tracks.Count - 1) { _currentTrack = Tracks.Count - 1; } else { _currentTrack = value; } } }

        public MusicStation(bool isTurnedOn, List<string> tracks)
        {
            IsTurnedOn = isTurnedOn;
            Tracks = tracks;
            CurrentTrack = 0;
        }

        public void Switch(bool Switch)
        {
            IsTurnedOn = Switch;
        }
        public void SetMusic(int currentTrack)
        {
            if(IsTurnedOn)
            {
                Console.WriteLine($"Now playing: {Tracks[currentTrack]}");
                CurrentTrack = currentTrack;
            }
            else
            {
                Console.WriteLine("The station is off, cannot set music");
            }
        }
        public override string ToString()
        {
            return $"Is On: {IsTurnedOn}; Current Track: {Tracks[CurrentTrack]}";
        }
    }
}
