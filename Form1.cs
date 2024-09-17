using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable3
{
    public partial class Form1 : Form
    {
        TipoPokemon tipo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Normal(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("normal", new string[] { "lucha" }, null, new string[] { "fantasma" }, null);
            cargarInfo(tipo);
        }

        private void Agua(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("Agua", new string[] { "planta", "electrico" }, new string[] { "acero", "fuego", "agua", "hielo" }
            , null, new string[] { "tierra", "roca", "fuego" });
            cargarInfo(tipo);
        }

        private void fuego(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("fuego", new string[] { "tierra", "roca", "agua" },
                new string[] { "bicho", "acero", "fuego", "planta", "hielo", "hada" }
            , null, new string[] { "bicho", "acero", "planta", "hielo" });
            cargarInfo(tipo);
        }

        private void planta(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("planta", new string[] { "volador", "veneno", "bicho", "fuego", "hielo" },
             new string[] { "tierra", "agua", "planta", "electrico" }, null, new string[] { "tierra", "roca", "agua" });
            cargarInfo(tipo);
        }

        private void electrico(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("electrico", new string[] { "tierra" }, new string[] { "volador", "acero", "planta" },
                null, new string[] { "volador", "agua" });
            cargarInfo(tipo);
        }

        private void tierra(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("tierra", new string[] { "agua", "planta", "hielo" }, new string[] { "veneno", "roca" },
                 new string[] { "electrico" }, new string[] { "veneno", "roca", "acero", "fuego", "electrico" });
            cargarInfo(tipo);
        }

        private void roca(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("roca", new string[] { "lucha", "tierra", "agua", "acero", "planta" },
                 new string[] { "normal", "volador", "veneno", "fuego" }, null, new string[] { "volador", "fuego", "bicho", "hielo" });
            cargarInfo(tipo);
        }

        private void acero(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("acero", new string[] { "lucha", "tierra", "fuego," },
                new string[] { "normal", "volador", "roca", "bicho", "acero", "planta", "psiquico", "hielo", "dragon", "hada" },
                 new string[] { "veneno" }, new string[] { "roca", "hielo", "hada" });
            cargarInfo(tipo);
        }

        private void bicho(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("bicho", new string[] { "volador", "roca", "fuego" }, new string[] { "lucha", "tierra", "planta" },
                null, new string[] { "planta", "psiquico", "siniestro" });
            cargarInfo(tipo);
        }

        private void volador(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("volador", new string[] { "roca", "electrico", "hielo" }, new string[] { "lucha", "bicho", "planta" },
                 new string[] { "tierra" }, new string[] { "lucha", "bicho", "planta" });
            cargarInfo(tipo);
        }

        private void veneno(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("veneno", new string[] { "roca", "psiquico" }, new string[] { "lucha", "veneno", "bicho", "planta", "hada" },
                null, new string[] { "planta", "hada" });
            cargarInfo(tipo);
        }

        private void hada(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("hada", new string[] { "veneno", "acero" }, new string[] { "lucha", "bicho", "siniestro" },
                 new string[] { "dragon" }, new string[] { "lucha", "dragon", "siniestro" });
            cargarInfo(tipo);
        }

        private void dragon(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("dragon", new string[] { "dragon", "hielo", "hada" }, new string[] { "fuego", "agua", "planta", "electrico" },
                null, new string[] { "dragon" });
            cargarInfo(tipo);
        }

        private void psiquico(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("psiquico", new string[] { "bicho", "fantasma", "siniestro" }, new string[] { "lucha", "psiquico" },
                null, new string[] { "lucha", "veneno" });
            cargarInfo(tipo);
        }

        private void fantasma(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("fantasma", new string[] { "fantasma", "siniestro" }, new string[] { "siniestro" },
                new string[] { "normal" }, new string[] { "fantasma", "psiquico" });
            cargarInfo(tipo);
        }

        private void siniestro(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("siniestro", new string[] { "lucha", "bicho", "hada" }, new string[] { "fantasma", "siniestro" },
                 new string[] { "psiquico" }, new string[] { "fantasma", "psiquico" });
            cargarInfo(tipo);
        }

        private void hielo(object sender, EventArgs e)
        {
            tipo = new TipoPokemon("hielo", new string[] { "lucha", "roca", "acero", "fuego" },
                new string[] { "volador", "tierra", "planta", "dragon" }, null, new string[] { "volador", "tierra", "planta", "dragon" });
            cargarInfo(tipo);
        }

        private void cargarInfo(TipoPokemon tipo)
        {
            label1.Text = "Tipo: \n" + tipo.nombretipo;
            label2.Text = "Debil Contra:\n";
            if (tipo.debilidadesx2 != null)
            {
                for (int i = 0; i < tipo.debilidadesx2.Length; i++) { label2.Text += "- " + tipo.debilidadesx2[i] + "\n"; }
            }
            else
            {
                label2.Text += "no tiene";
            }

            label3.Text = "Resistente a:\n";
            if (tipo.resistencias != null)
            {
                for (int i = 0; i < tipo.resistencias.Length; i++) { label3.Text += "- " + tipo.resistencias[i] + "\n"; }
            }
            else { label3.Text += "no tiene"; }

            label4.Text = "Inmune a:\n";
            if(tipo.inmunidades != null)
            {
                for (int i = 0; i < tipo.inmunidades.Length; i++) { label4.Text += "- " + tipo.inmunidades[i] + "\n"; }
            }else { label4.Text += "no tiene"; }

            label5.Text = "Efectivo Contra:\n";
            if(tipo.efectivosx2 != null)
            {
                for (int i = 0; i < tipo.efectivosx2.Length; i++) { label5.Text += "- " + tipo.efectivosx2[i] + "\n"; }
            }
            else { label5.Text += "no tiene"; }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
