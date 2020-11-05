using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTac
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TacToe : ContentPage
	{
		Label[,] tic = new Label[3, 3];
		int stps, chck;
		string l;
		Label lbl;
		Button change, restart, own;
		public TacToe()
		{
			Grid();
			stps = 0;
			own.IsEnabled = true;
		}

		void Grid()
		{
			stps = 0;
			Grid grd = new Grid();
			for (int i = 0; i < 3; i++)
			{
				grd.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
			}
			for (int w = 0; w < 3; w++)
			{
				grd.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
			}
			//1BUTTON
			change = new Button();
			change.Text = "Случайный выбор игрока";
			grd.Children.Add(change,0,3);

			//2BUTTON
			restart = new Button();
			restart.Text = "Начать заново";
			grd.Children.Add(restart, 1, 3);
			
			//3BUTTON
			own = new Button();
			own.Text = "Выбрать первого игрока";
			grd.Children.Add(own, 2, 3);

			change.Clicked += Change_Clicked;
			restart.Clicked += Restart_Clicked;
			own.Clicked += Own_Clicked;

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					lbl = new Label
					{
						BackgroundColor = Color.FromRgb(191, 155, 178),
						FontSize = 100,
						Text = "",
						HorizontalTextAlignment = TextAlignment.Center,
						TextColor = Color.FromRgb(151, 135, 194),
						VerticalTextAlignment = TextAlignment.Center,
					};
					tic[i, j] = lbl;
					l = "X";
					var tap = new TapGestureRecognizer();
					tap.Tapped += Tap_Tapped;
					grd.Children.Add(lbl, i, j);
					lbl.GestureRecognizers.Add(tap);
				}
			}

			Content = grd;
		}
		//CLICKED START
		private void Tap_Tapped(object sender, EventArgs e)
		{/*
			Label label = sender as Label;
			if (chck % 2 == 0)
			{
				change.Text = "0";
				label.Text = l;
				chck++;
				stps++;
			}
			else if (chck % 2 != 0)
			{
				change.Text = "X";
				chck++;
				stps++;
				label.Text = "0";
			}
			if (check() == true)
			{
				DisplayAlert("Игра окончена!", "Ничья", "Новая игра");
				Grid();
				stps = 0;
			}

			else if (checkY() == true)
			{
				DisplayAlert("Игра окончена!", win, "Новая игра");
				Grid();
			}
			else if (checkX() == true)
			{
				DisplayAlert("Игра окончена!", win, "Новая игра");
				Grid();
			}
			else if (checkXY() == true)
			{
				DisplayAlert("Игра окончена!", win, "Новая игра");
				Grid();
			}*/
		}

		private void Own_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void Restart_Clicked(object sender, EventArgs e)
		{
			Grid();
			chck = 0;
			stps = 0;
		}

		private void Change_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		//CLICKED END
	}
}