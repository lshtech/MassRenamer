using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using wayhome.MassRenamer.Annotations;

namespace wayhome.MassRenamer.ViewModel
{
  public sealed class RenameViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public IDictionary<FileInfo, string> FileListDict { get; set; }

    public RenameViewModel()
    {
      FileListDict = new Dictionary<FileInfo, string>();
      FileListDict.Add(new FileInfo("c:\\tmuninst.ini"), "tmuninst.ini");
    }
  }
}
