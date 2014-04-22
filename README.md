XCommand
========
XCommand is a windows 8 store app libarary that provides Command and CommandParameter binding on most of the routed events
exposes on UIElement level. Here are the list of current support routed events for Command/CommandParameter binding as below:

-> DoubleTapped
-> DragEnter
-> DragLeave
-> DragOver
-> Drop
-> Holding
-> KeyDown
-> KeyUp
-> PointerCanceled
-> PointerCaptureLost
-> PointerEntered
-> PointerExited
-> PointerMoved
-> PointerMoved
-> PointerPressed
-> PointerReleased
-> PointerWheelChanged
-> RightTapped
-> Tapped

These are valid for every windows 8 WPF UI elements that inherit from UIElement.
For example to utilize these routed event based Command and CommandParameter for Grid

xmlns:XCmd="using:XCommand"

<Grid Grid.Column="1" Background="{Binding BgColor, Mode=TwoWay}"
                  XCmd:PointerMoved.Command="{Binding GridPointerMovedCommand}" 
                  XCmd:PointerMoved.CommandParameter="{Binding ElementName=XTextBlock, Path=Text}"
                  XCmd:PointerPressed.Command="{Binding GridPointerPressedCommand}"
                  XCmd:PointerPressed.CommandParameter="{Binding ElementName=XTextBlock, Path=Text}"
                  >
</Grid>

It is very simple to utilize these command behaviour on any UI element. And no need to remember any kind of naming
convensiton here. For example PointerMoved has two properties that is Command and CommandParameter.
Please find out the sample XTextApp that will demonstrate how to utilize XCommand. 

Hope this will help you to get ride of code behind because of these events.
