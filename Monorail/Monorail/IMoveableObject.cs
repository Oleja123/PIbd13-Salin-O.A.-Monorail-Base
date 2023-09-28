using Monorail.DrawningObjects;

namespace Monorail.MovementStrategy
{
    public interface IMoveableObject
    {
        ObjectParameters? GetObjectPosition { get; }

        int GetStep { get; }

        bool CheckCanMove(DirectionType direction);

        void MoveObject(DirectionType direction);

    }
}
