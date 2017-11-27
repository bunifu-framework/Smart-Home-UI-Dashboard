using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plotdata()
        {
            var canvas1 = new Bunifu.DataViz.Canvas();
            var canvas2 = new Bunifu.DataViz.Canvas();

            var datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);

            datapoint1.addLabely("label1", "45");
            datapoint1.addLabely("label2", "60");
            datapoint1.addLabely("label3", "50");
            datapoint1.addLabely("label4", "80");
            datapoint1.addLabely("label5", "70");
            datapoint1.addLabely("label6", "90");
            datapoint1.addLabely("label7", "100");
            datapoint1.addLabely("label8", "95");
            datapoint1.addLabely("label9", "60");
            datapoint1.addLabely("label10", "45");

            canvas1.addData(datapoint1);


            var datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);

            datapoint2.addLabely("label1", "55");
            datapoint2.addLabely("label2", "70");
            datapoint2.addLabely("label3", "60");
            datapoint2.addLabely("label4", "90");
            datapoint2.addLabely("label5", "80");
            datapoint2.addLabely("label6", "100");
            datapoint2.addLabely("label7", "110");
            datapoint2.addLabely("label8", "105");
            datapoint2.addLabely("label9", "70");
            datapoint2.addLabely("label10", "55");

            canvas1.addData(datapoint2);
            bunifuDataViz1.Render(canvas1);


            
            var datapoint3 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);

            datapoint3.addLabely("", "55");
            datapoint3.addLabely("", "70");
            datapoint3.addLabely("", "60");
            datapoint3.addLabely("", "90");
            datapoint3.addLabely("", "80");
            datapoint3.addLabely("", "100");


            canvas2.addData(datapoint3);
            bunifuDataViz2.Render(canvas2);

        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding colorset to the dataviz area chart, line and piechart using colorset.add() method
            //the pie chart on datav//timer 
            bunifuDataViz1.colorSet.Add(Color.FromArgb(76, 131, 115));
            bunifuDataViz1.colorSet.Add(Color.FromArgb(116, 231, 148));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(85, 159, 127));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(70, 118, 126));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(123, 197, 222));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(92, 175, 188));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(156, 222, 202));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(113, 228, 146));
        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plotdata();
            timer1.Stop();
        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataViz2_Load(object sender, EventArgs e)
        {

        }
    }
}
