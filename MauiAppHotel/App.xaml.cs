
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 60.0
            },
             new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 90.0,
                ValorDiariaCrianca = 50.0
            },
              new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCrianca = 40.0
              },
              new Quarto()
            {
                Descricao = "Suite Comum", 
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 30.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
