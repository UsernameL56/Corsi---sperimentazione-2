using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corsi___sperimentazione
{
    public partial class Form1 : Form
    {
        //variabili
        public string[] array;
        public int indice;
        public Form1()
        {
            InitializeComponent();
            //inizializzare qua le variabili
            array = new string[100];
            indice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PulsanteAggiunta_Click(object sender, EventArgs e)
        {
            Aggiungi(array, ref indice, textBox1.Text);

        }

        private void PulsanteStampa_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            for (int i = 0; i < indice; i++)
            {
                listView1.Items.Add(array[i]);
            }

        }

        private void PulsanteCancellazione_Click(object sender, EventArgs e)
        {
            if (Ricerca(array, textBox1.Text) == true)
            {
                Cancellazione(array, textBox1.Text, ref indice);
                listView1.Clear();

                for (int i = 0; i < indice; i++)
                {
                    listView1.Items.Add(array[i]);
                }
            }
        }
        private void PulsanteModifica_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label2.Visible = true;
            if (Ricerca(array, textBox1.Text) == true)
            {
                listView1.Clear();
                Modifica(array, textBox1.Text, textBox2.Text);
                for (int i = 0; i < indice; i++)
                {
                    listView1.Items.Add(array[i]);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //funzione di servizio
        public void Aggiungi(string[] array, ref int indice, string nome)
        {
            array[indice] = nome;
            indice++;
        }

        public void Cancellazione(string[] a, string input, ref int indice)
        {
            //ciclo per trovare la posizione dell'elemento inserito
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == input)
                {
                    //ripeti il ciclo fino a che non sono stati spostati tutti i numeri
                    while (i < indice)
                    {
                        //nella posizione del numero che si vuole togliere, inserire il numero successivo fino a che non si raggiunge il massimo degli elementi inseriti
                        a[i] = a[i + 1];
                        i++;
                    }
                    //decremento dell'indice data la rimozione di uno degli elementi dell'array
                    indice = indice - 1;
                    //uscita dal ciclo
                    break;
                }
            }
        }

        static bool Ricerca(string[] array, string input)
        {
            bool trovato = true;
            //ciclo per controllare se l'elemento inserito è presente nell'array
            for (int i = 0; i < array.Length; i++)
            {
                //in base all'input, avremo un output true o false
                if (array[i] == input)
                {
                    trovato = true;
                    //una volta trovato il numero esci dal ciclo
                    break;
                }
                else
                    trovato = false;
            }
            //ritorno in base all'input
            return trovato;
        }

        static void Modifica(string[] array, string input, string correzione)
        {
            //ciclo per controllare tutto l'array
            for (int z = 0; z < array.Length; z++)
            {
                //arrivati alla posizione della parola errata modificarla con quella nuova inserita
                if (array[z] == input)
                {
                    array[z] = correzione;
                }
            }
        }


    }
}
