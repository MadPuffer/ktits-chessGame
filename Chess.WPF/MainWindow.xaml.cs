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
        private readonly WPFMoveController _moveController = new WPFMoveController();

        private string? _selectedPieceName;
        private Piece<Button>? _movingPiece;
        private Button? _movingPieceCell;
        private readonly List<Piece<Button>> _boardPieces = new();
        private bool _inPieceAddingMode;
        private bool _inPieceMovingMode;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cell_OnClick(object sender, RoutedEventArgs e)
        {
            Button cell = (Button)sender;

            if (_inPieceAddingMode)
            {
                string? pos = cell.Tag.ToString();
                Piece<Button> piece = PieceFactory<Button>.ReleasePiece(_selectedPieceName, pos, cell, _moveController);
                _boardPieces.Add(piece);
                cell.Content = piece.Name;
                _inPieceAddingMode = false;
            }
            else if (_inPieceMovingMode)
            {
                _movingPiece?.Move(cell);
                _inPieceMovingMode = false;
            }
            else
            {
                _movingPiece = _boardPieces.Find(piece => piece.GetPos() == cell.Tag.ToString());
                _movingPieceCell = cell;
                if (_movingPiece != null)
                    _inPieceMovingMode = true;
            }
        }

        private void Cell_MouseOver(object sender, RoutedEventArgs e)
        {
            if (_inPieceMovingMode)
            {
                _moveController.ValidateCell(_movingPiece, (Button)sender);
            }
        }

        private void Cell_MouseLeave(object sender, RoutedEventArgs e)
        {
            _moveController.ClearCell((Button)sender);
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
