//Created by: Tasia Reynen
//Novemember 26th, 2015
//Draw Star at differnt locations and different sizes of the star
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawStar(20,20,100);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(xInput.Text);       // holds the x value inputed by user
            float y = Convert.ToSingle(yInput.Text);       // holds the y value inputed by user
            float size = Convert.ToSingle(sizeInput.Text);      // holds the size value inputed by user

            DrawStar(x, y, size);
        }
        /// <summary>
        /// Draw Star program- calculates a star at a different position and chnages the size
        /// </summary>
        /// <param name="x">x positions of the star</param>
        /// <param name="y">y positions of the star</param>
        /// <param name="size">size of star</param>
        private void DrawStar(float x, float y, float size)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen blackPen = new Pen(Color.White);

            // Moving the star & changing size
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(blackPen, (0 + x) *(size / 205), (76 + y)*(size / 197), (78 + x) * (size / 205), (76 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (78 + x) * (size / 205), (76 + y) * (size / 197), (103 + x) * (size / 205), (0 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (103 + x)* (size / 205), (0 + y) * (size / 197), (127 + x) * (size / 205), (76 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (127 + x) * (size / 205), (76 + y) * (size / 197), (205 + x) * (size / 205), (76 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (205 + x) * (size / 205), (76 + y) * (size / 197), (142 + x) * (size / 205), (123 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (142 + x) * (size / 205), (123 + y) * (size / 197), (165 + x) * (size / 205), (197 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (165 + x) * (size / 205), (197 + y) * (size / 197), (103 + x) * (size / 205), (151 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (103 + x) * (size / 205), (151 + y) * (size / 197), (40 + x) * (size / 205), (197 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (40 + x) * (size / 205), (197 + y) * (size / 197), (64 + x) * (size / 205), (123 + y) * (size / 197));
            formGraphics.DrawLine(blackPen, (64 + x) * (size / 205), (123 + y) * (size / 197), (0 + x) * (size / 205), (76 + y) * (size / 197));
        }
    }

   
}