namespace Practica2Nomina
{
    partial class FormTarifas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoraRegular = new TextBox();
            txtHoraExtra = new TextBox();
            txtHoraDia = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Hora Regular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Hora Extra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 149);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Hora Dia";
            label3.Click += label3_Click;
            // 
            // txtHoraRegular
            // 
            txtHoraRegular.Location = new Point(161, 40);
            txtHoraRegular.Name = "txtHoraRegular";
            txtHoraRegular.Size = new Size(150, 31);
            txtHoraRegular.TabIndex = 3;
            txtHoraRegular.TextChanged += txtHoraRegular_TextChanged;
            // 
            // txtHoraExtra
            // 
            txtHoraExtra.Location = new Point(161, 95);
            txtHoraExtra.Name = "txtHoraExtra";
            txtHoraExtra.Size = new Size(150, 31);
            txtHoraExtra.TabIndex = 4;
            // 
            // txtHoraDia
            // 
            txtHoraDia.Location = new Point(161, 149);
            txtHoraDia.Name = "txtHoraDia";
            txtHoraDia.Size = new Size(150, 31);
            txtHoraDia.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(377, 93);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtHoraDia);
            Controls.Add(txtHoraExtra);
            Controls.Add(txtHoraRegular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTarifas";
            Text = "FormTarifas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoraRegular;
        private TextBox txtHoraExtra;
        private TextBox txtHoraDia;
        private Button btnGuardar;
    }
}