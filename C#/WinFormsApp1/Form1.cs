namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_To.PreviewKeyDown += textBox_To_PreviewKeyDown;
        }

        private void button_From_Click(object sender, EventArgs e)
        {
            using OpenFileDialog open_file_dialog = new OpenFileDialog();
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_From.Text = open_file_dialog.FileName;
            }
        }

        private void button_To_Click(object sender, EventArgs e)
        {
            using SaveFileDialog save_file_dialog = new SaveFileDialog();
            if (save_file_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_To.Text = save_file_dialog.FileName;
            }
        }

        private async Task copy_async()
        {
            button_Copy.Enabled = false;
            button_From.Enabled = false;
            button_To.Enabled = false;
            textBox_From.Enabled = false;
            textBox_To.Enabled = false;

            string source_path = textBox_From.Text;
            string destination_path = textBox_To.Text;

            if (!File.Exists(source_path))
            {
                MessageBox.Show("Cannot find source file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using FileStream source_stream = new FileStream(source_path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
                using FileStream destination_stream = new FileStream(destination_path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);

                byte[] buffer = new byte[4096];
                long total_bytes = source_stream.Length;
                long copied_bytes = 0;

                progressBar.Value = 0;
                progressBar.Maximum = 100;

                int bytes_read;
                while ((bytes_read = await source_stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await destination_stream.WriteAsync(buffer, 0, bytes_read);
                    await destination_stream.FlushAsync();

                    copied_bytes += bytes_read;
                    int progress = (int)(copied_bytes * 100 / total_bytes);
                    progressBar.Value = progress;
                }

                MessageBox.Show("Copy complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button_Copy.Enabled = true;
            button_From.Enabled = true;
            button_To.Enabled = true;
            textBox_From.Enabled = true;
            textBox_To.Enabled = true;
        }

        private async void textBox_To_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await copy_async();
                e.IsInputKey = true;
            }
        }

        private async void button_Copy_Click(object sender, EventArgs e)
        {
            await copy_async();
        }
    }
}