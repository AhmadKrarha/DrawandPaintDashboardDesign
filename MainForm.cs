using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawandPaintDashboardDesign
{
    public class MainForm : Form
    {
        private Panel panelCanvas;
        private Button btnDrawRectangle;
        private Button btnDrawCircle;
        private Button btnChooseColor;
        private NumericUpDown numericUpDownSize;
        private ColorDialog colorDialog1;
        private Color currentColor = Color.Black;
        private int shapeSize = 50;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panelCanvas = new Panel();
            btnDrawRectangle = new Button();
            btnDrawCircle = new Button();
            btnChooseColor = new Button();
            numericUpDownSize = new NumericUpDown();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).BeginInit();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = Color.White;
            panelCanvas.BorderStyle = BorderStyle.FixedSingle;
            panelCanvas.Location = new Point(20, 80);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(400, 300);
            panelCanvas.TabIndex = 0;
            panelCanvas.Paint += panelCanvas_Paint;
            // 
            // btnDrawRectangle
            // 
            btnDrawRectangle.Location = new Point(20, 20);
            btnDrawRectangle.Name = "btnDrawRectangle";
            btnDrawRectangle.Size = new Size(75, 23);
            btnDrawRectangle.TabIndex = 1;
            btnDrawRectangle.Text = "Draw Rectangle";
            btnDrawRectangle.Click += btnDrawRectangle_Click;
            // 
            // btnDrawCircle
            // 
            btnDrawCircle.Location = new Point(140, 20);
            btnDrawCircle.Name = "btnDrawCircle";
            btnDrawCircle.Size = new Size(75, 23);
            btnDrawCircle.TabIndex = 2;
            btnDrawCircle.Text = "Draw Circle";
            btnDrawCircle.Click += btnDrawCircle_Click;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(260, 20);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(75, 23);
            btnChooseColor.TabIndex = 3;
            btnChooseColor.Text = "Choose Color";
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // numericUpDownSize
            // 
            numericUpDownSize.Location = new Point(380, 20);
            numericUpDownSize.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSize.Name = "numericUpDownSize";
            numericUpDownSize.Size = new Size(120, 27);
            numericUpDownSize.TabIndex = 4;
            numericUpDownSize.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownSize.ValueChanged += numericUpDownSize_ValueChanged;
            // 
            // MainForm
            // 
            ClientSize = new Size(450, 400);
            Controls.Add(panelCanvas);
            Controls.Add(btnDrawRectangle);
            Controls.Add(btnDrawCircle);
            Controls.Add(btnChooseColor);
            Controls.Add(numericUpDownSize);
            Name = "MainForm";
            Text = "Draw and Paint Dashboard";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).EndInit();
            ResumeLayout(false);
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();
            g.FillRectangle(new SolidBrush(currentColor), 10, 10, shapeSize, shapeSize);
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = panelCanvas.CreateGraphics();
            g.FillEllipse(new SolidBrush(currentColor), 70, 10, shapeSize, shapeSize);
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            shapeSize = (int)numericUpDownSize.Value;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}