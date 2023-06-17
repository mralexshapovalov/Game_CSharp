using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Position
    {

        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row= row; Col = col;    
        }

        public Position Translation (Direction direction) => new Position(Row + direction.RowOffSet, Col + direction.ColOffSet);
        

        public override bool Equals(object obj) =>  obj is Position position && Row == position.Row && Col == position.Col;
       
        public override int GetHashCode() => HashCode.Combine(Row, Col);
       
        public static bool operator ==(Position left, Position right) => EqualityComparer<Position>.Default.Equals(left, right);
        

        public static bool operator !=(Position left, Position right) => !(left == right);
       
    }
}
