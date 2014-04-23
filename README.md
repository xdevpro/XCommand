XCommand
========
XCommand and WPFXCommand are Windows 8 Store and Windows desktop application libararies that provides Command and CommandParameter binding on most of the routed events exposes on UIElement level. Here are the list of current supported routed events for Command/CommandParameter binding as below:

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

These are valid for every windows 8 store and windows desktop WPF UI elements that inherit from UIElement.			
For example to utilize these routed event based Command and CommandParameter for Grid			

xmlns:XCmd="using:XCommand"

XCmd:PointerMoved.Command="{Binding GridPointerMovedCommand}" 				
XCmd:PointerMoved.CommandParameter="{Binding ElementName=XTextBlock, Path=Text}"		

It is very simple to utilize these command behaviour on any UI element. And no need to remember any kind of naming	
convensiton here. For example PointerMoved has two properties that is Command and CommandParameter.		
Please find out the sample XTextApp for Windows 8 Store app and WPFXTextApp for WPF Windows desktop application that will demonstrate how to utilize XCommand. 		

Hope this will help you to get ride of event based code behind.	Enjoy, Keep coding :)	
