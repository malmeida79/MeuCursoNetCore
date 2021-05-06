using System.Windows.Forms;

namespace Curso.UI
{
    public static class Msgs
    {

        public static void Erro(string mensagem, string titulo = "")
        {
            if (string.IsNullOrEmpty(titulo))
            {
                titulo = ":: sistema ::";
            }

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Alerta(string mensagem, string titulo = "")
        {
            if (string.IsNullOrEmpty(titulo))
            {
                titulo = ":: sistema ::";
            }

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Informa(string mensagem, string titulo = "")
        {
            if (string.IsNullOrEmpty(titulo))
            {
                titulo = ":: sistema ::";
            }

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirma(string mensagem, string titulo = "")
        {
            if (string.IsNullOrEmpty(titulo))
            {
                titulo = ":: sistema ::";
            }

            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
