namespace CalculadorPasajeMetro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDistance = new Label();
            txtDistance = new TextBox();
            lblDays = new Label();
            txtDays = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(216, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(369, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Calculador de Precio de Pasaje en Metro";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistance.ForeColor = Color.FromArgb(0, 64, 0);
            lblDistance.Location = new Point(112, 102);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(257, 20);
            lblDistance.TabIndex = 1;
            lblDistance.Text = "Ingrese la distancia a recorrer (km):";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(393, 103);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(70, 23);
            txtDistance.TabIndex = 2;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDays.ForeColor = Color.FromArgb(0, 64, 0);
            lblDays.Location = new Point(112, 146);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(275, 20);
            lblDays.TabIndex = 3;
            lblDays.Text = "Ingrese el número de días de estancia:";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(393, 147);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(70, 23);
            txtDays.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.FromArgb(0, 192, 0);
            btnCalculate.Location = new Point(155, 227);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(70, 26);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(326, 233);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(20, 17);
            lblResult.TabIndex = 6;
            lblResult.Text = "\"\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(667, 382);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 7;
            label1.Text = "Fanny Luna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(667, 399);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = " ID: A00149991";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtDays);
            Controls.Add(lblDays);
            Controls.Add(txtDistance);
            Controls.Add(lblDistance);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblDays;
        private TextBox txtDays;
        private Button btnCalculate;
        private Label lblResult;
        private Label label1;
        private Label label2;
    }
}
