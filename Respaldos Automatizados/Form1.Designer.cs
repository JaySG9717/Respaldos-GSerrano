namespace Respaldos_Automatizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_unidad_red = new TextBox();
            btn_seleccionar_unidad = new Button();
            btn_respaldar = new Button();
            panel1 = new Panel();
            lbl_escritorio_unidadred = new Label();
            lbl_imagenes_unidadred = new Label();
            lbl_documentos_unidadred = new Label();
            lbl_descargas_unidadred = new Label();
            lbl_escritorio_mipc = new Label();
            lbl_imagenes_mipc = new Label();
            lbl_documentos_mipc = new Label();
            lbl_descargas_mipc = new Label();
            label2 = new Label();
            label1 = new Label();
            pb_progreso_respaldo = new ProgressBar();
            lbl_porcentaje = new Label();
            lbl_remaining_time = new Label();
            lbl_now_backing = new Label();
            lbl_current_time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_cancelar_respaldo = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txt_unidad_red
            // 
            txt_unidad_red.BackColor = Color.FromArgb(97, 169, 210);
            txt_unidad_red.BorderStyle = BorderStyle.FixedSingle;
            txt_unidad_red.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_unidad_red.ForeColor = Color.White;
            txt_unidad_red.Location = new Point(105, 98);
            txt_unidad_red.Name = "txt_unidad_red";
            txt_unidad_red.Size = new Size(309, 29);
            txt_unidad_red.TabIndex = 0;
            txt_unidad_red.Text = "Por Favor Seleccione Unidad de Resplado";
            // 
            // btn_seleccionar_unidad
            // 
            btn_seleccionar_unidad.Location = new Point(420, 98);
            btn_seleccionar_unidad.Name = "btn_seleccionar_unidad";
            btn_seleccionar_unidad.Size = new Size(75, 29);
            btn_seleccionar_unidad.TabIndex = 1;
            btn_seleccionar_unidad.Text = "Seleccionar";
            btn_seleccionar_unidad.UseVisualStyleBackColor = true;
            btn_seleccionar_unidad.Click += btn_seleccionar_unidad_Click;
            // 
            // btn_respaldar
            // 
            btn_respaldar.BackColor = Color.Lime;
            btn_respaldar.BackgroundImage = (Image)resources.GetObject("btn_respaldar.BackgroundImage");
            btn_respaldar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_respaldar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_respaldar.ForeColor = SystemColors.ControlText;
            btn_respaldar.Location = new Point(68, 380);
            btn_respaldar.Name = "btn_respaldar";
            btn_respaldar.Size = new Size(191, 72);
            btn_respaldar.TabIndex = 2;
            btn_respaldar.Text = "Iniciar Respaldo";
            btn_respaldar.UseVisualStyleBackColor = false;
            btn_respaldar.Click += btn_respaldar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 92, 134);
            panel1.Controls.Add(lbl_escritorio_unidadred);
            panel1.Controls.Add(lbl_imagenes_unidadred);
            panel1.Controls.Add(lbl_documentos_unidadred);
            panel1.Controls.Add(lbl_descargas_unidadred);
            panel1.Controls.Add(lbl_escritorio_mipc);
            panel1.Controls.Add(lbl_imagenes_mipc);
            panel1.Controls.Add(lbl_documentos_mipc);
            panel1.Controls.Add(lbl_descargas_mipc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(68, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 140);
            panel1.TabIndex = 3;
            // 
            // lbl_escritorio_unidadred
            // 
            lbl_escritorio_unidadred.AutoSize = true;
            lbl_escritorio_unidadred.Font = new Font("Segoe UI", 12F);
            lbl_escritorio_unidadred.ForeColor = Color.White;
            lbl_escritorio_unidadred.Location = new Point(260, 106);
            lbl_escritorio_unidadred.Name = "lbl_escritorio_unidadred";
            lbl_escritorio_unidadred.Size = new Size(183, 21);
            lbl_escritorio_unidadred.TabIndex = 9;
            lbl_escritorio_unidadred.Text = "Escritorio/Unidad de Red";
            // 
            // lbl_imagenes_unidadred
            // 
            lbl_imagenes_unidadred.AutoSize = true;
            lbl_imagenes_unidadred.Font = new Font("Segoe UI", 12F);
            lbl_imagenes_unidadred.ForeColor = Color.White;
            lbl_imagenes_unidadred.Location = new Point(259, 82);
            lbl_imagenes_unidadred.Name = "lbl_imagenes_unidadred";
            lbl_imagenes_unidadred.Size = new Size(185, 21);
            lbl_imagenes_unidadred.TabIndex = 8;
            lbl_imagenes_unidadred.Text = "Imagenes/Unidad de Red";
            // 
            // lbl_documentos_unidadred
            // 
            lbl_documentos_unidadred.AutoSize = true;
            lbl_documentos_unidadred.Font = new Font("Segoe UI", 12F);
            lbl_documentos_unidadred.ForeColor = Color.White;
            lbl_documentos_unidadred.Location = new Point(259, 58);
            lbl_documentos_unidadred.Name = "lbl_documentos_unidadred";
            lbl_documentos_unidadred.Size = new Size(206, 21);
            lbl_documentos_unidadred.TabIndex = 7;
            lbl_documentos_unidadred.Text = "Documentos/Unidad de Red";
            // 
            // lbl_descargas_unidadred
            // 
            lbl_descargas_unidadred.AutoSize = true;
            lbl_descargas_unidadred.Font = new Font("Segoe UI", 12F);
            lbl_descargas_unidadred.ForeColor = Color.White;
            lbl_descargas_unidadred.Location = new Point(260, 32);
            lbl_descargas_unidadred.Name = "lbl_descargas_unidadred";
            lbl_descargas_unidadred.Size = new Size(189, 21);
            lbl_descargas_unidadred.TabIndex = 6;
            lbl_descargas_unidadred.Text = "Descargas/Unidad de Red";
            // 
            // lbl_escritorio_mipc
            // 
            lbl_escritorio_mipc.AutoSize = true;
            lbl_escritorio_mipc.Font = new Font("Segoe UI", 12F);
            lbl_escritorio_mipc.ForeColor = Color.White;
            lbl_escritorio_mipc.Location = new Point(7, 109);
            lbl_escritorio_mipc.Name = "lbl_escritorio_mipc";
            lbl_escritorio_mipc.Size = new Size(122, 21);
            lbl_escritorio_mipc.TabIndex = 5;
            lbl_escritorio_mipc.Text = "Escritorio/Mi PC";
            // 
            // lbl_imagenes_mipc
            // 
            lbl_imagenes_mipc.AutoSize = true;
            lbl_imagenes_mipc.Font = new Font("Segoe UI", 12F);
            lbl_imagenes_mipc.ForeColor = Color.White;
            lbl_imagenes_mipc.Location = new Point(7, 85);
            lbl_imagenes_mipc.Name = "lbl_imagenes_mipc";
            lbl_imagenes_mipc.Size = new Size(124, 21);
            lbl_imagenes_mipc.TabIndex = 4;
            lbl_imagenes_mipc.Text = "Imagenes/Mi PC";
            // 
            // lbl_documentos_mipc
            // 
            lbl_documentos_mipc.AutoSize = true;
            lbl_documentos_mipc.Font = new Font("Segoe UI", 12F);
            lbl_documentos_mipc.ForeColor = Color.White;
            lbl_documentos_mipc.Location = new Point(7, 61);
            lbl_documentos_mipc.Name = "lbl_documentos_mipc";
            lbl_documentos_mipc.Size = new Size(145, 21);
            lbl_documentos_mipc.TabIndex = 3;
            lbl_documentos_mipc.Text = "Documentos/Mi PC";
            // 
            // lbl_descargas_mipc
            // 
            lbl_descargas_mipc.AutoSize = true;
            lbl_descargas_mipc.Font = new Font("Segoe UI", 12F);
            lbl_descargas_mipc.ForeColor = Color.White;
            lbl_descargas_mipc.Location = new Point(7, 35);
            lbl_descargas_mipc.Name = "lbl_descargas_mipc";
            lbl_descargas_mipc.Size = new Size(128, 21);
            lbl_descargas_mipc.TabIndex = 2;
            lbl_descargas_mipc.Text = "Descargas/Mi PC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(273, 4);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 1;
            label2.Text = "Destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 5);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Origen";
            // 
            // pb_progreso_respaldo
            // 
            pb_progreso_respaldo.Location = new Point(12, 292);
            pb_progreso_respaldo.Name = "pb_progreso_respaldo";
            pb_progreso_respaldo.Size = new Size(495, 23);
            pb_progreso_respaldo.TabIndex = 4;
            // 
            // lbl_porcentaje
            // 
            lbl_porcentaje.AutoSize = true;
            lbl_porcentaje.Font = new Font("Segoe UI", 12F);
            lbl_porcentaje.ForeColor = Color.White;
            lbl_porcentaje.Location = new Point(505, 292);
            lbl_porcentaje.Name = "lbl_porcentaje";
            lbl_porcentaje.Size = new Size(82, 21);
            lbl_porcentaje.TabIndex = 10;
            lbl_porcentaje.Text = "Porcentaje";
            // 
            // lbl_remaining_time
            // 
            lbl_remaining_time.AutoSize = true;
            lbl_remaining_time.Font = new Font("Segoe UI", 12F);
            lbl_remaining_time.ForeColor = Color.White;
            lbl_remaining_time.Location = new Point(12, 356);
            lbl_remaining_time.Name = "lbl_remaining_time";
            lbl_remaining_time.Size = new Size(126, 21);
            lbl_remaining_time.TabIndex = 12;
            lbl_remaining_time.Text = "Tiempo Restante";
            // 
            // lbl_now_backing
            // 
            lbl_now_backing.AutoSize = true;
            lbl_now_backing.Font = new Font("Segoe UI", 12F);
            lbl_now_backing.ForeColor = Color.White;
            lbl_now_backing.Location = new Point(12, 328);
            lbl_now_backing.Name = "lbl_now_backing";
            lbl_now_backing.Size = new Size(155, 21);
            lbl_now_backing.TabIndex = 13;
            lbl_now_backing.Text = "Ahora Respaldando...";
            // 
            // lbl_current_time
            // 
            lbl_current_time.AutoSize = true;
            lbl_current_time.Font = new Font("Segoe UI", 12F);
            lbl_current_time.ForeColor = Color.White;
            lbl_current_time.Location = new Point(285, 356);
            lbl_current_time.Name = "lbl_current_time";
            lbl_current_time.Size = new Size(153, 21);
            lbl_current_time.TabIndex = 14;
            lbl_current_time.Text = "Tiempo Transcurrido";
            // 
            // btn_cancelar_respaldo
            // 
            btn_cancelar_respaldo.BackColor = Color.Red;
            btn_cancelar_respaldo.BackgroundImage = (Image)resources.GetObject("btn_cancelar_respaldo.BackgroundImage");
            btn_cancelar_respaldo.BackgroundImageLayout = ImageLayout.Zoom;
            btn_cancelar_respaldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar_respaldo.ForeColor = SystemColors.WindowText;
            btn_cancelar_respaldo.Location = new Point(328, 380);
            btn_cancelar_respaldo.Name = "btn_cancelar_respaldo";
            btn_cancelar_respaldo.Size = new Size(191, 72);
            btn_cancelar_respaldo.TabIndex = 15;
            btn_cancelar_respaldo.Text = "Cancelar Respaldo y Salir";
            btn_cancelar_respaldo.UseVisualStyleBackColor = false;
            btn_cancelar_respaldo.Click += btn_cancelar_respaldo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 44, 73);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 73);
            panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(486, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(153, 4);
            label3.Name = "label3";
            label3.Size = new Size(259, 65);
            label3.TabIndex = 0;
            label3.Text = "GS Backup";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(538, 174);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 169, 210);
            ClientSize = new Size(596, 464);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(btn_cancelar_respaldo);
            Controls.Add(lbl_current_time);
            Controls.Add(lbl_now_backing);
            Controls.Add(lbl_remaining_time);
            Controls.Add(lbl_porcentaje);
            Controls.Add(pb_progreso_respaldo);
            Controls.Add(panel1);
            Controls.Add(btn_respaldar);
            Controls.Add(btn_seleccionar_unidad);
            Controls.Add(txt_unidad_red);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GS Backup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_unidad_red;
        private Button btn_seleccionar_unidad;
        private Button btn_respaldar;
        private Panel panel1;
        private Label lbl_imagenes_mipc;
        private Label lbl_documentos_mipc;
        private Label lbl_descargas_mipc;
        private Label label2;
        private Label label1;
        private Label lbl_escritorio_unidadred;
        private Label lbl_imagenes_unidadred;
        private Label lbl_documentos_unidadred;
        private Label lbl_descargas_unidadred;
        private Label lbl_escritorio_mipc;
        private ProgressBar pb_progreso_respaldo;
        private Label lbl_porcentaje;
        private Label lbl_remaining_time;
        private Label lbl_now_backing;
        private Label lbl_current_time;
        private System.Windows.Forms.Timer timer1;
        private Button btn_cancelar_respaldo;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
