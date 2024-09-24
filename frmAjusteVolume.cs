using System;
using System.Diagnostics;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;

namespace AjusteVolumeWindows
{
    public partial class AjusteVolumeWindows : Form
    {
        private CoreAudioDevice defaultPlaybackDevice;
        private CoreAudioDevice defaultRecordingDevice;
        private bool usarNircmd;

        public AjusteVolumeWindows(bool usarNircmd = false)
        {
            InitializeComponent();
            this.usarNircmd = usarNircmd;

            if (!usarNircmd)
            {
                try
                {
                    var controller = new CoreAudioController();
                    defaultPlaybackDevice = controller.DefaultPlaybackDevice;
                    defaultRecordingDevice = controller.DefaultCaptureDevice;

                    trackBarSistema.Value = (int)(defaultPlaybackDevice?.Volume ?? 0);
                    trackBarMicrofone.Value = (int)(defaultRecordingDevice?.Volume ?? 0);

                    lblVolumeSistema.Text = trackBarSistema.Value + "%";
                    lblVolumeMicrofone.Text = trackBarMicrofone.Value + "%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inicializar dispositivos de áudio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                trackBarSistema.Value = 50; 
                trackBarMicrofone.Value = 50;
                lblVolumeSistema.Text = trackBarSistema.Value + "%";
                lblVolumeMicrofone.Text = trackBarMicrofone.Value + "%";
            }
        }

        private void trackBarMicrofone_Scroll(object sender, EventArgs e)
        {
            lblVolumeMicrofone.Text = trackBarMicrofone.Value + "%";
        }

        private void trackBarSistema_Scroll(object sender, EventArgs e)
        {
            lblVolumeSistema.Text = trackBarSistema.Value + "%";
        }

        private void AjustarVolumeMicrofoneComNircmd(int volume)
        {
            try
            {
                string nircmdPath = @".\nircmd.exe";

                int incremento = (int)(65535 * (volume / 100.0));

                string arguments = $"changesysvolume {incremento} microphone";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = nircmdPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ajustar o volume com nircmd: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarVolumeSistemaComNircmd(int volume)
        {
            try
            {
                string nircmdPath = @".\nircmd.exe";

                int incremento = (int)(65535 * (volume / 100.0));

                string arguments = $"changesysvolume {incremento}";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = nircmdPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ajustar o volume com nircmd: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
            if (!usarNircmd)
            {
                try
                {
                    if (defaultPlaybackDevice != null)
                    {
                        defaultPlaybackDevice.Volume = trackBarSistema.Value;
                    }

                    if (defaultRecordingDevice != null)
                    {
                        defaultRecordingDevice.Volume = trackBarMicrofone.Value;
                    }

                    MessageBox.Show("Configurações aplicadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aplicar volume: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AjustarVolumeMicrofoneComNircmd(trackBarMicrofone.Value);
                    AjustarVolumeSistemaComNircmd(trackBarSistema.Value);

                    MessageBox.Show("Configurações aplicadas com sucesso usando nircmd!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aplicar volume com nircmd: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
