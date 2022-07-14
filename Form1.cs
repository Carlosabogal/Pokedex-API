using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPokedex
{
    public partial class Form1 : Form
    {
        List<string> listaImages = new List<string>();
        int idImagen = 0;
        int txtNameId;
        int i = 4;

        int IdPokemon = 1;
        public Form1()
        {
            InitializeComponent();

        }

        private async Task Leer(int _valor)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + _valor.ToString());
            limpiar();
            try
            {
                var PokemonInfo = Pokedex.FromJson(result);
               


                CargarTodo(PokemonInfo);
                CargarMovimiento(PokemonInfo);
                CargarEspecificaciones(PokemonInfo);
                CargarImage(PokemonInfo);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Pokemon no encontrado");
            }

        }

        public void limpiar()
        {
            listaImages = new List<string>(); 

        }
        private void TiposVacio(Pokedex pokemon)
        {
            for(int i=0; i < pokemon.Types.Length; i++){

                switch (i)
                {
                    case 0:
                        lblTipo.Text = pokemon.Types[0].Type.Name;
                        lblTipos2.Text="";
                        CambiarColor(pokemon.Types[0].Type.Name.ToUpper());
                      
                        break;
                    case 1:
                        lblTipo.Text = pokemon.Types[0].Type.Name;
                        lblTipos2.Text = pokemon.Types[1].Type.Name;
                        CambiarColor(pokemon.Types[0].Type.Name.ToUpper());
                        CambiarColor2(pokemon.Types[1].Type.Name.ToUpper());
                        break;
                }
               

            }
        }
        private void CargarTodo(Pokedex pokemon)
        {
            TiposVacio(pokemon);
            CargarNombre(pokemon.Name.ToUpper());
            CargarNumero(pokemon.Id.ToString());
            VisibilidadLabels(true);
          
        }
        private void CargarEspecificaciones(Pokedex pokemon)
        {
            lblAltura.Text = (pokemon.Weight / 10).ToString();
            lblPeso.Text = (pokemon.Height*10).ToString();
            lblLife.Text = pokemon.Stats[0].BaseStat.ToString();

            for (int i = 0; i < 4; i++)
            {

                listBox1.Items.Add(pokemon.Stats[i].StatStat.Name.ToUpper()+" : " + pokemon.Stats[i].BaseStat.ToString());
            }

        }
        private void CambiarColor(string _tipo)
        {
            
            string tipo = _tipo;

            switch (tipo)
            {
                case "ELECTRIC":

                    lblAltura.BackColor = Color.Yellow;
                    lblPeso.BackColor = Color.Yellow;
                    lblLife.BackColor = Color.Yellow;
                    lblTipo.BackColor = Color.Yellow;
                    lblTipo.Update();
                    break;
                case "POISON":
                    lblAltura.BackColor = Color.DarkViolet;
                    lblPeso.BackColor = Color.DarkViolet;
                    lblLife.BackColor = Color.DarkViolet;
                    lblTipo.BackColor = Color.DarkViolet;
                    lblTipo.Update();
                    break;
     
                case "GRASS":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#26c94f");
                    lblPeso.BackColor = ColorTranslator.FromHtml("#26c94f");
                    lblLife.BackColor = ColorTranslator.FromHtml("#26c94f");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#26c94f");
                    lblTipo.Update();
                    break;
                case "FIRE":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#fb4b5a"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#fb4b5a");
                    lblLife.BackColor = ColorTranslator.FromHtml("#fb4b5a");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#fb4b5a");
                    lblTipo.Update();
                    break;
                case "FLYING":
             
                    lblAltura.BackColor = ColorTranslator.FromHtml("#92b1c6"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#92b1c6");
                    lblLife.BackColor = ColorTranslator.FromHtml("#92b1c6");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#92b1c6");
                    lblTipo.Update();
                    break;
                case "WATER":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#85a7fb"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#85a7fb");
                    lblLife.BackColor = ColorTranslator.FromHtml("#85a7fb");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#85a7fb");
                    lblTipo.Update();
                    break;
                case "BUG":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#3b984f"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#3b984f");
                    lblLife.BackColor = ColorTranslator.FromHtml("#3b984f");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#3b984f");
                    lblTipo.Update();
                    break;
                case "DARK":
                
                    lblAltura.BackColor = ColorTranslator.FromHtml("#595979"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#595979");
                    lblLife.BackColor = ColorTranslator.FromHtml("#595979");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#595979");
                    lblTipo.Update();

                    break;
                case "DRAGON":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#60c9d8"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#60c9d8");
                    lblLife.BackColor = ColorTranslator.FromHtml("#60c9d8");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#60c9d8");
                    lblTipo.Update();

                    break;
                case "FAIRY":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#ea1268"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#ea1268");
                    lblLife.BackColor = ColorTranslator.FromHtml("#ea1268");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#ea1268");
                    lblTipo.Update();

                    break;
                case "FIGHTING":
          
                    lblAltura.BackColor = ColorTranslator.FromHtml("#ee6137"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblLife.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblTipo.Update();

                    break;
                case "ICE":
                    lblAltura.BackColor = ColorTranslator.FromHtml("#86d2f5"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#86d2f5");
                    lblLife.BackColor = ColorTranslator.FromHtml("#86d2f5");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#86d2f5");
                    lblTipo.Update();
                    break;
                case "GROUND":
                  

                    lblAltura.BackColor = ColorTranslator.FromHtml("#6d481e"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#6d481e");
                    lblLife.BackColor = ColorTranslator.FromHtml("#6d481e");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#6d481e");
                    lblTipo.Update();
                    break;
                case "STEEL":
                  
                    lblAltura.BackColor = ColorTranslator.FromHtml("#40bd93"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#40bd93");
                    lblLife.BackColor = ColorTranslator.FromHtml("#40bd93");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#40bd93");
                    lblTipo.Update();
                    break;
                case "ROCK":
                   

                    lblAltura.BackColor = ColorTranslator.FromHtml("#8a3d21"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#8a3d21");
                    lblLife.BackColor = ColorTranslator.FromHtml("#8a3d21");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#8a3d21");
                    lblTipo.Update();
                    break;
                case "GHOST":
                    

                    lblAltura.BackColor = ColorTranslator.FromHtml("#ee6137"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblLife.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblTipo.Update();
                    break;
                case "PSYCHIC":
                 
                    lblAltura.BackColor = ColorTranslator.FromHtml("#f71b90"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#f71b90");
                    lblLife.BackColor = ColorTranslator.FromHtml("#f71b90");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#f71b90");
                    lblTipo.Update();
                    break;
                case "NORMAL":
                  
                    lblAltura.BackColor = ColorTranslator.FromHtml("#74505a"); ;
                    lblPeso.BackColor = ColorTranslator.FromHtml("#74505a");
                    lblLife.BackColor = ColorTranslator.FromHtml("#74505a");
                    lblTipo.BackColor = ColorTranslator.FromHtml("#74505a");
                    lblTipo.Update();
                    break;
            }

            
        }
        private void CambiarColor2(string _tipo)
        {

            string tipo = _tipo;

            switch (tipo)
            {
                case "ELECTRIC":

                  
                    lblTipos2.BackColor = Color.Yellow;
                    lblTipos2.Update(); 
                    break;
                case "POISON":
                  
                    lblTipos2.BackColor = Color.DarkViolet;
                    lblTipos2.Update();
                    break;

                case "GRASS":
                   
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#26c94f");
                    lblTipos2.Update();
                    break;
                case "FIRE":
                 
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#fb4b5a");
                    lblTipos2.Update();
                    break;
                case "FLYING":

                    
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#92b1c6");
                    lblTipos2.Update();
                    break;
                case "WATER":
                   
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#85a7fb");
                    lblTipos2.Update();
                    break;
                case "BUG":
                   
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#3b984f");
                    lblTipos2.Update();
                    break;
                case "DARK":

               
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#595979");
                    lblTipos2.Update();
                    break;
                case "DRAGON":
                    
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#60c9d8");
                    lblTipos2.Update();
                    break;
                case "FAIRY":
                
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#ea1268");
                    lblTipos2.Update();
                    break;
                case "FIGHTING":

                  
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#ee6137");
                    lblTipos2.Update();
                    break;
                case "ICE":
                   
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#86d2f5");
                    lblTipos2.Update();
                    break;
                case "GROUND":


                   
                    lblTipos2.BackColor = ColorTranslator.FromHtml("#6d481e");
                    break;
                case "STEEL":

                    lblTipos2.BackColor = ColorTranslator.FromHtml("#40bd93");
                    break;
                case "ROCK":

                    lblTipos2.BackColor = ColorTranslator.FromHtml("#8a3d21");
                    break;
                case "GHOST":

                    lblTipos2.BackColor = ColorTranslator.FromHtml("#ee6137");
                    break;
                case "PSYCHIC":

                    lblTipos2.BackColor = ColorTranslator.FromHtml("#f71b90");
                    break;
                case "NORMAL":

                    lblTipos2.BackColor = ColorTranslator.FromHtml("#74505a");
                    break;
            }


        }
        private void CargarImage(Pokedex pokemon)
        {
            listaImages.Add(pokemon.Sprites.FrontDefault.ToString());
            listaImages.Add(pokemon.Sprites.BackDefault.ToString());
            listaImages.Add(pokemon.Sprites.FrontShiny.ToString());
            listaImages.Add(pokemon.Sprites.BackShiny.ToString());
            pcPokemonImage.Load(listaImages[idImagen]);

            pcPokemonImage.Update();


        }

        public void CargarMovimiento(Pokedex pokemon)
        {
            for (int i = 0; i < 4; i++)
            {
                cbBTipos.Items.Add(pokemon.Moves[i].MoveMove.Name.ToString().ToUpper());
            }

        }
        private void CargarNombre(string _nombre)
        {
            lblName.Text = _nombre;
           
        }
        private void CargarNumero(string _numero)
        {
            lblNumero.Text = _numero;

        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnIngresarPokemon_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNamePokemon.Text))
            {
                
                txtNameId = int.Parse(txtNamePokemon.Text);
                await Leer(txtNameId);
            }
        }
        private void VisibilidadLabels(bool _visible)
        {
            lblAltura.Visible = _visible;
            lblLife.Visible = _visible;
            lblName.Visible = _visible;
            lblNumero.Visible = _visible;
            lblPeso.Visible = _visible;
            lblTipo.Visible = _visible;
            lblTipos2.Visible = _visible;
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void cbBTipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listaImages.Count > 0)
            {
                if (idImagen + 1 >= listaImages.Count)
                {
                    idImagen = 0;
                }
                else
                {
                    idImagen++;
                }

                pcPokemonImage.Load(listaImages[idImagen]);
                pcPokemonImage.Update();
            }
        }

        private void PcPokemonImage_Click(object sender, EventArgs e)
        {

        }

        private void lblTipos2_Click(object sender, EventArgs e)
        {

        }

        private void txtNamePokemon_TextChanged(object sender, EventArgs e)
        {

        }

        private async void lblAnterior_Click(object sender, EventArgs e)
        {

            if (IdPokemon - 1 <= 0)
            {
                IdPokemon = 898;
            }
            else
            {
                IdPokemon--;
            }
            txtNameId = int.Parse(IdPokemon.ToString());
            await Leer(txtNameId);
            lblNumero.Text = IdPokemon.ToString();
        }

        private async void lblSiguiente_Click(object sender, EventArgs e)
        {
          
        }

        private async void lableSiguiente_Click(object sender, EventArgs e)
        {
            if (IdPokemon + 1 >= 899)
            {
                IdPokemon = 1;
            }
            else
            {
                IdPokemon++;
            }
            await Leer(IdPokemon);
            lblNumero.Text = IdPokemon.ToString();
        }
    }
}
