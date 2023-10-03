namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            List<fruit> list = new List<fruit>()
            {
                new fruit() { Name="Apple", Image="apple.png"},
                new fruit() { Name = "Orange", Image = "orange.png" },
                new fruit() { Name = "Banana", Image = "banana.png" },
                new fruit() { Name = "Kiwi", Image = "kiwi.png" },
                new fruit() { Name = "Strawberry", Image = "strawberry.png" },
                new fruit() { Name = "Pineapple", Image = "pineapple.png" },
                new fruit() { Name = "Watermelon", Image = "watermelon.png" },
                new fruit() { Name = "Grapes", Image = "grapes.png" }
            };
            InitializeComponent();
            FruitListView_ItemSelected.ItemSourse = list;
            
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                return;
            var selectedItem = e.SelectedItem as fruit;
            DisplayAlert("Selected", selectedItem.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}