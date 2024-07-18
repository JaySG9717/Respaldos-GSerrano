using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respaldos_Automatizados
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            UpdateLocalPaths();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            lbl_current_time.Text = $"Tiempo transcurrido: {elapsedTime.ToString(@"hh\:mm\:ss")}";
        }

        private void btn_seleccionar_unidad_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona la carpeta de destino";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    lbl_descargas_unidadred.Text = Path.Combine(selectedPath, "Descargas");
                    lbl_documentos_unidadred.Text = Path.Combine(selectedPath, "Documentos");
                    lbl_imagenes_unidadred.Text = Path.Combine(selectedPath, "Imagenes");
                    lbl_escritorio_unidadred.Text = Path.Combine(selectedPath, "Escritorio");

                    // Actualizar el TextBox con la ruta seleccionada
                    txt_unidad_red.Text = selectedPath;
                }
            }
        }
        private void UpdateLocalPaths()
        {
            // Rutas de las carpetas locales predeterminadas
            lbl_descargas_mipc.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            lbl_documentos_mipc.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            lbl_imagenes_mipc.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            lbl_escritorio_mipc.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        private async void btn_respaldar_Click(object sender, EventArgs e)
        {
            // Rutas de las carpetas locales predeterminadas
            string sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string sourceDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string sourcePictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string sourceDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            string destinationDesktop = lbl_escritorio_unidadred.Text;
            string destinationDocuments = lbl_documentos_unidadred.Text;
            string destinationPictures = lbl_imagenes_unidadred.Text;
            string destinationDownloads = lbl_descargas_unidadred.Text;

            if (string.IsNullOrEmpty(destinationDesktop) || string.IsNullOrEmpty(destinationDocuments) ||
                string.IsNullOrEmpty(destinationPictures) || string.IsNullOrEmpty(destinationDownloads))
            {
                MessageBox.Show("Por favor, selecciona una ruta de destino válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                startTime = DateTime.Now;
                timer.Start();

                // Contar los archivos totales a copiar
                int totalFiles = CountFiles(sourceDesktop) + CountFiles(sourceDocuments) + CountFiles(sourcePictures) + CountFiles(sourceDownloads);
                int copiedFiles = 0;

                // Calcular el tamaño total de los archivos
                long totalSize = CalculateTotalSize(sourceDesktop) + CalculateTotalSize(sourceDocuments) + CalculateTotalSize(sourcePictures) + CalculateTotalSize(sourceDownloads);


                // Inicializar la barra de progreso
                pb_progreso_respaldo.Minimum = 0;
                pb_progreso_respaldo.Maximum = totalFiles;
                pb_progreso_respaldo.Value = 0;

                // Inicializar los Labels
                lbl_porcentaje.Text = "Progreso: 0%";
                lbl_now_backing.Text = "";
                lbl_remaining_time.Text = "Tiempo restante: Calculando...";
                lbl_current_time.Text = "Tiempo transcurrido: 00:00:00";

                // Copiar el contenido de las carpetas en segundo plano
                await Task.Run(() =>
                {
                    CopyDirectoryContent(sourceDesktop, destinationDesktop, ref copiedFiles, totalFiles);
                    CopyDirectoryContent(sourceDocuments, destinationDocuments, ref copiedFiles, totalFiles);
                    CopyDirectoryContent(sourcePictures, destinationPictures, ref copiedFiles, totalFiles);
                    CopyDirectoryContent(sourceDownloads, destinationDownloads, ref copiedFiles, totalFiles);
                });

                // Mostrar el MessageBox con la información del respaldo
                string readableSize = GetReadableSize(totalSize);
                MessageBox.Show($"Respaldo exitoso, se han copiado {copiedFiles} archivos y el tamaño total es {readableSize}. Ahora puede cerrar el programa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                timer.Stop();
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CopyDirectoryContent(string sourceDir, string destinationDir, ref int copiedFiles, int totalFiles)
        {
            // Crear el directorio de destino si no existe
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            // Copiar los archivos del directorio
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                try
                {
                    var destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                    File.Copy(file, destFile, true);
                    copiedFiles++;
                    UpdateProgress(copiedFiles, totalFiles);
                    UpdateBackingLabel(file);
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignorar archivos a los que no se puede acceder
                    Console.WriteLine($"No se pudo acceder al archivo {file}.");
                }
                catch (Exception ex)
                {
                    // Manejar otros errores
                    Console.WriteLine($"Error al copiar el archivo {file}: {ex.Message}");
                }
            }

            // Copiar los subdirectorios de forma recursiva
            foreach (var subdir in Directory.GetDirectories(sourceDir))
            {
                try
                {
                    var destSubdir = Path.Combine(destinationDir, Path.GetFileName(subdir));
                    CopyDirectoryContent(subdir, destSubdir, ref copiedFiles, totalFiles);
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignorar directorios a los que no se puede acceder
                    Console.WriteLine($"No se pudo acceder al directorio {subdir}.");
                }
                catch (Exception ex)
                {
                    // Manejar otros errores
                    Console.WriteLine($"Error al copiar el directorio {subdir}: {ex.Message}");
                }
            }
        }

        private int CountFiles(string dir)
        {
            int count = 0;
            try
            {
                count += Directory.GetFiles(dir).Length;
                foreach (var subdir in Directory.GetDirectories(dir))
                {
                    count += CountFiles(subdir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Ignorar directorios a los que no se puede acceder
                Console.WriteLine($"No se pudo acceder al directorio {dir}.");
            }
            catch (Exception ex)
            {
                // Manejar otros errores
                Console.WriteLine($"Error al contar los archivos en {dir}: {ex.Message}");
            }
            return count;
        }

        private void UpdateProgress(int copiedFiles, int totalFiles)
        {
            if (pb_progreso_respaldo.InvokeRequired)
            {
                pb_progreso_respaldo.Invoke(new Action(() =>
                {
                    pb_progreso_respaldo.Value = copiedFiles;
                }));
            }
            else
            {
                pb_progreso_respaldo.Value = copiedFiles;
            }

            UpdatePercentageLabel(copiedFiles, totalFiles);
            UpdateRemainingTime(copiedFiles, totalFiles);
        }

        private void UpdatePercentageLabel(int copiedFiles, int totalFiles)
        {
            if (lbl_porcentaje.InvokeRequired)
            {
                lbl_porcentaje.Invoke(new Action(() =>
                {
                    int progress = (copiedFiles * 100) / totalFiles;
                    lbl_porcentaje.Text = $"Progreso: {progress}%";
                }));
            }
            else
            {
                int progress = (copiedFiles * 100) / totalFiles;
                lbl_porcentaje.Text = $"Progreso: {progress}%";
            }
        }

        private void UpdateBackingLabel(string file)
        {
            if (lbl_now_backing.InvokeRequired)
            {
                lbl_now_backing.Invoke(new Action(() =>
                {
                    lbl_now_backing.Text = $"Copiando: {file}";
                }));
            }
            else
            {
                lbl_now_backing.Text = $"Copiando: {file}";
            }
        }

        private void UpdateRemainingTime(int copiedFiles, int totalFiles)
        {
            if (lbl_remaining_time.InvokeRequired)
            {
                lbl_remaining_time.Invoke(new Action(() =>
                {
                    double filesPerSecond = copiedFiles / (DateTime.Now - startTime).TotalSeconds;
                    double remainingSeconds = (totalFiles - copiedFiles) / filesPerSecond;
                    TimeSpan remainingTime = TimeSpan.FromSeconds(remainingSeconds);
                    lbl_remaining_time.Text = $"Tiempo restante: {remainingTime.ToString(@"hh\:mm\:ss")}";
                }));
            }
            else
            {
                double filesPerSecond = copiedFiles / (DateTime.Now - startTime).TotalSeconds;
                double remainingSeconds = (totalFiles - copiedFiles) / filesPerSecond;
                TimeSpan remainingTime = TimeSpan.FromSeconds(remainingSeconds);
                lbl_remaining_time.Text = $"Tiempo restante: {remainingTime.ToString(@"hh\:mm\:ss")}";
            }
        }
        private long CalculateTotalSize(string dir)
        {
            long totalSize = 0;

            try
            {
                // Sumar el tamaño de todos los archivos en el directorio
                foreach (var file in Directory.GetFiles(dir))
                {
                    totalSize += new FileInfo(file).Length;
                }

                // Sumar el tamaño de los archivos en los subdirectorios de forma recursiva
                foreach (var subdir in Directory.GetDirectories(dir))
                {
                    totalSize += CalculateTotalSize(subdir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Ignorar directorios a los que no se puede acceder
                Console.WriteLine($"No se pudo acceder al directorio {dir}.");
            }
            catch (Exception ex)
            {
                // Manejar otros errores
                Console.WriteLine($"Error al calcular el tamaño de los archivos en {dir}: {ex.Message}");
            }

            return totalSize;
        }

        private string GetReadableSize(long sizeInBytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = sizeInBytes;
            int order = 0;

            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return $"{len:0.##} {sizes[order]}";
        }

        private void btn_cancelar_respaldo_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de cancelación
            MessageBox.Show("Proceso interrumpido por el usuario", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Terminar la aplicación
            Application.Exit();
        }
    }
}
