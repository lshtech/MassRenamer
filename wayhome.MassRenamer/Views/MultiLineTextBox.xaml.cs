using System.Windows.Controls;
using System.Windows.Documents;

namespace wayhome.MassRenamer.Views
{
  public partial class MultiLineTextBox
  {
    //public static DependencyProperty FileNameSourceProperty =
    //  DependencyProperty.Register(nameof(FileNameSource),
    //    typeof(IEnumerable<string>), typeof(MultiLineTextBox));

    public MultiLineTextBox()
    {
      InitializeComponent();
      //var files = new []{"Test1.jpg", "Test2.png", "Test3.doc", "Test1.jpg", "Test2.png", "Test3.doc" , "Test1.jpg", "Test2.png", "Test3.doc" , "Test1.jpg", "Test2.png", "Test3.doc" };
      //var doc = new FlowDocument();
      //foreach (var file in files)
      //{
      //  var pg = new Paragraph();
      //  pg.Inlines.Add(file);
      //  doc.Blocks.Add(pg);
      //}

      //tbFileNames.Document = doc;
    }

    //public IEnumerable<string> FileNameSource
    //{
    //  get => GetValue(FileNameSourceProperty) as IEnumerable<string>;
    //  set => SetValue(FileNameSourceProperty, value);
    //}

    private void tbFileNames_TextChanged(object sender, TextChangedEventArgs e)
    {
      var rtb = sender as RichTextBox;
      new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).ClearAllProperties();
      
    }
  }
}