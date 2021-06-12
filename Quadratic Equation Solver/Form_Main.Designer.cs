namespace QuadraticEquationSolver
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox_coefficients = new System.Windows.Forms.GroupBox();
            this.button_initialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_c = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.label_equation = new System.Windows.Forms.Label();
            this.groupBox_discriminant = new System.Windows.Forms.GroupBox();
            this.textBox_mini_delta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_delta = new System.Windows.Forms.TextBox();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.groupBox_roots = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.groupBox_equation = new System.Windows.Forms.GroupBox();
            this.groupBox_coefficients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            this.groupBox_discriminant.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.groupBox_roots.SuspendLayout();
            this.groupBox_equation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_coefficients
            // 
            this.groupBox_coefficients.Controls.Add(this.button_initialize);
            this.groupBox_coefficients.Controls.Add(this.label1);
            this.groupBox_coefficients.Controls.Add(this.numericUpDown_c);
            this.groupBox_coefficients.Controls.Add(this.numericUpDown_b);
            this.groupBox_coefficients.Controls.Add(this.numericUpDown_a);
            this.groupBox_coefficients.Location = new System.Drawing.Point(12, 61);
            this.groupBox_coefficients.Name = "groupBox_coefficients";
            this.groupBox_coefficients.Size = new System.Drawing.Size(137, 129);
            this.groupBox_coefficients.TabIndex = 0;
            this.groupBox_coefficients.TabStop = false;
            this.groupBox_coefficients.Text = "Coefficients";
            // 
            // button_initialize
            // 
            this.button_initialize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_initialize.Location = new System.Drawing.Point(9, 97);
            this.button_initialize.Name = "button_initialize";
            this.button_initialize.Size = new System.Drawing.Size(122, 23);
            this.button_initialize.TabIndex = 4;
            this.button_initialize.Text = "Initialize";
            this.button_initialize.UseVisualStyleBackColor = true;
            this.button_initialize.Click += new System.EventHandler(this.button_initialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "a =\r\n\r\nb =\r\n\r\nc =";
            // 
            // numericUpDown_c
            // 
            this.numericUpDown_c.Location = new System.Drawing.Point(39, 71);
            this.numericUpDown_c.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_c.Name = "numericUpDown_c";
            this.numericUpDown_c.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown_c.TabIndex = 2;
            this.numericUpDown_c.ValueChanged += new System.EventHandler(this.numericUpDown_c_ValueChanged);
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(39, 45);
            this.numericUpDown_b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown_b.TabIndex = 1;
            this.numericUpDown_b.ValueChanged += new System.EventHandler(this.numericUpDown_b_ValueChanged);
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(39, 19);
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown_a.TabIndex = 0;
            this.numericUpDown_a.ValueChanged += new System.EventHandler(this.numericUpDown_a_ValueChanged);
            // 
            // label_equation
            // 
            this.label_equation.AutoSize = true;
            this.label_equation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equation.Location = new System.Drawing.Point(9, 16);
            this.label_equation.Name = "label_equation";
            this.label_equation.Size = new System.Drawing.Size(110, 14);
            this.label_equation.TabIndex = 4;
            this.label_equation.Text = "ax² + bx + c = 0";
            // 
            // groupBox_discriminant
            // 
            this.groupBox_discriminant.Controls.Add(this.textBox_mini_delta);
            this.groupBox_discriminant.Controls.Add(this.label4);
            this.groupBox_discriminant.Controls.Add(this.label3);
            this.groupBox_discriminant.Controls.Add(this.textbox_delta);
            this.groupBox_discriminant.Location = new System.Drawing.Point(155, 13);
            this.groupBox_discriminant.Name = "groupBox_discriminant";
            this.groupBox_discriminant.Size = new System.Drawing.Size(196, 71);
            this.groupBox_discriminant.TabIndex = 1;
            this.groupBox_discriminant.TabStop = false;
            this.groupBox_discriminant.Text = "Discriminant ";
            // 
            // textBox_mini_delta
            // 
            this.textBox_mini_delta.Location = new System.Drawing.Point(89, 41);
            this.textBox_mini_delta.Name = "textBox_mini_delta";
            this.textBox_mini_delta.ReadOnly = true;
            this.textBox_mini_delta.Size = new System.Drawing.Size(101, 20);
            this.textBox_mini_delta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "δ = √|Δ| =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "∆ = b² - 4ac =";
            // 
            // textbox_delta
            // 
            this.textbox_delta.Location = new System.Drawing.Point(89, 16);
            this.textbox_delta.Name = "textbox_delta";
            this.textbox_delta.ReadOnly = true;
            this.textbox_delta.Size = new System.Drawing.Size(101, 20);
            this.textbox_delta.TabIndex = 0;
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.richTextBox_result);
            this.groupBox_result.Location = new System.Drawing.Point(155, 90);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(353, 100);
            this.groupBox_result.TabIndex = 2;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Result";
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(9, 19);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.ReadOnly = true;
            this.richTextBox_result.Size = new System.Drawing.Size(336, 72);
            this.richTextBox_result.TabIndex = 0;
            this.richTextBox_result.Text = resources.GetString("richTextBox_result.Text");
            // 
            // groupBox_roots
            // 
            this.groupBox_roots.Controls.Add(this.label5);
            this.groupBox_roots.Controls.Add(this.textBox_x1);
            this.groupBox_roots.Controls.Add(this.textBox_x2);
            this.groupBox_roots.Location = new System.Drawing.Point(357, 13);
            this.groupBox_roots.Name = "groupBox_roots";
            this.groupBox_roots.Size = new System.Drawing.Size(151, 71);
            this.groupBox_roots.TabIndex = 3;
            this.groupBox_roots.TabStop = false;
            this.groupBox_roots.Text = "Roots";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "x1 =\r\n\r\nx2 =";
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(42, 16);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.ReadOnly = true;
            this.textBox_x1.Size = new System.Drawing.Size(101, 20);
            this.textBox_x1.TabIndex = 4;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(42, 44);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.ReadOnly = true;
            this.textBox_x2.Size = new System.Drawing.Size(101, 20);
            this.textBox_x2.TabIndex = 5;
            // 
            // groupBox_equation
            // 
            this.groupBox_equation.Controls.Add(this.label_equation);
            this.groupBox_equation.Location = new System.Drawing.Point(12, 13);
            this.groupBox_equation.Name = "groupBox_equation";
            this.groupBox_equation.Size = new System.Drawing.Size(137, 42);
            this.groupBox_equation.TabIndex = 4;
            this.groupBox_equation.TabStop = false;
            this.groupBox_equation.Text = "Equation";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_initialize;
            this.ClientSize = new System.Drawing.Size(520, 198);
            this.Controls.Add(this.groupBox_equation);
            this.Controls.Add(this.groupBox_discriminant);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.groupBox_roots);
            this.Controls.Add(this.groupBox_coefficients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 230);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solving Quadratic Equation with Real Coefficients";
            this.groupBox_coefficients.ResumeLayout(false);
            this.groupBox_coefficients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            this.groupBox_discriminant.ResumeLayout(false);
            this.groupBox_discriminant.PerformLayout();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_roots.ResumeLayout(false);
            this.groupBox_roots.PerformLayout();
            this.groupBox_equation.ResumeLayout(false);
            this.groupBox_equation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_coefficients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_c;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.GroupBox groupBox_discriminant;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.GroupBox groupBox_roots;
        private System.Windows.Forms.Label label_equation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_delta;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.TextBox textBox_mini_delta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.Button button_initialize;
        private System.Windows.Forms.GroupBox groupBox_equation;
    }
}

