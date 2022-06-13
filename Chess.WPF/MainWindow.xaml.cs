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
        private readonly Brush? _defaultWhiteCellBrush = new BrushConverter().ConvertFrom("#ecc49f") as Brush;
        private readonly Brush? _defaultBlackCellBrush = new BrushConverter().ConvertFrom("#be6140") as Brush;
        private readonly Brush? _validMoveCellBrush = new BrushConverter().ConvertFrom("#80cd51") as Brush;
        private readonly Brush? _invalidMoveCellBrush = new BrushConverter().ConvertFrom("#e34132") as Brush;

        private string? _selectedPieceName;
        private Piece? _movingPiece;
        private readonly List<Piece> _boardPieces = new();
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
                _boardPieces.Add(PieceFactory.ReleasePiece(_selectedPieceName, pos));
                cell.Content = _selectedPieceName;
                _inPieceAddingMode = false;
            }
            else if (_inPieceMovingMode)
            {

            }
            else
            {
                _movingPiece = _boardPieces.Find(piece => piece.GetPos() == cell.Tag.ToString());
                if (_movingPiece != null)
                    _inPieceMovingMode = true;
            }
        }

        private void Cell_MouseOver(object sender, RoutedEventArgs e)
        {
            if (_inPieceMovingMode)
            {
                Button cell = (Button)sender;
                string? destinationPos = cell.Tag.ToString();
                string? piecePos = _movingPiece?.GetPos();
                if (_movingPiece.IsRightMove(piecePos[0], int.Parse(piecePos[1].ToString()),
                    destinationPos[0], int.Parse(destinationPos[1].ToString())))
                {
                    cell.Background = _validMoveCellBrush;
                }
                else
                {
                    cell.Background = _invalidMoveCellBrush;
                }
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
