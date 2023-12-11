using DefApiBackEnd.Infrastructure.Data;
using System.Windows;

namespace DefApiBackEnd
{
    public partial class MainWindow : Window
    {
        private DbController _dbController;


        public MainWindow()
        {
            InitializeComponent();
            _dbController = new DbController();
        }
    }
}