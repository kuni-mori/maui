using MySqlConnector;

namespace MauiMySQL;

public partial class ConnectPage : ContentPage
{
	public ConnectPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		MySqlConnection cn = new MySqlConnection();
		cn.ConnectionString = "server=localhost;user id=wpuser;database=wpdb;password=wppass";
		
		try
		{
            cn.Open();
            DisplayAlert(".NET MAUI", "MySQLに接続できました", "OK");
            cn.Close();
        } catch
		{
            DisplayAlert(".NET MAUI", "MySQLに接続できませんでした", "OK");
        }
    }
}