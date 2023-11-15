namespace prack_7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddPhone_Clicked(object sender, EventArgs e)
        {
            //добавляем телефоны в секцию телефоны
            EntryCell p = new EntryCell();
            p.Placeholder = "Введите телефон";
            p.Keyboard = Keyboard.Numeric;
            phone.Add(p);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void dateBirth_DateSelected(object sender, DateChangedEventArgs e)
        {
            int ag = DateTime.Now.Year - dateBirth.Date.Year;
            if (DateTime.Now.Month < dateBirth.Date.Month || DateTime.Now.Month == dateBirth.Date.Month && DateTime.Now.Day < dateBirth.Date.Day)
                   
            {
                ag--;
                age.Text =  "Возраст - " + ag.ToString ();
            }
        }
    }
}