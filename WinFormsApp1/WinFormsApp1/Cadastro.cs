using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class Cadastro
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public string matricula { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public string serie { get; set; }
        public DateTime data { get; set; }
        public int tickets { get; set; }
 
        public Cadastro(string nome, string sobrenome, string telefone, string matricula,string email, string token,DateTime data,string serie)
        {
            if (serie.Equals("1º Ano"))
            {
                tickets = 1;
            }
            else
            {
                tickets = 3;
            }
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.matricula = matricula;
            this.email = email;
            this.token = token; 
            this.data = data;
            this.serie = serie;
        }

    }
}
