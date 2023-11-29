namespace prack_7
{
    public partial class MainPage : ContentPage
    {
        string pa;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void AddPhone_Clicked(object sender, EventArgs e)
        //{
        //    //добавляем телефоны в секцию телефоны
        //    EntryCell p = new EntryCell();
        //    p.Placeholder = "Введите телефон";
        //    p.Keyboard = Keyboard.Numeric;
        //    phone.Add(p);
        //}

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void dateBirth_DateSelected(object sender, DateChangedEventArgs e)
        {
            int ag = DateTime.Now.Year - dateBirth.Date.Year;
            if (DateTime.Now.Month < dateBirth.Date.Month || DateTime.Now.Month == dateBirth.Date.Month && DateTime.Now.Day < dateBirth.Date.Day)

            {
                ag--;
                age.Text = "Возраст - " + ag.ToString();
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync();
            Ffff.Source = ImageSource.FromFile(result.FullPath);
            pa = result.FullPath.ToString();
        }

        private void Sohr(object sender, EventArgs e)
        {
            Preferences.Default.Set("fio", fio.Text);
            Preferences.Default.Set("name", name.Text);
            Preferences.Default.Set("lastName", lastName.Text);
            Preferences.Default.Set("O", O.Text);
            Preferences.Default.Set("dateBirth", dateBirth.Date);
            Preferences.Default.Set("age", dateBirth.Date);
            Preferences.Default.Set("Pol", Pol.SelectedIndex);
            Preferences.Default.Set("Ffff", pa);
           
            Preferences.Default.Set("Star", Star.SelectedIndex);
        }

        private void PolSohr(object sender, EventArgs e)
        {
            fio.Text = Preferences.Default.Get("fio", "");
            name.Text = Preferences.Default.Get("name", "");
            lastName.Text = Preferences.Default.Get("lastName", "");
            O.Text = Preferences.Default.Get("O", "");
            dateBirth.Date = Preferences.Default.Get("dateBirth", DateTime.Now);
            dateBirth.Date = Preferences.Default.Get("age", DateTime.Now);
            Pol.SelectedIndex = Convert.ToInt32(Preferences.Default.Get("Pol", -1));
            Ffff.Source = ImageSource.FromFile(Preferences.Default.Get("Ffff", ""));
            Star.SelectedIndex = Convert.ToInt32(Preferences.Default.Get("Star", -1));
        }
    }
}