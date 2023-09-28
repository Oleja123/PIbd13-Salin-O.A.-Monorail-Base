using Monorail.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    public class MoveToEdge : AbstractStrategy
    {
        protected override bool IsTargetDestinaion()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.RightBorder < FieldWidth && objParams.RightBorder + GetStep() >= FieldWidth &&
            objParams.DownBorder + GetStep() < FieldHeight && objParams.DownBorder + GetStep() >= FieldHeight;
        }

        protected override void MoveToTarget()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }
            var diffX = objParams.RightBorder - (FieldWidth-1);
            if (Math.Abs(diffX) > GetStep())
            {
                if (diffX < 0)
                {
                    MoveRight();
                }
            }
            var diffY = objParams.DownBorder - (FieldHeight-1);
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY < 0)
                {
                    MoveDown();
                }
            }
        }
    }
}
