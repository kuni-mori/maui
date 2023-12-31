using Microsoft.EntityFrameworkCore;

namespace MauiSQLite;

public partial class FisheriesListPage : ContentPage
{
	public FisheriesListPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        // SQLite©ηΗέέ
        var context = new FisheriesDbContext();

		var q = from oroshi in context.T΅
				join subject in context.TiΌ on oroshi.iΌId equals subject.Id
				join market in context.Tsκ on oroshi.sκId equals market.Id
				join sale in context.TΜϋ@ on oroshi.Μϋ@Id equals sale.Id
				orderby oroshi.ϊt descending
				select new T΅()
				{
					Id = oroshi.Id,
					iΌId = oroshi.iΌId,
					Μϋ@Id = oroshi.Μϋ@Id,
					sκId = oroshi.sκId,
					΅ = oroshi.΅,
					ϊt = oroshi.ϊt,
					iΌ = subject,
					sκ = market,
					Μϋ@ = sale,
				};
        var items = await q.Take(100).ToListAsync();
        coll.ItemsSource = items;

    }
}