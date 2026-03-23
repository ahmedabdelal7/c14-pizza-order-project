namespace Pitzza_Project
{
    partial class frmPizzaOrder
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppar = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.gbSize.Location = new System.Drawing.Point(58, 171);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(203, 166);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.ForeColor = System.Drawing.Color.Coral;
            this.rbLarge.Location = new System.Drawing.Point(32, 114);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(78, 26);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.ForeColor = System.Drawing.Color.Coral;
            this.rbMedium.Location = new System.Drawing.Point(32, 75);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(101, 26);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.Color.Coral;
            this.rbSmall.Location = new System.Drawing.Point(32, 35);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(77, 26);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.gbCrustType.Location = new System.Drawing.Point(58, 405);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(203, 139);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.ForeColor = System.Drawing.Color.Coral;
            this.rbThinkCrust.Location = new System.Drawing.Point(32, 81);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(126, 26);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.ForeColor = System.Drawing.Color.Coral;
            this.rbThinCrust.Location = new System.Drawing.Point(32, 35);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(116, 26);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppar);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.gbToppings.Location = new System.Drawing.Point(336, 171);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(392, 184);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Topptings";
            // 
            // chkGreenPeppar
            // 
            this.chkGreenPeppar.AutoSize = true;
            this.chkGreenPeppar.ForeColor = System.Drawing.Color.Coral;
            this.chkGreenPeppar.Location = new System.Drawing.Point(217, 127);
            this.chkGreenPeppar.Name = "chkGreenPeppar";
            this.chkGreenPeppar.Size = new System.Drawing.Size(147, 26);
            this.chkGreenPeppar.TabIndex = 5;
            this.chkGreenPeppar.Tag = "5";
            this.chkGreenPeppar.Text = "Green Peppar";
            this.chkGreenPeppar.UseVisualStyleBackColor = true;
            this.chkGreenPeppar.CheckedChanged += new System.EventHandler(this.chkGreenPeppar_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.ForeColor = System.Drawing.Color.Coral;
            this.chkOlives.Location = new System.Drawing.Point(217, 88);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(83, 26);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.ForeColor = System.Drawing.Color.Coral;
            this.chkOnion.Location = new System.Drawing.Point(217, 48);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(84, 26);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.ForeColor = System.Drawing.Color.Coral;
            this.chkTomatos.Location = new System.Drawing.Point(28, 127);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(105, 26);
            this.chkTomatos.TabIndex = 2;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.ForeColor = System.Drawing.Color.Coral;
            this.chkMushrooms.Location = new System.Drawing.Point(28, 88);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(132, 26);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.ForeColor = System.Drawing.Color.Coral;
            this.chkExtraCheese.Location = new System.Drawing.Point(28, 48);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(138, 26);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.gbOrderSummary.Location = new System.Drawing.Point(797, 171);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(405, 393);
            this.gbOrderSummary.TabIndex = 6;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(153, 311);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(70, 50);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(27, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Coral;
            this.lblWhereToEat.Location = new System.Drawing.Point(158, 234);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(56, 22);
            this.lblWhereToEat.TabIndex = 7;
            this.lblWhereToEat.Text = "Eat In";
            this.lblWhereToEat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(27, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Where To Eat:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Coral;
            this.lblCrustType.Location = new System.Drawing.Point(140, 192);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(95, 22);
            this.lblCrustType.TabIndex = 5;
            this.lblCrustType.Text = "Thin Crust";
            this.lblCrustType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(27, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crust Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Coral;
            this.lblToppings.Location = new System.Drawing.Point(44, 121);
            this.lblToppings.MaximumSize = new System.Drawing.Size(360, 45);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(117, 22);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "No Toppings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Coral;
            this.lblSize.Location = new System.Drawing.Point(85, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(80, 22);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Medium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(206)))), ((int)(((byte)(113)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(336, 539);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 49);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order Pitzza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(206)))), ((int)(((byte)(113)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(603, 539);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 49);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(86)))), ((int)(((byte)(30)))));
            this.gbWhereToEat.Location = new System.Drawing.Point(336, 405);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(392, 76);
            this.gbWhereToEat.TabIndex = 9;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "WhereToEat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.ForeColor = System.Drawing.Color.Coral;
            this.rbEatOut.Location = new System.Drawing.Point(217, 35);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(93, 26);
            this.rbEatOut.TabIndex = 1;
            this.rbEatOut.Tag = "0";
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.ForeColor = System.Drawing.Color.Coral;
            this.rbEatIn.Location = new System.Drawing.Point(56, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(77, 26);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 630);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmPizzaOrder";
            this.Text = "frmPizzaOrder";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppar;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
    }
}