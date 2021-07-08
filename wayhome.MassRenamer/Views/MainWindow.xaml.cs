using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls.Primitives;
using wayhome.MassRenamer.ViewModel;

namespace wayhome.MassRenamer.Views
{
  public partial class MainWindow
  {
    private double _fileTreeColumnWidth = 250;

    public MainWindow()
    {
      InitializeComponent();
      //var viewModel = new RenameViewModel();
      //DataContext = viewModel;
    }

    private void CollapsableFileTree_OnExpanded(object sender, RoutedEventArgs e)
    {
      FileTreeColumn.Width = new GridLength(_fileTreeColumnWidth);
      FileTreeSplitter.Width = new GridLength(5);
    }

    private void CollapsableFileTree_OnCollapsed(object sender, RoutedEventArgs e)
    {
      FileTreeColumn.Width = new GridLength(23);
      FileTreeSplitter.Width = new GridLength(0);
    }

    private void GridSplitter_DragCompleted(object sender, DragCompletedEventArgs e) =>
      _fileTreeColumnWidth = FileTreeColumn.Width.Value;
  }
}