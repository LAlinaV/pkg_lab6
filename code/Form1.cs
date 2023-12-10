using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace pkglab62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picturePlane = new Matrix(4, 4);
            for (int i = 0; i < 3; i++)
            {
                picturePlane[i, i] = 1;
            }
            scale = 30;
            letter = new List<KeyValuePair<Coordinates, Coordinates>>();
            axis = new List<KeyValuePair<Coordinates, Coordinates>>();


            InitializeLetter();
            InitializeAxis();
            initializeContainers();
            prevDist = 1;
            prevScale = 1;
            affineTransform = new Matrix(4, 4);
            affineTransform[0, 0] = 1;
            affineTransform[1, 1] = 1;
            affineTransform[2, 2] = 1;
            affineTransform[3, 3] = 1;
            picturePlane = Graphics3D.rotateOx(0.67)
                            * Graphics3D.rotateOy(0.47)
                            * Graphics3D.rotateOz(0.34);
            projection = projectionVariants[3];

            printAffineMatrix();
        }
        int[] prevObjectAngles;
        int[] prevGlobalAngles;
        double[] prevObjectCoords;
        double prevScale;
        double prevDist;
        TextBox[,] tbMatrix;
        List<NumericUpDown> tbRotationOCS;
        List<NumericUpDown> tbRotationGCS;
        List<NumericUpDown> numUDTranslate;
        Matrix affineTransform;
        Matrix projection;
        Matrix[] projectionVariants;
        float scale;
        PointF center;

        void initializeContainers()
        {
            projectionVariants = new Matrix[4];
            for (int i = 0; i < 3; i++)
            {
                projectionVariants[i] = new Matrix(4, 4);
                projectionVariants[i][0, 0] = 1;
                projectionVariants[i][1, 1] = 1;
                projectionVariants[i][2, 2] = 1;
                projectionVariants[i][3, 3] = 1;
                projectionVariants[i][i, i] = 0;
            }
            projectionVariants[3] = new Matrix(4, 4);
            projectionVariants[3][0, 0] = 1;
            projectionVariants[3][1, 1] = 1;
            projectionVariants[3][2, 2] = 1;
            projectionVariants[3][3, 3] = 1;

            tbMatrix = new TextBox[4, 4] {
                {tb00, tb01, tb02, tb03},
                {tb10, tb11, tb12, tb13},
                {tb20, tb21, tb22, tb23},
                {tb30, tb31, tb32, tb33},
            };

            tbRotationOCS = new List<NumericUpDown>
            {
                OOx,
                OOy,
                OOz
            };

            tbRotationGCS = new List<NumericUpDown>
            {
                GOx,
                GOy,
                GOz
            };

            numUDTranslate = new List<NumericUpDown>
            {
                numUDTranslateOx,
                numUDTranslateOy,
                numUDTranslateOz
            };

            prevObjectAngles = new int[3];
            prevGlobalAngles = new int[3];
            prevObjectCoords = new double[3];
        }

        public void printAffineMatrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tbMatrix[i, j].Text = string.Format("{0:N4}", affineTransform[i, j]);
                }
            }
        }
        public void plot(Graphics gr)
        {

            center = new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2);
            Pen[] pen = new Pen[3] { new Pen(Color.DarkViolet, 3), new Pen(Color.BlueViolet, 3), new Pen(Color.MediumVioletRed, 3) };
            string[] str = new string[3] { "x", "y", "z" };
            Font font = new Font(this.Font.FontFamily, 18,FontStyle.Italic);
            
            PointF a, b;
            
            for (int i = 0; i < axis.Count; i++)
            {
                a = toWorkspaceCoords(To2D(axis[i].Key));
                b = toWorkspaceCoords(To2D(axis[i].Value));

                gr.DrawLine(pen[i], a, b);
                gr.DrawString(str[i], font, pen[i].Brush, a);
            }
            for (int j = 0; j < 11; j++)
            {
                gr.DrawRectangle(pen[0], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(j, 0, 0)))), new Size(3, 3)));
                gr.DrawRectangle(pen[0], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(-j, 0, 0)))), new Size(3, 3)));
                gr.DrawRectangle(pen[1], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(0, j, 0)))), new Size(3, 3)));
                gr.DrawRectangle(pen[1], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(0, -j, 0)))), new Size(3, 3)));
                gr.DrawRectangle(pen[2], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(0, 0, j)))), new Size(3, 3)));
                gr.DrawRectangle(pen[2], new Rectangle(PointF2Point(toWorkspaceCoords(To2D(new Coordinates(0, 0, -j)))), new Size(3, 3)));
            }
            
        }
        private Point PointF2Point(PointF a)
        {
            return new Point((int)Math.Round(a.X), (int)Math.Round(a.Y));
        }
        List<KeyValuePair<Coordinates, Coordinates>> letter;
        List<KeyValuePair<Coordinates, Coordinates>> axis;
        public void InitializeLetter()
        {
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(0, 0, 0), new Coordinates(1, 0, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(1, 0, 0), new Coordinates(2.5, 4, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(1, 0, 1), new Coordinates(2.5, 4, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(4, 0, 0), new Coordinates(2.5, 4, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(4, 0, 0), new Coordinates(5, 0, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(5, 0, 0), new Coordinates(3, 5, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(3, 5, 0), new Coordinates(2, 5, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(2, 5, 0), new Coordinates(0, 0, 0)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(4, 0, 1), new Coordinates(2.5, 4, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(0, 0, 1), new Coordinates(1, 0, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(4, 0, 1), new Coordinates(5, 0, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(5, 0, 1), new Coordinates(3, 5, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(3, 5, 1), new Coordinates(2, 5, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(2, 5, 1), new Coordinates(0, 0, 1)));

            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(0, 0, 0), new Coordinates(0, 0, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(1, 0, 0), new Coordinates(1, 0, 1)));

            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(4, 0, 0), new Coordinates(4, 0, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(5, 0, 0), new Coordinates(5, 0, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(3, 5, 0), new Coordinates(3, 5, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(2, 5, 0), new Coordinates(2, 5, 1)));
            letter.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(2.5, 4, 0), new Coordinates(2.5, 4, 1)));

        }

        public void InitializeAxis()
        {
            axis.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(10, 0, 0), new Coordinates(-10, 0, 0)));
            axis.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(0, 10, 0), new Coordinates(0, -10, 0)));
            axis.Add(new KeyValuePair<Coordinates, Coordinates>(new Coordinates(0, 0, 10), new Coordinates(0, 0, -10)));
        }

        public PointF toWorkspaceCoords(PointF p)
        {
            PointF m = new PointF(p.X * scale + center.X, -p.Y * scale + center.Y);
            return m;
        }
        public PointF To2D(Coordinates c)
        {
            var point = c.AffineTransform(picturePlane).coord;
            PointF p = new PointF((float)point[0, 0], (float)point[0, 1]);
            return p;
        }

        Matrix picturePlane;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            center = new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2);
            var gr = e.Graphics;
            gr.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF a, b;
            Pen pen = new Pen(Color.Blue, 3);
            for (int i = 0; i < letter.Count; i++)
            {
                a = toWorkspaceCoords(To2D(letter[i].Key.AffineTransform(affineTransform * projection)));
                b = toWorkspaceCoords(To2D(letter[i].Value.AffineTransform(affineTransform * projection)));
                gr.DrawLine(pen, a, b);
            }
            plot(gr);
        }
        private void picturePlaneRotation()
        {
            picturePlane = picturePlane * Graphics3D.rotateOx(Graphics3D.toRad((int)(tbRotationGCS[0].Value - prevGlobalAngles[0])))
            * Graphics3D.rotateOy(Graphics3D.toRad((int)(tbRotationGCS[1].Value - prevGlobalAngles[1])))
                    * Graphics3D.rotateOz(Graphics3D.toRad((int)(tbRotationGCS[2].Value - prevGlobalAngles[2])));
            for (int i = 0; i < 3; i++)
            {
                prevGlobalAngles[i] = (int)tbRotationGCS[i].Value;
            }
        }


        private void scaling(NumericUpDown numericUpDown)
        {
            var mat = Graphics3D.Scaling((double)numericUpDown.Value);
            if (numericUpDown == numUDScale)
            {
                affineTransform = affineTransform * Graphics3D.Scaling(1 / prevScale) * mat;
                prevScale = (double)numericUpDown.Value;
            }
            else
            {
                picturePlane = picturePlane * Graphics3D.Scaling(1 / prevDist) * mat;
                prevDist = (double)numericUpDown.Value;
            }

            
        }
        private void affineTranslate()
        {
            affineTransform = affineTransform * Graphics3D.Translate(-prevObjectCoords[0], -prevObjectCoords[1], -prevObjectCoords[2]);

            for (int i = 0; i < 3; i++)
            {
               prevObjectCoords[i] = (double)numUDTranslate[i].Value;
            }
            affineTransform = affineTransform * Graphics3D.Translate(prevObjectCoords[0], prevObjectCoords[1], prevObjectCoords[2]);
        }
        private void affineRotation()
        {
            affineTransform = affineTransform * Graphics3D.rotateOx(Graphics3D.toRad((int)(tbRotationOCS[0].Value - prevObjectAngles[0])))
            * Graphics3D.rotateOy(Graphics3D.toRad((int)(tbRotationOCS[1].Value - prevObjectAngles[1])))
                * Graphics3D.rotateOz(Graphics3D.toRad((int)(tbRotationOCS[2].Value - prevObjectAngles[2])));
            for (int i = 0; i < 3; i++)
            {
                prevObjectAngles[i] = (int)tbRotationOCS[i].Value;
            }
        }


        private void tbObjectAngles_ValueChanged(object sender, EventArgs e)
        {
            affineRotation();
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void tbGlobalAngles_ValueChanged(object sender, EventArgs e)
        {
            picturePlaneRotation();
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void bTranslate_Click(object sender, EventArgs e)
        {
            affineTranslate();
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void bScale_Click(object sender, EventArgs e)
        {
            scaling(numUDScale);
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void bDist_Click(object sender, EventArgs e)
        {
            scaling(numUDDist);
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void bResetAffine_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                tbRotationOCS[i].Value = 0;
                prevObjectAngles[i] = 0;
                prevObjectCoords[i] = 0;
            }
            prevScale = 1;
            affineTransform = new Matrix(4, 4);
            for (int i = 0; i < 4; i++)
            {
                affineTransform[i, i] = 1;
            }
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void bResetPicture_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                tbRotationGCS[i].Value = 0;
                prevGlobalAngles[i] = 0;

            }
            prevDist = 1;
            picturePlane = new Matrix(4, 4);
            for (int i = 0; i < 4; i++)
            {
                picturePlane[i, i] = 1;
            }
            pictureBox1.Invalidate();
            printAffineMatrix();
        }

        private void rbp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp.Checked)
            {
                projection = projectionVariants[0];
            }
            pictureBox1.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(Width - 370, Height - 70);
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Invalidate();
        }

        Point prevPosition;
        Point curPosition;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPosition = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                curPosition = e.Location;
                double delta_x = curPosition.X - prevPosition.X;
                double delta_y = curPosition.Y - prevPosition.Y;
                int value;
                value = (int)(tbRotationGCS[1].Value + (int)Math.Round(delta_x / center.X * 180));
                if (value < -180)
                {
                    value += 360;
                }
                else if (value > 180)
                {
                    value -= 360;
                }
                tbRotationGCS[1].Value = value;
                value = (int)(tbRotationGCS[0].Value + (int)Math.Round(delta_y / center.Y * 180));
                if (value < -180)
                {
                    value += 360;
                }
                else if (value > 180)
                {
                    value -= 360;
                }
                tbRotationGCS[0].Value = value;
                prevPosition = e.Location;

            }
        }

        private void rbf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbf.Checked)
            {
                projection = projectionVariants[1];
            }
            pictureBox1.Invalidate();
        }

        private void rbh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbh.Checked)
            {
                projection = projectionVariants[2];
            }
            pictureBox1.Invalidate();
        }

        private void rbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn.Checked)
            {
                projection = projectionVariants[3];
            }
            pictureBox1.Invalidate();
        }

        
    }
}
