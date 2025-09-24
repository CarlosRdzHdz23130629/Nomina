namespace Practica2Nomina
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tarifasToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tarifasToolStripMenuItem1 = new ToolStripMenuItem();
            asignarTarifasToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            importarExcelToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tarifasToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 36);
            // 
            // tarifasToolStripMenuItem
            // 
            tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            tarifasToolStripMenuItem.Size = new Size(133, 32);
            tarifasToolStripMenuItem.Text = "Tarifas";
            tarifasToolStripMenuItem.Click += tarifasToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1379, 346);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "No. Empleado";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Reg HR";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 75;
            // 
            // Column5
            // 
            Column5.HeaderText = "OT HR";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 75;
            // 
            // Column6
            // 
            Column6.HeaderText = "D HR";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 75;
            // 
            // Column7
            // 
            Column7.HeaderText = "$ Reg HR";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 75;
            // 
            // Column8
            // 
            Column8.HeaderText = "$ OT HR";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 75;
            // 
            // Column9
            // 
            Column9.HeaderText = "$ D HR";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 75;
            // 
            // Column10
            // 
            Column10.HeaderText = "Total";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 75;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tarifasToolStripMenuItem1, operacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1388, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(147, 34);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // tarifasToolStripMenuItem1
            // 
            tarifasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { asignarTarifasToolStripMenuItem });
            tarifasToolStripMenuItem1.Name = "tarifasToolStripMenuItem1";
            tarifasToolStripMenuItem1.Size = new Size(77, 29);
            tarifasToolStripMenuItem1.Text = "Tarifas";
            // 
            // asignarTarifasToolStripMenuItem
            // 
            asignarTarifasToolStripMenuItem.Name = "asignarTarifasToolStripMenuItem";
            asignarTarifasToolStripMenuItem.Size = new Size(270, 34);
            asignarTarifasToolStripMenuItem.Text = "Asignar Tarifas";
            asignarTarifasToolStripMenuItem.Click += asignarTarifasToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importarExcelToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(127, 29);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // importarExcelToolStripMenuItem
            // 
            importarExcelToolStripMenuItem.Name = "importarExcelToolStripMenuItem";
            importarExcelToolStripMenuItem.Size = new Size(270, 34);
            importarExcelToolStripMenuItem.Text = "Importar Excel";
            importarExcelToolStripMenuItem.Click += importarExcelToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1388, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tarifasToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tarifasToolStripMenuItem1;
        private ToolStripMenuItem asignarTarifasToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem importarExcelToolStripMenuItem;
        private StatusStrip statusStrip1;
    }
}
