using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Aula03_Pokedex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PokemonList : Page
    {
        private List<Pokemon> elements;
        public PokemonList()
        {
            this.InitializeComponent();
            elements = new List<Pokemon>();
            elements.Add(new Pokemon() { Name = "Abra", ImagePath = "images/abra.png" ,Tipo="PSYCHIC",HP=50,Ataque=110,Defesa=76});
            elements.Add(new Pokemon() { Name = "Alakazam", ImagePath = "images/alakazam.png", Tipo = "PSYCHIC", HP = 50, Ataque = 110, Defesa = 76 });
            elements.Add(new Pokemon() { Name = "Blastoise", ImagePath = "images/blastoise.png", Tipo = "WATER", HP = 158, Ataque = 186, Defesa = 222 });
            elements.Add(new Pokemon() { Name = "Bulbasaur", ImagePath = "images/Bulbasaur.png", Tipo = "GRASS/POISON", HP = 90, Ataque = 126, Defesa = 126 });
            elements.Add(new Pokemon() { Name = "Charizard", ImagePath = "images/charizard.png", Tipo = "FIRE/FLYING", HP = 156, Ataque = 212, Defesa = 182 });
            elements.Add(new Pokemon() { Name = "Charmander", ImagePath = "images/charmander.png", Tipo = "FIRE", HP = 78, Ataque = 128, Defesa = 108 });
            elements.Add(new Pokemon() { Name = "Charmeleon", ImagePath = "images/charmeleon.png", Tipo = "FIRE", HP = 116, Ataque = 160, Defesa = 140 });
            elements.Add(new Pokemon() { Name = "Dragonair", ImagePath = "images/Dragonair.png", Tipo = "DRAGON", HP = 122, Ataque = 170, Defesa = 152 });
            elements.Add(new Pokemon() { Name = "Dragonite", ImagePath = "images/dragonite.png", Tipo = "DRAGON/FLYING", HP = 182, Ataque = 250, Defesa = 212 });
            elements.Add(new Pokemon() { Name = "Dratini", ImagePath = "images/dratini.png", Tipo = "DRAGON", HP = 82, Ataque = 128, Defesa = 110 });
            lstPokemon.DataContext = elements;
        }


        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPokemon.SelectedIndex > -10)
            {
                Frame.Navigate(typeof(PokemonDetails), elements[lstPokemon.SelectedIndex]);
            }

        }
    }
}
