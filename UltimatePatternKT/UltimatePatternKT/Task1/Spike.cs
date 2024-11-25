using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task1
{
    public class Spike : I3DObject
    {
        public Vector3 Pos;
        public Vector3 Size;
        public Color Color;
        public int Id;

        public Spike(Vector3 pos, Vector3 size, Color color, int id)
        {
            Pos = pos;
            Size = size;
            Color = color;
            Id = id;
        }

        public I3DObject Clone()
        {
            Spike newSpike = new(Pos, Size, Color, Id);
            return newSpike;
        }
    }
}
