using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monorail.DrawningObjects;

namespace Monorail.MovementStrategy
{
    public class DrawningObjectMonorail : IMoveableObject
    {
        private readonly DrawningMonorail? _drawningMonorail = null;

        public DrawningObjectMonorail(DrawningMonorail drawningMonorail)
        {
            _drawningMonorail = drawningMonorail;
        }

        public ObjectParameters? GetObjectPosition
        {
            get
            {
                if (_drawningMonorail == null || _drawningMonorail.EntityMonorail == null)
                {
                    return null;
                }
                return new ObjectParameters(_drawningMonorail.GetPosX,
                _drawningMonorail.GetPosY, _drawningMonorail.GetWidth, _drawningMonorail.GetHeight);
            }

        }
        public int GetStep => (int)(_drawningMonorail?.EntityMonorail?.Step ?? 0);
        public bool CheckCanMove(DirectionType direction) =>
        _drawningMonorail?.CanMove(direction) ?? false;
        public void MoveObject(DirectionType direction) =>
        _drawningMonorail?.MoveTransport(direction);
    }
}

