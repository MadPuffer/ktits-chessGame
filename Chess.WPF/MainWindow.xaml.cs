using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chess.Core;

namespace Chess.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? _selectedPieceName;
        private List<Piece> _boardPieces = new();
        private bool _inPieceAddingMode;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChessPieceButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button cell = (Button)sender;
            if (_inPieceAddingMode)
            {
                string? pos = cell.Tag.ToString();
                _boardPieces.Add(PieceFactory.ReleasePiece(_selectedPieceName, pos));
                cell.Content = _selectedPieceName;
                _inPieceAddingMode = false;
            }
        }

        private void PieceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Label label = (Label)comboBox.SelectedItem;

            _selectedPieceName = label.Content.ToString();
        }

        private void btnAddPiece_Click(object sender, RoutedEventArgs e)
        {
            _inPieceAddingMode = true;
        }
    }

}
