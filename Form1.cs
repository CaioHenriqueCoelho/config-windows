using Microsoft.Win32;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ConfigWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (temaWhite.Checked)
            {
                AplicarTemaWindows(1);
            }
            else if (temaDark.Checked)
            {
                AplicarTemaWindows(0);
            }

            if (segundoPlano.Checked)
            {
                DesativarAtividadesEmSegundoPlano();
            }

            if (updateDesempenho.Checked)
            {
                AjustarParaMelhorDesempenho();
            }

            if (removeXbox.Checked)
            {
                DesinstalarXboxApp();
            }

            if (gamebar.Checked)
            {
                DesativarXboxGameBar();
            }

            if (notices.Checked)
            {
                DesativarNoticiasEInteresses();
            }

            if (modeGame.Checked)
            {
                DesativarModoDeJogo();
            }

            if (energy.Checked)
            {
                AtivarEnergiaMaxima();
            }


        }
        private void AplicarTemaWindows(int valor)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);

                if (key != null)
                {
                    key.SetValue("AppsUseLightTheme", valor, RegistryValueKind.DWord);
                    key.SetValue("SystemUsesLightTheme", valor, RegistryValueKind.DWord);
                    key.Close();

                    string tema = (valor == 1) ? "CLARO" : "ESCURO";
                }
                else
                {
                    MessageBox.Show("Não foi possível acessar a chave do Registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o tema: " + ex.Message);
            }
        }

        private void DesativarAtividadesEmSegundoPlano()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications", true);

                if (key != null)
                {
                    key.SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);
                    key.Close();

                    MessageBox.Show("Execução de aplicativos em segundo plano DESATIVADA.");
                }
                else
                {
                    MessageBox.Show("Não foi possível acessar o Registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar modificar a configuração: " + ex.Message);
            }
        }

        private void AjustarParaMelhorDesempenho()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", true);

                if (key != null)
                {
                    key.SetValue("VisualFXSetting", 2, RegistryValueKind.DWord); // 2 = melhor desempenho
                    key.Close();

                    MessageBox.Show("Ajustado para obter o melhor desempenho. Reinicie para aplicar completamente.");
                }
                else
                {
                    MessageBox.Show("Não foi possível acessar o Registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void DesinstalarXboxApp()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "powershell.exe";
            psi.Arguments = "-Command \"Get-AppxPackage *xboxapp* | Remove-AppxPackage\"";
            psi.Verb = "runas"; // executa como administrador
            psi.UseShellExecute = true;

            Process.Start(psi);
        }

        public void DesativarXboxGameBar()
        {
            try
            {
                // Desativa Game Bar (captura de apps)
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR", true))
                {
                    if (key != null)
                    {
                        key.SetValue("AppCaptureEnabled", 0, RegistryValueKind.DWord);
                    }
                }

                // Desativa Game DVR (gravação)
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"System\GameConfigStore", true))
                {
                    if (key != null)
                    {
                        key.SetValue("GameDVR_Enabled", 0, RegistryValueKind.DWord);
                    }
                }

                MessageBox.Show("Xbox Game Bar desativada. Reinicie o PC para aplicar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar Xbox Game Bar: " + ex.Message);
            }
        }

        public void DesativarNoticiasEInteresses()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Feeds", true))
                {
                    if (key != null)
                    {
                        key.SetValue("ShellFeedsTaskbarViewMode", 0, RegistryValueKind.DWord);
                        MessageBox.Show("Notícias e Interesses desativados. Reinicie para aplicar.");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível acessar a chave do Registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void DesativarModoDeJogo()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\GameBar", true))
                {
                    if (key != null)
                    {
                        key.SetValue("AllowAutoGameMode", 0, RegistryValueKind.DWord);
                        MessageBox.Show("Modo de Jogo desativado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível acessar a chave do Modo de Jogo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar Modo de Jogo: " + ex.Message);
            }
        }

        public void AtivarEnergiaMaxima()
        {
            try
            {
                // GUID do plano de energia "Desempenho Máximo"
                string guid = "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";

                // Executa dois comandos: duplicar e ativar o plano
                string comando = $"powercfg -duplicatescheme {guid} & powercfg -setactive {guid}";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + comando,
                    Verb = "runas", // Executar como administrador
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(psi);

                MessageBox.Show("Plano de energia 'Desempenho Máximo' ativado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ativar plano de energia: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}


    
