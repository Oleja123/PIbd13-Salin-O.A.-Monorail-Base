using Monorail.DrawningObjects;

namespace Monorail.MovementStrategy
{
    public abstract class AbstractStrategy
    {
        private IMoveableObject? _moveableObject;

        private Status _state = Status.NotInit;

        protected int FieldWidth { get; private set; }

        protected int FieldHeight { get; private set; }

        public Status GetStatus() { return _state; }

        public void SetData(IMoveableObject moveableObject, int width, int height)
        {
            if (moveableObject == null)
            {
                _state = Status.NotInit;
                return;
            }
            _state = Status.InProgress;
            _moveableObject = moveableObject;
            FieldWidth = width;
            FieldHeight = height;
        }

        public void MakeStep()
        {
            if (_state != Status.InProgress)
            {
                return;
            }
            if (IsTargetDestinaion())
            {
                _state = Status.Finish;
                return;
            }
            MoveToTarget();
        }

        protected bool MoveLeft() => MoveTo(DirectionType.Left);

        protected bool MoveRight() => MoveTo(DirectionType.Right);

        protected bool MoveUp() => MoveTo(DirectionType.Up);

        protected bool MoveDown() => MoveTo(DirectionType.Down);

        protected ObjectParameters? GetObjectParameters =>
_moveableObject?.GetObjectPosition;

        protected int? GetStep()
        {
            if (_state != Status.InProgress)
            {
                return null;
            }
            return _moveableObject?.GetStep;
        }

        protected abstract void MoveToTarget();

        protected abstract bool IsTargetDestinaion();

        private bool MoveTo(DirectionType directionType)
        {
            if (_state != Status.InProgress)
            {
                return false;
            }
            if (_moveableObject?.CheckCanMove(directionType) ?? false)
            {
                _moveableObject.MoveObject(directionType);
                return true;
            }
            return false;
        }


    }
}
