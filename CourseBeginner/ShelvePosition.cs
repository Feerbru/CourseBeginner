using System;
namespace CourseBeginner
{
    public struct ShelvePosition
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public ShelvePosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
