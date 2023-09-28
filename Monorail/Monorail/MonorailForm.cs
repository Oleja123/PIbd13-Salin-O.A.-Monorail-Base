using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monorail.DrawningObjects;
using Monorail.MovementStrategy;

namespace Monorail
{
    public partial class MonorailForm : Form
    {

        private DrawningMonorail? _drawningMonorail;

        private AbstractStrategy? _abstractStrategy;
        public MonorailForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            if (_drawningMonorail == null)
                return;

            Bitmap bmp = new(pictureBoxMonorail.Width, pictureBoxMonorail.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningMonorail.DrawTransport(gr);
            pictureBoxMonorail.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningMonorail = new DrawningMonorail(random.Next(100, 300), random.Next(1000, 3000),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                pictureBoxMonorail.Width, pictureBoxMonorail.Height);
            Draw();
        }

        private void ButtonMoveClick(object sender, EventArgs e)
        {
            if (_drawningMonorail == null)
                return;

            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _drawningMonorail.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    _drawningMonorail.MoveTransport(DirectionType.Down);
                    break;
                case "buttonRight":
                    _drawningMonorail.MoveTransport(DirectionType.Right);
                    break;
                case "buttonLeft":
                    _drawningMonorail.MoveTransport(DirectionType.Left);
                    break;
            }
            Draw();
        }

        private void buttonCreateAdvanced_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningMonorail = new DrawningAdvancedMonorail(random.Next(100, 300), random.Next(1000, 3000),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                pictureBoxMonorail.Width, pictureBoxMonorail.Height, random.Next(3, 5),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
            Draw();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (_drawningMonorail == null)
                return;
            if (comboBoxStrategy.Enabled)
            {
                _abstractStrategy = comboBoxStrategy.SelectedIndex
                switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToEdge(),
                    _ => null,
                } ;
                if (_abstractStrategy == null)
                {
                    return;
                }
                _abstractStrategy.SetData(new
                DrawningObjectMonorail(_drawningMonorail), pictureBoxMonorail.Width,
                pictureBoxMonorail.Height);
                comboBoxStrategy.Enabled = false;
            }
            if (_abstractStrategy == null)
            {
                return;
            }
            _abstractStrategy.MakeStep();
            Draw();
            if (_abstractStrategy.GetStatus() == Status.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _abstractStrategy = null;
            }
        }
    }
}
