XCommand
========
XCommand and WPFXCommand are Windows 8 Store and Windows desktop application class libraries that provides Command and CommandParameter binding for most of the routed events exposes on UIElement level. Here are the list of current supported routed events for Command/CommandParameter binding as below:

Windows 8 Store app                                                                                               
---------------------                                                                                                 
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

WPF Windows Desktop application                                                                                       
--------------------------------                                                                                      
-> DragEnter                                                                                                        
-> DragLeave                                                                                                          
-> DragOver                                                                                                   
-> Drop                                                                                                                 
-> PreviewDragEnter                                                                                                     
-> PreviewDragLeave                                                                                                     
-> PreviewDragOver                                                                                                   
-> PreviewDrop                                                                                                          
-> KeyDown                                                                                                              
-> KeyUp                                                                                                              
-> PreviewKeyDown                                                                                                       
-> PreviewKeyUp                                                                                                         
-> MouseMove                                                                                                            
-> MouseEnter                                                                                                      
-> MouseLeave                                                                                                           
-> MouseLeftButtonDown                                                                                                  
-> MouseLeftButtonUp                                                                                                   
-> MouseDown                                                                                                          
-> MouseRightButtonDown                                                                                                 
-> MouseRightButtonUp                                                                                                   
-> MouseUp                                                                                                              
-> MouseWheel                                                                                                          
-> PreviewMouseDown                                                                                                     
-> PreviewMouseLeftButtonDown                                                                                           
-> PreviewMouseLeftButtonUp                                                                                             
-> PreviewMouseMove                                                                                                   
-> PreviewMouseRightButtonDown                                                                                          
-> PreviewMouseRightButtonUp                                                                                            
-> PreviewMouseUp                                                                                                  
-> PreviewMouseWheel                                                                                                  


How to implement XCommand for Windows Desktop Application
Add WPFXCommand.dll as reference to your desire project.

Add the namespace on your xaml file as below:
xmlns:XCmd="clr-namespace:WPFXCommand;assembly=WPFXCommand"

Now, you can bind Command and CommandParameter to any available events on any UI element inherit from WPF UIElement as below:
XCmd:MouseMove.Command="{Binding GridPointerMovedCommand}"
XCmd:MouseMove.CommandParameter="{Binding ElementName=XTextBlock, Path=Text}"



How to implement XCommand for Windows 8 Store Application
Add XCommand.dll as reference to your desire project.

Add the namespace on your xaml file as below:
xmlns:XCmd="using:XCommand"

Now, you can bind Command and CommandParameter to any available events on any UI element inherit from WPF UIElement as below:
XCmd:PointerMoved.Command="{Binding GridPointerMovedCommand}" 
XCmd:PointerMoved.CommandParameter="{Binding ElementName=XTextBlock, Path=Text}"


These are valid for any windows 8 store and windows desktop WPF UI elements that inherit from UIElement.			

It is very simple to utilize these command behaviour on any UI element. And no need to remember any kind of naming	
convensiton here. For example PointerMoved has two properties that are Command and CommandParameter.		
Please find out the sample XTextApp for Windows 8 Store app and WPFXTextApp for WPF Windows desktop application that will demonstrate how to utilize XCommand. 		

Hope this will help you to get rid of event based code behind.	Enjoy, Keep coding :)	
