using System.Windows;

namespace wayhome.MassRenamer.Views
{
  public partial class CollapsableFileTree
  {
    public static readonly RoutedEvent ExpandedEvent = EventManager.RegisterRoutedEvent("Expanded",
      RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CollapsableFileTree));

    public static readonly RoutedEvent CollapsedEvent = EventManager.RegisterRoutedEvent("Collapsed",
      RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CollapsableFileTree));

    public CollapsableFileTree() =>
      InitializeComponent();

    private void Expander_Expanded(object sender, RoutedEventArgs e) => RaiseExpandedEvent();

    private void Expander_Collapsed(object sender, RoutedEventArgs e) => RaiseCollapsedEvent();

    public event RoutedEventHandler Expanded
    {
      add => AddHandler(ExpandedEvent, value);
      remove => RemoveHandler(ExpandedEvent, value);
    }

    public event RoutedEventHandler Collapsed
    {
      add => AddHandler(CollapsedEvent, value);
      remove => RemoveHandler(CollapsedEvent, value);
    }

    private void RaiseExpandedEvent() =>
      RaiseEvent(new RoutedEventArgs(ExpandedEvent));

    private void RaiseCollapsedEvent() =>
      RaiseEvent(new RoutedEventArgs(CollapsedEvent));
  }
}