using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Krab_Salad_Merch_Shop
{


    public partial class Form1 : Form
    {

        double shirtcost = 24.99;
        double postercost = 2.99;
        double stickercost = 1.49;

        double total;
        double change;
        double tendered;
        double tax;
        double subtotal;

        double numshirts;
        double numposters;
        double numstickers;

        double taxRate = 0.13;

        bool positiveNum = true;
        bool sufficientTender = true;

        public Form1()
        {
            InitializeComponent();

            changeButton.Enabled = false;
            receiptButton.Enabled = false;

            this.Size = new Size(380, 650);

            // Title formatting
            titleLabel.BackColor = Color.FromArgb(180, 255, 100, 100);
            resetLabel.BackColor = Color.FromArgb(180, 255, 100, 100);

            // initial inputs formatting
            label1.BackColor = Color.FromArgb(60, 255, 255, 255);
            labelStickers.BackColor = Color.FromArgb(160, 255, 100, 100);
            shirtsLabel.BackColor = Color.FromArgb(160, 255, 100, 100);
            postersLabel.BackColor = Color.FromArgb(160, 255, 100, 100);

            shirtsLabel.Parent = label1;
            labelStickers.Parent = label1;
            postersLabel.Parent = label1;

            shirtsLabel.Location = new Point(10, 5);
            labelStickers.Location = new Point(10, 35);
            postersLabel.Location = new Point(10, 65);

            // calculations formatting
            label2.BackColor = Color.FromArgb(60, 255, 255, 255);
            subtotalLabel.BackColor = Color.FromArgb(160, 255, 100, 100);
            taxLabel.BackColor = Color.FromArgb(160, 255, 100, 100);
            totalLabel.BackColor = Color.FromArgb(160, 255, 100, 100);

            subtotalLabel.Parent = label2;
            taxLabel.Parent = label2;
            totalLabel.Parent = label2;

            subtotalLabel.Location = new Point(10, 5);
            taxLabel.Location = new Point(10, 35);
            totalLabel.Location = new Point(10, 65);

            // Outputs formatting
            subtotalOutput.Parent = label2;
            taxOutput.Parent = label2;
            totalOutput.Parent = label2;
            changeOutput.Parent = label4;

            subtotalOutput.BackColor = Color.FromArgb(200, 255, 255, 255);
            taxOutput.BackColor = Color.FromArgb(200, 255, 255, 255);
            totalOutput.BackColor = Color.FromArgb(200, 255, 255, 255);
            changeOutput.BackColor = Color.FromArgb(200, 255, 255, 255);

            subtotalOutput.Location = new Point(246, 5);
            taxOutput.Location = new Point(246, 35);
            totalOutput.Location = new Point(246, 65);
            changeOutput.Location = new Point(246, 5);


            //tendered formatting
            label3.BackColor = Color.FromArgb(60, 255, 255, 255);
            tenderedLabel.BackColor = Color.FromArgb(160, 255, 100, 100);

            tenderedLabel.Parent = label3;

            tenderedLabel.Location = new Point(10, 5);

            //change formatting
            label4.BackColor = Color.FromArgb(60, 255, 255, 255);
            changeLabel.BackColor = Color.FromArgb(160, 255, 100, 100);

            changeLabel.Parent = label4;

            changeLabel.Location = new Point(10, 5);

            //receipt disappear
            receiptLabel.Size = new Size(395, 0);
            calculateButton.Enabled = true;

            postersInput.Text = "0";
            shirtsInput.Text = "0";
            stickersInput.Text = "0";
            tenderedInput.Text = "0";
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // TOTALS DISPLAYED
                numshirts = Convert.ToDouble($"{shirtsInput.Text}");
                numposters = Convert.ToDouble($"{postersInput.Text}");
                numstickers = Convert.ToDouble($"{stickersInput.Text}");

                if (numshirts < 0 | numstickers < 0 | numposters < 0)
                {
                    positiveNum = false;
                }

                if (positiveNum == false)
                {
                    totalOutput.Text = "ERROR";
                    subtotalOutput.Text = "ERROR";
                    taxOutput.Text = "ERROR";

                    positiveNum = true;
                }
                else
                {
                    subtotal = numshirts * shirtcost + numposters * postercost + numstickers * stickercost;
                    subtotalOutput.Text = $"{subtotal.ToString("C")}";

                    tax = taxRate * subtotal;
                    taxOutput.Text = $"{tax.ToString("C")}";

                    total = tax + subtotal;
                    totalOutput.Text = $"{total.ToString("C")}";

                    changeButton.Enabled = true;
                    calculateButton.Enabled = false;
                }
            }
            catch
            {
                totalOutput.Text = "ERROR";
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // CHANGE SHOWN
                tendered = Convert.ToDouble($"{tenderedInput.Text}");
                change = tendered - total;

                if (change < 0)
                {
                    sufficientTender = false;
                }
                if (sufficientTender == false)
                {
                    changeOutput.Text = "ERROR";
                    sufficientTender = true;
                }
                else
                {
                    changeOutput.Text = $"{change.ToString("C")}";
                    changeButton.Enabled = false;
                    receiptButton.Enabled = true;
                }
            }
            catch
            {
                changeOutput.Text = "ERROR";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // RECEIPT PRINT

                resetButton.Size = new Size(0, 0);
                resetLabel.Size = new Size(0, 0);
                this.Size = new Size(830, 650);

                receiptLabel.Size = new Size(395, 22);
                receiptLabel.Text = "----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 44);
                receiptLabel.Text = "\n---------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 66);
                receiptLabel.Text = $"Change------------------------{change.ToString("C")}" +
                    $"\n\n ---------Have a nice day!!!---------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 88);
                receiptLabel.Text = $"Tendered----------------------{tendered.ToString("C")}\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 110);
                receiptLabel.Text = $"\nTendered----------------------{tendered.ToString("C")}\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 132);
                receiptLabel.Text = $"Total-------------------------{total.ToString("C")}\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 154);
                receiptLabel.Text = $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 176);
                receiptLabel.Text = $"Subtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 198);
                receiptLabel.Text = $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 220);
                receiptLabel.Text = $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 242);
                receiptLabel.Text = $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 264);
                receiptLabel.Text = $"Shirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 286);
                receiptLabel.Text = $"\nShirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 308);
                receiptLabel.Text = $"-----------March  3rd  2025-----------\n" +
                    $"\nShirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 330);
                receiptLabel.Text = $"----------Order  Number 0076----------\n" +
                    $"-----------March  3rd  2025-----------\n" +
                    $"\nShirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 352);
                receiptLabel.Text = $"\n----------Order  Number 0076----------\n" +
                    $"-----------March  3rd  2025-----------\n" +
                    $"\nShirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                Thread.Sleep(200);
                receiptLabel.Size = new Size(395, 374);
                receiptLabel.Text = $"------------Krab  Salad INC-----------\n" +
                    $"\n----------Order  Number 0076----------\n" +
                    $"-----------March  3rd  2025-----------\n" +
                    $"\nShirts------------------x{numshirts}---@{shirtcost.ToString("C")}\n" +
                    $"Stickers----------------x{numstickers}---@{stickercost.ToString("C")}\n" +
                    $"Posters-----------------x{numposters}---@{postercost.ToString("C")}\n" +
                    $"\nSubtotal----------------------{subtotal.ToString("C")}\n" +
                    $"Tax---------------------------{tax.ToString("C")}\n" +
                    $"Total-------------------------{total.ToString("C")}" +
                    $"\n\nTendered----------------------{tendered.ToString("C")}" +
                    $"\nChange------------------------{change.ToString("C")} " +
                    $"\n\n----------Have a nice day!!!----------";
                receiptLabel.Refresh();

                // show new order button 
                resetButton.Size = new Size(325, 29);
                resetLabel.Size = new Size(347, 48);

                receiptButton.Enabled = false;
            }

            catch
            {
                changeOutput.Text = "ERROR";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // accidentally doubled clicked --> forget how to delete this without messing up code (it doesn't matter whatever)
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            //MASS RESET 

            receiptLabel.Size = new Size(395, 0);

            double total = 0;
            double change = 0;
            double tendered = 0;
            double tax = 0;
            double subtotal = 0;

            double numshirts = 0;
            double numposters = 0;
            double numstickers = 0;

            totalOutput.Text = $"";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            changeOutput.Text = $"";

            this.Size = new Size(380, 650);
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            calculateButton.Enabled = true;

            postersInput.Text = "0";
            shirtsInput.Text = "0";
            stickersInput.Text = "0";
            tenderedInput.Text = "0";

            sufficientTender = true;
            positiveNum = true;
        }
    }
}