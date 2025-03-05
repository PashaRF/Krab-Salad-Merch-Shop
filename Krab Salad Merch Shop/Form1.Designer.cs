namespace Krab_Salad_Merch_Shop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shirtsLabel = new System.Windows.Forms.Label();
            this.labelStickers = new System.Windows.Forms.Label();
            this.postersLabel = new System.Windows.Forms.Label();
            this.shirtsInput = new System.Windows.Forms.TextBox();
            this.stickersInput = new System.Windows.Forms.TextBox();
            this.postersInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.inputsBackLabel = new System.Windows.Forms.Label();
            this.outputsBackLabel = new System.Windows.Forms.Label();
            this.tenderedBackLabel = new System.Windows.Forms.Label();
            this.changeBackLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.resetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shirtsLabel
            // 
            this.shirtsLabel.AutoSize = true;
            this.shirtsLabel.BackColor = System.Drawing.Color.Transparent;
            this.shirtsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.shirtsLabel.Location = new System.Drawing.Point(12, 143);
            this.shirtsLabel.Name = "shirtsLabel";
            this.shirtsLabel.Size = new System.Drawing.Size(203, 29);
            this.shirtsLabel.TabIndex = 0;
            this.shirtsLabel.Text = "Number of Shirts";
            // 
            // labelStickers
            // 
            this.labelStickers.AutoSize = true;
            this.labelStickers.BackColor = System.Drawing.Color.Transparent;
            this.labelStickers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelStickers.Location = new System.Drawing.Point(16, 181);
            this.labelStickers.Name = "labelStickers";
            this.labelStickers.Size = new System.Drawing.Size(229, 29);
            this.labelStickers.TabIndex = 1;
            this.labelStickers.Text = "Number of Stickers";
            // 
            // postersLabel
            // 
            this.postersLabel.AutoSize = true;
            this.postersLabel.BackColor = System.Drawing.Color.Transparent;
            this.postersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.postersLabel.Location = new System.Drawing.Point(16, 219);
            this.postersLabel.Name = "postersLabel";
            this.postersLabel.Size = new System.Drawing.Size(224, 29);
            this.postersLabel.TabIndex = 2;
            this.postersLabel.Text = "Number of Posters";
            // 
            // shirtsInput
            // 
            this.shirtsInput.Location = new System.Drawing.Point(259, 147);
            this.shirtsInput.Name = "shirtsInput";
            this.shirtsInput.Size = new System.Drawing.Size(87, 20);
            this.shirtsInput.TabIndex = 3;
            // 
            // stickersInput
            // 
            this.stickersInput.Location = new System.Drawing.Point(259, 184);
            this.stickersInput.Name = "stickersInput";
            this.stickersInput.Size = new System.Drawing.Size(87, 20);
            this.stickersInput.TabIndex = 4;
            // 
            // postersInput
            // 
            this.postersInput.Location = new System.Drawing.Point(259, 219);
            this.postersInput.Name = "postersInput";
            this.postersInput.Size = new System.Drawing.Size(87, 20);
            this.postersInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.calculateButton.Location = new System.Drawing.Point(21, 251);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(325, 29);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.subtotalLabel.Location = new System.Drawing.Point(16, 327);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(106, 29);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.taxLabel.Location = new System.Drawing.Point(16, 356);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(54, 29);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.totalLabel.Location = new System.Drawing.Point(16, 385);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(69, 29);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.subtotalOutput.Location = new System.Drawing.Point(254, 327);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 29);
            this.subtotalOutput.TabIndex = 10;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.taxOutput.Location = new System.Drawing.Point(254, 356);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 29);
            this.taxOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.totalOutput.Location = new System.Drawing.Point(254, 385);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 29);
            this.totalOutput.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tenderedLabel.Location = new System.Drawing.Point(16, 438);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(120, 29);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(259, 445);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(87, 20);
            this.tenderedInput.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.changeButton.Location = new System.Drawing.Point(16, 473);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(325, 29);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.changeLabel.Location = new System.Drawing.Point(16, 531);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(101, 29);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.changeOutput.Location = new System.Drawing.Point(254, 541);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 29);
            this.changeOutput.TabIndex = 17;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.receiptButton.Location = new System.Drawing.Point(17, 565);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(325, 29);
            this.receiptButton.TabIndex = 18;
            this.receiptButton.Text = "Print Reciept";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(386, 143);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(395, 29);
            this.receiptLabel.TabIndex = 19;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // inputsBackLabel
            // 
            this.inputsBackLabel.Location = new System.Drawing.Point(8, 140);
            this.inputsBackLabel.Name = "inputsBackLabel";
            this.inputsBackLabel.Size = new System.Drawing.Size(347, 150);
            this.inputsBackLabel.TabIndex = 20;
            // 
            // outputsBackLabel
            // 
            this.outputsBackLabel.Location = new System.Drawing.Point(8, 320);
            this.outputsBackLabel.Name = "outputsBackLabel";
            this.outputsBackLabel.Size = new System.Drawing.Size(347, 100);
            this.outputsBackLabel.TabIndex = 21;
            // 
            // tenderedBackLabel
            // 
            this.tenderedBackLabel.Location = new System.Drawing.Point(8, 432);
            this.tenderedBackLabel.Name = "tenderedBackLabel";
            this.tenderedBackLabel.Size = new System.Drawing.Size(347, 80);
            this.tenderedBackLabel.TabIndex = 22;
            // 
            // changeBackLabel
            // 
            this.changeBackLabel.Location = new System.Drawing.Point(7, 527);
            this.changeBackLabel.Name = "changeBackLabel";
            this.changeBackLabel.Size = new System.Drawing.Size(347, 71);
            this.changeBackLabel.TabIndex = 23;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.titleLabel.Location = new System.Drawing.Point(8, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 96);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "Krab Salad \r\nMerch Store";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.resetButton.Location = new System.Drawing.Point(418, 559);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(325, 29);
            this.resetButton.TabIndex = 25;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resetLabel
            // 
            this.resetLabel.Location = new System.Drawing.Point(406, 548);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(347, 48);
            this.resetLabel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 626);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.shirtsLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.postersInput);
            this.Controls.Add(this.stickersInput);
            this.Controls.Add(this.shirtsInput);
            this.Controls.Add(this.postersLabel);
            this.Controls.Add(this.labelStickers);
            this.Controls.Add(this.inputsBackLabel);
            this.Controls.Add(this.outputsBackLabel);
            this.Controls.Add(this.tenderedBackLabel);
            this.Controls.Add(this.changeBackLabel);
            this.Controls.Add(this.resetLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Krab Salad Merch Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shirtsLabel;
        private System.Windows.Forms.Label labelStickers;
        private System.Windows.Forms.Label postersLabel;
        private System.Windows.Forms.TextBox shirtsInput;
        private System.Windows.Forms.TextBox stickersInput;
        private System.Windows.Forms.TextBox postersInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label inputsBackLabel;
        private System.Windows.Forms.Label outputsBackLabel;
        private System.Windows.Forms.Label tenderedBackLabel;
        private System.Windows.Forms.Label changeBackLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label resetLabel;
    }
}

