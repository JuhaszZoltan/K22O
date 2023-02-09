namespace BukkMaraton2019GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += OnMainFormLoad;
            szamolButton.Click += OnSzamolButtonClick;
        }

        private void OnSzamolButtonClick(object? sender, EventArgs e)
        {
            double t = TimeSpan.Parse(idoTextBox.Text).TotalHours;
            int s = tavComboBox.SelectedIndex switch
            {
                0 => 16,
                1 => 38,
                2 => 54,
                3 => 57,
                4 => 94,
                _ => throw new Exception("hib�s beviteli adat"),
            };

            kmphLabel.Text = $"{s / t, 0:0.00} km/h";
            mpsLabel.Text = $"{s / t / 3.6, 0:0.00} m/s";
        }

        private void OnMainFormLoad(object? sender, EventArgs e)
        {
            idoTextBox.Text = "01:00:00";
            tavComboBox.Items.AddRange(
                new string[]
                {
                    "Mini - 16km",
                    "R�vid - 38km",
                    "Pedelec - 54km",
                    "K�z�p - 57km",
                    "Hossz� - 94km"
                });
            tavComboBox.SelectedIndex = 3;
        }
    }
}