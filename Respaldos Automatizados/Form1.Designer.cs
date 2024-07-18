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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_unidad_red
            // 
            txt_unidad_red.Location = new Point(140, 11);
            txt_unidad_red.Name = "txt_unidad_red";
            txt_unidad_red.Size = new Size(239, 23);
            txt_unidad_red.TabIndex = 0;
            txt_unidad_red.Text = "Por Favor Seleccione Unidad de Resplado";
            // 
            // btn_seleccionar_unidad
            // 
            btn_seleccionar_unidad.Location = new Point(420, 11);
            btn_seleccionar_unidad.Name = "btn_seleccionar_unidad";
            btn_seleccionar_unidad.Size = new Size(75, 23);
            btn_seleccionar_unidad.TabIndex = 1;
            btn_seleccionar_unidad.Text = "Seleccionar";
            btn_seleccionar_unidad.UseVisualStyleBackColor = true;
            btn_seleccionar_unidad.Click += btn_seleccionar_unidad_Click;
            // 
            // btn_respaldar
            // 
            btn_respaldar.Location = new Point(68, 310);
            btn_respaldar.Name = "btn_respaldar";
            btn_respaldar.Size = new Size(191, 56);
            btn_respaldar.TabIndex = 2;
            btn_respaldar.Text = "Iniciar Respaldo";
            btn_respaldar.UseVisualStyleBackColor = true;
            btn_respaldar.Click += btn_respaldar_Click;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(68, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 140);
            panel1.TabIndex = 3;
            // 
            // lbl_escritorio_unidadred
            // 
            lbl_escritorio_unidadred.AutoSize = true;
            lbl_escritorio_unidadred.Location = new Point(236, 115);
            lbl_escritorio_unidadred.Name = "lbl_escritorio_unidadred";
            lbl_escritorio_unidadred.Size = new Size(138, 15);
            lbl_escritorio_unidadred.TabIndex = 9;
            lbl_escritorio_unidadred.Text = "Escritorio/Unidad de Red";
            // 
            // lbl_imagenes_unidadred
            // 
            lbl_imagenes_unidadred.AutoSize = true;
            lbl_imagenes_unidadred.Location = new Point(235, 91);
            lbl_imagenes_unidadred.Name = "lbl_imagenes_unidadred";
            lbl_imagenes_unidadred.Size = new Size(140, 15);
            lbl_imagenes_unidadred.TabIndex = 8;
            lbl_imagenes_unidadred.Text = "Imagenes/Unidad de Red";
            // 
            // lbl_documentos_unidadred
            // 
            lbl_documentos_unidadred.AutoSize = true;
            lbl_documentos_unidadred.Location = new Point(235, 67);
            lbl_documentos_unidadred.Name = "lbl_documentos_unidadred";
            lbl_documentos_unidadred.Size = new Size(157, 15);
            lbl_documentos_unidadred.TabIndex = 7;
            lbl_documentos_unidadred.Text = "Documentos/Unidad de Red";
            // 
            // lbl_descargas_unidadred
            // 
            lbl_descargas_unidadred.AutoSize = true;
            lbl_descargas_unidadred.Location = new Point(236, 41);
            lbl_descargas_unidadred.Name = "lbl_descargas_unidadred";
            lbl_descargas_unidadred.Size = new Size(142, 15);
            lbl_descargas_unidadred.TabIndex = 6;
            lbl_descargas_unidadred.Text = "Descargas/Unidad de Red";
            // 
            // lbl_escritorio_mipc
            // 
            lbl_escritorio_mipc.AutoSize = true;
            lbl_escritorio_mipc.Location = new Point(15, 115);
            lbl_escritorio_mipc.Name = "lbl_escritorio_mipc";
            lbl_escritorio_mipc.Size = new Size(93, 15);
            lbl_escritorio_mipc.TabIndex = 5;
            lbl_escritorio_mipc.Text = "Escritorio/Mi PC";
            // 
            // lbl_imagenes_mipc
            // 
            lbl_imagenes_mipc.AutoSize = true;
            lbl_imagenes_mipc.Location = new Point(15, 91);
            lbl_imagenes_mipc.Name = "lbl_imagenes_mipc";
            lbl_imagenes_mipc.Size = new Size(95, 15);
            lbl_imagenes_mipc.TabIndex = 4;
            lbl_imagenes_mipc.Text = "Imagenes/Mi PC";
            // 
            // lbl_documentos_mipc
            // 
            lbl_documentos_mipc.AutoSize = true;
            lbl_documentos_mipc.Location = new Point(15, 67);
            lbl_documentos_mipc.Name = "lbl_documentos_mipc";
            lbl_documentos_mipc.Size = new Size(112, 15);
            lbl_documentos_mipc.TabIndex = 3;
            lbl_documentos_mipc.Text = "Documentos/Mi PC";
            // 
            // lbl_descargas_mipc
            // 
            lbl_descargas_mipc.AutoSize = true;
            lbl_descargas_mipc.Location = new Point(15, 41);
            lbl_descargas_mipc.Name = "lbl_descargas_mipc";
            lbl_descargas_mipc.Size = new Size(97, 15);
            lbl_descargas_mipc.TabIndex = 2;
            lbl_descargas_mipc.Text = "Descargas/Mi PC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 14);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Origen";
            // 
            // pb_progreso_respaldo
            // 
            pb_progreso_respaldo.Location = new Point(12, 199);
            pb_progreso_respaldo.Name = "pb_progreso_respaldo";
            pb_progreso_respaldo.Size = new Size(495, 23);
            pb_progreso_respaldo.TabIndex = 4;
            // 
            // lbl_porcentaje
            // 
            lbl_porcentaje.AutoSize = true;
            lbl_porcentaje.Location = new Point(513, 207);
            lbl_porcentaje.Name = "lbl_porcentaje";
            lbl_porcentaje.Size = new Size(63, 15);
            lbl_porcentaje.TabIndex = 10;
            lbl_porcentaje.Text = "Porcentaje";
            // 
            // lbl_remaining_time
            // 
            lbl_remaining_time.AutoSize = true;
            lbl_remaining_time.Location = new Point(12, 263);
            lbl_remaining_time.Name = "lbl_remaining_time";
            lbl_remaining_time.Size = new Size(95, 15);
            lbl_remaining_time.TabIndex = 12;
            lbl_remaining_time.Text = "Tiempo Restante";
            // 
            // lbl_now_backing
            // 
            lbl_now_backing.AutoSize = true;
            lbl_now_backing.Location = new Point(12, 235);
            lbl_now_backing.Name = "lbl_now_backing";
            lbl_now_backing.Size = new Size(119, 15);
            lbl_now_backing.TabIndex = 13;
            lbl_now_backing.Text = "Ahora Respaldando...";
            // 
            // lbl_current_time
            // 
            lbl_current_time.AutoSize = true;
            lbl_current_time.Location = new Point(285, 263);
            lbl_current_time.Name = "lbl_current_time";
            lbl_current_time.Size = new Size(115, 15);
            lbl_current_time.TabIndex = 14;
            lbl_current_time.Text = "Tiempo Transcurrido";
            // 
            // btn_cancelar_respaldo
            // 
            btn_cancelar_respaldo.Location = new Point(304, 310);
            btn_cancelar_respaldo.Name = "btn_cancelar_respaldo";
            btn_cancelar_respaldo.Size = new Size(191, 56);
            btn_cancelar_respaldo.TabIndex = 15;
            btn_cancelar_respaldo.Text = "Cancelar Respaldo y Salir";
            btn_cancelar_respaldo.UseVisualStyleBackColor = true;
            btn_cancelar_respaldo.Click += btn_cancelar_respaldo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 382);
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
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
