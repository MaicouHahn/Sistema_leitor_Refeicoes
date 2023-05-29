using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp1
{
    internal class CadastroPedidosDoDia
    {
        public string matricula { get; set; }
        public int tickets { get; set; }
        public DateTime data { get; set; }
        public CadastroPedidosDoDia(string matricula, int tickets, DateTime data)
        {

           this.matricula = matricula;
           this.tickets = tickets;
           this.data = data;
        }
    }
}
