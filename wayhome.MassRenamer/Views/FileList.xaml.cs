using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace wayhome.MassRenamer.Views
{
  public partial class FileList : UserControl
  {
    private double _fileListColumnWidth = 100;

    public FileList()
    {
      InitializeComponent();
      //var files = new[] { "Test1.jpg", "Test2.png", "Test3.doc", "Test1.jpg", "Test2.png", "Test3.doc", "Test1.jpg", "Test2.png", "Test3.doc", "Test1.jpg", "Test2.png", "Test3.doc" };
      //ListViewFileNames.ItemsSource = files;
    }

    private void Expander_Collapsed(object sender, RoutedEventArgs e)
    {
      FileListColumn.Width = new GridLength(0);
      FileListSplitter.Width = new GridLength(0);
    }

    private void Expander_Expanded(object sender, RoutedEventArgs e)
    {
      FileListColumn.Width = new GridLength(_fileListColumnWidth);
      FileListSplitter.Width = new GridLength(5);
    }

    private void GridSplitter_DragCompleted(object sender, DragCompletedEventArgs e)
    {
      if (FileListColumn.Width.Value == 0)
        FileListExpander.IsExpanded = false;
      else
        _fileListColumnWidth = FileListColumn.Width.Value;
    }

    private void GridSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
      => FileListExpander.IsExpanded = false;

    public static readonly DependencyProperty FileNameSourceProperty =
      DependencyProperty.Register(nameof(FileNameSource),
        typeof(IDictionary<FileInfo, string>), typeof(FileList), 
        new PropertyMetadata(new Dictionary<FileInfo, string>()));

    public IDictionary<FileInfo, string> FileNameSource
    {
      get => GetValue(FileNameSourceProperty) as IDictionary<FileInfo, string>;
      set => SetValue(FileNameSourceProperty, value);
    }
  }
}