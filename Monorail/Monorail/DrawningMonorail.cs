﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    public class DrawningMonorail
    {
        public EntityMonorail? EntityMonorail { get; private set; }


        private int _pictureWidth;

        private int _pictureHeight;

        private int _startPosX = 0;

        private int _startPosY = 0;

        private int _monoRailWidth = 120;

        private int _monoRailHeight = 50;

        public bool Init(int speed, double weight, Color bodyColor, int width, int height, int wheelNumb, Color wheelColor, Color tireColor)
        {
            if (width <= _monoRailWidth || height <= _monoRailHeight)
                return false;
            _pictureWidth = width;
            _pictureHeight = height;
            EntityMonorail = new EntityMonorail();
            EntityMonorail.Init(speed, weight, bodyColor,wheelNumb,wheelColor, tireColor);
            return true;
        }

        public void SetPosition(int x, int y)
        {
            if (EntityMonorail == null)
                return;
            _startPosX = x;
            _startPosX = y;
            if(x + _monoRailWidth >= _pictureWidth || y + _monoRailHeight>= _pictureHeight)
            {
                _startPosX = 1;
                _startPosY = 1;
            }
        }

        public void MoveTransport(DirectionType direction)
        {
            if (EntityMonorail == null)
                return;
            switch (direction)
            {
                case DirectionType.Left:
                    if (_startPosX - EntityMonorail.Step >= 0)
                        _startPosX -= (int)EntityMonorail.Step;
                    else
                        _startPosX = 0;
                    break;
                case DirectionType.Up:
                    if (_startPosY - EntityMonorail.Step >= 0)
                        _startPosY -= (int)EntityMonorail.Step;
                    else
                        _startPosY = 0;
                    break;
                case DirectionType.Right:
                    if (_startPosX + EntityMonorail.Step + _monoRailWidth < _pictureWidth)
                        _startPosX += (int)EntityMonorail.Step;
                    else
                        _startPosX = _pictureWidth - _monoRailWidth;
                    break;
                case DirectionType.Down:
                    if (_startPosY + EntityMonorail.Step + _monoRailHeight < _pictureHeight)
                        _startPosY += (int)EntityMonorail.Step;
                    else
                        _startPosY = _pictureHeight - _monoRailHeight;
                    break;
            }
        }

        public void DrawPolyline(Pen pen, Graphics g, Point[] pointsArr)
        {
            if (pointsArr.Length < 2)
                return;
            for (int i = 1; i < pointsArr.Length; i++)
                g.DrawLine(pen, pointsArr[i - 1], pointsArr[i]);
        }

        public void DrawTransport(Graphics g)
        {
            if (EntityMonorail == null)
                return;
            Pen pen = new (Color.Black);
            Brush cartBrush = new SolidBrush(Color.Black);
            Pen windowPen = new(Color.Blue);
            Brush wheelBrush = new SolidBrush(EntityMonorail.WheelColor);
            Pen tirePen = new Pen(EntityMonorail.TireColor);
            int wheelSz = _monoRailHeight - _monoRailHeight * 7 / 10;
            if (_monoRailWidth - _monoRailWidth / 20 * 17 < wheelSz)
                wheelSz = _monoRailWidth - _monoRailWidth / 20 * 17;


            //нижняя часть локомотива
            Point[] pointsArrLow = { new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 5 * 2),
            new Point(_startPosX + _monoRailWidth / 10, _startPosY + _monoRailHeight / 5 * 2),
            new Point(_startPosX + _monoRailWidth / 10, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX + _monoRailWidth / 20 * 19, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX + _monoRailWidth / 20 * 19, _startPosY + _monoRailHeight / 5 * 2),
            new Point(_startPosX + _monoRailWidth / 10 * 5, _startPosY + _monoRailHeight / 5 * 2) };

            DrawPolyline(pen, g, pointsArrLow);

            //дверь локомотива
            Point[] pointsArrDoor = { new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 5 * 2),
            new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 5),
            new Point(_startPosX + _monoRailWidth / 10 * 5, _startPosY + _monoRailHeight / 5),
            new Point(_startPosX + _monoRailWidth / 10 * 5, _startPosY + _monoRailHeight / 5 * 3),
            new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 5 * 3) };
            g.DrawPolygon(pen, pointsArrDoor);

            //крыша локомотива
            Point[] pointsArrRoof = { new Point(_startPosX + _monoRailWidth / 10, _startPosY + _monoRailHeight / 5 * 2),
            new Point(_startPosX + _monoRailWidth / 10 * 2, _startPosY + _monoRailHeight / 10),
            new Point(_startPosX + _monoRailWidth /20 * 19, _startPosY + _monoRailHeight / 10),
            new Point(_startPosX + _monoRailWidth /20 * 19, _startPosY + _monoRailHeight / 5 * 2)};
            DrawPolyline(pen, g, pointsArrRoof);

            //передняя часть тележки
            Point[] pointsArrFrontCart = { new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX + _monoRailWidth / 10 * 2, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX, _startPosY + _monoRailHeight / 10 * 9),
            new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 10 * 9),
            new Point(_startPosX + _monoRailWidth / 10 * 4, _startPosY + _monoRailHeight / 10 * 7)};

            g.FillPolygon(cartBrush, pointsArrFrontCart);

            //задняя часть тележки
            Point[] pointsArrBackCart = { new Point(_startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX + _monoRailWidth / 10 * 9, _startPosY + _monoRailHeight / 10 * 7),
            new Point(_startPosX + _monoRailWidth, _startPosY + _monoRailHeight / 10 * 9),
            new Point(_startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 9)
            };

            g.FillPolygon(cartBrush, pointsArrBackCart);

            //левое окно
            Rectangle leftRect = new();
            leftRect.X = _startPosX + _monoRailWidth / 10 * 2;
            leftRect.Y = _startPosY + _monoRailHeight / 25 * 4;
            leftRect.Width = _monoRailWidth / 120 * 8;
            leftRect.Height = _monoRailHeight/ 50 * 10;
            g.DrawRectangle(windowPen, leftRect);

            //среднее окно
            Rectangle midRect = new();
            midRect.X = _startPosX + _monoRailWidth / 10 * 3;
            midRect.Y = _startPosY + _monoRailHeight / 25 * 4;
            midRect.Width = _monoRailWidth / 120 * 8;
            midRect.Height = _monoRailHeight / 50 * 10;
            g.DrawRectangle(windowPen, midRect);

            //правое окно
            Rectangle rightRect = new();
            rightRect.X = _startPosX + _monoRailWidth / 20 * 17;
            rightRect.Y = _startPosY + _monoRailHeight / 25 * 4;
            rightRect.Width = _monoRailWidth / 120 * 8;
            rightRect.Height = _monoRailHeight / 50 * 10;
            g.DrawRectangle(windowPen, rightRect);

            //2 колеса
            if(EntityMonorail.WheelsNumb >= 2)
            {
                g.FillEllipse(wheelBrush, _startPosX + _monoRailWidth / 10 , _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(tirePen, _startPosX + _monoRailWidth / 10, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.FillEllipse(wheelBrush, _startPosX + _monoRailWidth / 10 * 8, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(tirePen, _startPosX + _monoRailWidth / 10 * 8, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
            }

            //3 колеса
            if (EntityMonorail.WheelsNumb >= 3)
            {
                g.FillEllipse(wheelBrush, _startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(tirePen, _startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
            }

            //4 колеса

            if (EntityMonorail.WheelsNumb >= 4)
            {
                g.FillEllipse(wheelBrush, _startPosX + _monoRailWidth / 10 * 3, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(tirePen, _startPosX + _monoRailWidth / 10 * 3, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
            }
        }
    }

}


