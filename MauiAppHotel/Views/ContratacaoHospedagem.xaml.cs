namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp; 



	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.Lista_quartos;

		dtpck_Checkin.MinimumDate = DateTime.Now;
		dtpck_Checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 2, DateTime.Now.Day); 

		dtpck_Checkout.MinimumDate = dtpck_Checkin.Date.AddDays(1);
		dtpck_Checkout.MaximumDate = dtpck_Checkin.Date.AddMonths(6); 

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new HospedagemContratada()); 
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok!");
		}
	}

    private void dtpck_Checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_Checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_Checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}

