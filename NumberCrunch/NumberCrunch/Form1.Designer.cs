namespace NumberCrunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.liveChangeLabel = new System.Windows.Forms.Label();
            this.currentItemLabel = new System.Windows.Forms.Label();
            this.currentItemValueLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.currentTotalCostLabel = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.appleButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.itemSelectionLabel = new System.Windows.Forms.Label();
            this.addToAmountButton = new System.Windows.Forms.Button();
            this.subtractFromAmountButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addTenButton = new System.Windows.Forms.Button();
            this.subtractTenButton = new System.Windows.Forms.Button();
            this.bananaButton = new System.Windows.Forms.Button();
            this.peachButton = new System.Windows.Forms.Button();
            this.strawberryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.itemsOwnedLabel = new System.Windows.Forms.Label();
            this.currentItemPicBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentItemPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // liveChangeLabel
            // 
            this.liveChangeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveChangeLabel.Location = new System.Drawing.Point(13, 13);
            this.liveChangeLabel.Name = "liveChangeLabel";
            this.liveChangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.liveChangeLabel.Size = new System.Drawing.Size(759, 21);
            this.liveChangeLabel.TabIndex = 0;
            // 
            // currentItemLabel
            // 
            this.currentItemLabel.AutoSize = true;
            this.currentItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentItemLabel.Location = new System.Drawing.Point(289, 83);
            this.currentItemLabel.Name = "currentItemLabel";
            this.currentItemLabel.Size = new System.Drawing.Size(81, 32);
            this.currentItemLabel.TabIndex = 1;
            this.currentItemLabel.Text = "Apple";
            // 
            // currentItemValueLabel
            // 
            this.currentItemValueLabel.AutoSize = true;
            this.currentItemValueLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentItemValueLabel.Location = new System.Drawing.Point(258, 118);
            this.currentItemValueLabel.Name = "currentItemValueLabel";
            this.currentItemValueLabel.Size = new System.Drawing.Size(142, 16);
            this.currentItemValueLabel.TabIndex = 2;
            this.currentItemValueLabel.Text = "Current Price: $0.00";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(280, 477);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buyButton_MouseUp);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(427, 477);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sellButton_MouseUp);
            // 
            // currentTotalCostLabel
            // 
            this.currentTotalCostLabel.AutoSize = true;
            this.currentTotalCostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotalCostLabel.Location = new System.Drawing.Point(324, 444);
            this.currentTotalCostLabel.Name = "currentTotalCostLabel";
            this.currentTotalCostLabel.Size = new System.Drawing.Size(126, 30);
            this.currentTotalCostLabel.TabIndex = 5;
            this.currentTotalCostLabel.Text = "Total: $0.00";
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalanceLabel.ForeColor = System.Drawing.Color.Lime;
            this.currentBalanceLabel.Location = new System.Drawing.Point(13, 38);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(250, 38);
            this.currentBalanceLabel.TabIndex = 6;
            this.currentBalanceLabel.Text = "Balance: $50";
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(3, 3);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(75, 23);
            this.appleButton.TabIndex = 7;
            this.appleButton.Text = "Apple";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appleButton_MouseUp);
            // 
            // orangeButton
            // 
            this.orangeButton.Location = new System.Drawing.Point(3, 32);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(75, 23);
            this.orangeButton.TabIndex = 8;
            this.orangeButton.Text = "Orange";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.orangeButton_MouseUp);
            // 
            // itemSelectionLabel
            // 
            this.itemSelectionLabel.AutoSize = true;
            this.itemSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelectionLabel.Location = new System.Drawing.Point(636, 83);
            this.itemSelectionLabel.Name = "itemSelectionLabel";
            this.itemSelectionLabel.Size = new System.Drawing.Size(108, 20);
            this.itemSelectionLabel.TabIndex = 9;
            this.itemSelectionLabel.Text = "Item selection";
            // 
            // addToAmountButton
            // 
            this.addToAmountButton.AutoSize = true;
            this.addToAmountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addToAmountButton.Location = new System.Drawing.Point(203, 450);
            this.addToAmountButton.Name = "addToAmountButton";
            this.addToAmountButton.Size = new System.Drawing.Size(23, 23);
            this.addToAmountButton.TabIndex = 10;
            this.addToAmountButton.Text = "+";
            this.addToAmountButton.UseVisualStyleBackColor = true;
            this.addToAmountButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addToAmountButton_MouseUp);
            // 
            // subtractFromAmountButton
            // 
            this.subtractFromAmountButton.AutoSize = true;
            this.subtractFromAmountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subtractFromAmountButton.Location = new System.Drawing.Point(153, 450);
            this.subtractFromAmountButton.Name = "subtractFromAmountButton";
            this.subtractFromAmountButton.Size = new System.Drawing.Size(20, 23);
            this.subtractFromAmountButton.TabIndex = 11;
            this.subtractFromAmountButton.Text = "-";
            this.subtractFromAmountButton.UseVisualStyleBackColor = true;
            this.subtractFromAmountButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.subtractFromAmountButton_MouseUp);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(141, 427);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(85, 20);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "Quantity: 1";
            // 
            // addTenButton
            // 
            this.addTenButton.AutoSize = true;
            this.addTenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTenButton.Location = new System.Drawing.Point(197, 478);
            this.addTenButton.Name = "addTenButton";
            this.addTenButton.Size = new System.Drawing.Size(35, 23);
            this.addTenButton.TabIndex = 13;
            this.addTenButton.Text = "+10";
            this.addTenButton.UseVisualStyleBackColor = true;
            this.addTenButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addTenButton_MouseUp);
            // 
            // subtractTenButton
            // 
            this.subtractTenButton.AutoSize = true;
            this.subtractTenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subtractTenButton.Location = new System.Drawing.Point(147, 477);
            this.subtractTenButton.Name = "subtractTenButton";
            this.subtractTenButton.Size = new System.Drawing.Size(32, 23);
            this.subtractTenButton.TabIndex = 14;
            this.subtractTenButton.Text = "-10";
            this.subtractTenButton.UseVisualStyleBackColor = true;
            this.subtractTenButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.subtractTenButton_MouseUp);
            // 
            // bananaButton
            // 
            this.bananaButton.Location = new System.Drawing.Point(3, 61);
            this.bananaButton.Name = "bananaButton";
            this.bananaButton.Size = new System.Drawing.Size(75, 23);
            this.bananaButton.TabIndex = 15;
            this.bananaButton.Text = "Banana";
            this.bananaButton.UseVisualStyleBackColor = true;
            this.bananaButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bananaButton_MouseUp);
            // 
            // peachButton
            // 
            this.peachButton.Location = new System.Drawing.Point(3, 90);
            this.peachButton.Name = "peachButton";
            this.peachButton.Size = new System.Drawing.Size(75, 23);
            this.peachButton.TabIndex = 16;
            this.peachButton.Text = "Peach";
            this.peachButton.UseVisualStyleBackColor = true;
            this.peachButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.peachButton_MouseUp);
            // 
            // strawberryButton
            // 
            this.strawberryButton.Location = new System.Drawing.Point(3, 119);
            this.strawberryButton.Name = "strawberryButton";
            this.strawberryButton.Size = new System.Drawing.Size(75, 23);
            this.strawberryButton.TabIndex = 17;
            this.strawberryButton.Text = "Strawberry";
            this.strawberryButton.UseVisualStyleBackColor = true;
            this.strawberryButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.strawberryButton_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.appleButton);
            this.flowLayoutPanel1.Controls.Add(this.orangeButton);
            this.flowLayoutPanel1.Controls.Add(this.bananaButton);
            this.flowLayoutPanel1.Controls.Add(this.peachButton);
            this.flowLayoutPanel1.Controls.Add(this.strawberryButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(649, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(81, 145);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(-4, -1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(793, 515);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseUp);
            // 
            // itemsOwnedLabel
            // 
            this.itemsOwnedLabel.AutoSize = true;
            this.itemsOwnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsOwnedLabel.Location = new System.Drawing.Point(16, 83);
            this.itemsOwnedLabel.Name = "itemsOwnedLabel";
            this.itemsOwnedLabel.Size = new System.Drawing.Size(199, 20);
            this.itemsOwnedLabel.TabIndex = 20;
            this.itemsOwnedLabel.Text = "You have 0 of current item.";
            // 
            // currentItemPicBox
            // 
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.apple2;
            this.currentItemPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentItemPicBox.Location = new System.Drawing.Point(197, 147);
            this.currentItemPicBox.Name = "currentItemPicBox";
            this.currentItemPicBox.Size = new System.Drawing.Size(355, 249);
            this.currentItemPicBox.TabIndex = 22;
            this.currentItemPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.currentItemPicBox);
            this.Controls.Add(this.itemsOwnedLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.subtractTenButton);
            this.Controls.Add(this.addTenButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.subtractFromAmountButton);
            this.Controls.Add(this.addToAmountButton);
            this.Controls.Add(this.itemSelectionLabel);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.currentTotalCostLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.currentItemValueLabel);
            this.Controls.Add(this.currentItemLabel);
            this.Controls.Add(this.liveChangeLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NumberCrunch";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentItemPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label liveChangeLabel;
        private System.Windows.Forms.Label currentItemLabel;
        private System.Windows.Forms.Label currentItemValueLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label currentTotalCostLabel;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Button appleButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Label itemSelectionLabel;
        private System.Windows.Forms.Button addToAmountButton;
        private System.Windows.Forms.Button subtractFromAmountButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addTenButton;
        private System.Windows.Forms.Button subtractTenButton;
        private System.Windows.Forms.Button bananaButton;
        private System.Windows.Forms.Button peachButton;
        private System.Windows.Forms.Button strawberryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label itemsOwnedLabel;
        private System.Windows.Forms.PictureBox currentItemPicBox;
    }
}

