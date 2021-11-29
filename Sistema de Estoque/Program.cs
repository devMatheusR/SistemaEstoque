using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Estoque
{
    class Program : Interface1
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        public void AdicionarProduto()
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduto()
        {
            throw new NotImplementedException();
        }
    }
}
