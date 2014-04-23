//*********************************************************
//
// Copyright XdevPro, Author: [Rukesh Shrestha]. All rights reserved.
// This code can be utilize freely under the name of author.
//
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFXCommand
{
    public class DragEnter
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.DragEnterEvent), "Command", typeof(DragEnter));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(DragEnter));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class DragLeave
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.DragLeaveEvent), "Command", typeof(DragLeave));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(DragLeave));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class DragOver
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.DragOverEvent), "Command", typeof(DragOver));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(DragOver));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class Drop
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.DropEvent), "Command", typeof(Drop));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(Drop));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewDragEnter
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.PreviewDragEnterEvent), "Command", typeof(PreviewDragEnter));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewDragEnter));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewDragLeave
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.PreviewDragLeaveEvent), "Command", typeof(PreviewDragLeave));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewDragLeave));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewDragOver
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.PreviewDragOverEvent), "Command", typeof(PreviewDragOver));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewDragOver));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewDrop
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DragEventCommandBehaviour(UIElement.PreviewDropEvent), "Command", typeof(PreviewDrop));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewDrop));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class KeyDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new KeyEventCommandBehaviour(UIElement.KeyDownEvent), "Command", typeof(KeyDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(KeyDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class KeyUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new KeyEventCommandBehaviour(UIElement.KeyUpEvent), "Command", typeof(KeyUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(KeyUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewKeyDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new KeyEventCommandBehaviour(UIElement.PreviewKeyDownEvent), "Command", typeof(PreviewKeyDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewKeyDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewKeyUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new KeyEventCommandBehaviour(UIElement.PreviewKeyUpEvent), "Command", typeof(PreviewKeyUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewKeyUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = 
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseDownEvent), "Command", typeof(MouseDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseEnter
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseEventCommandBehaviour(UIElement.MouseEnterEvent), "Command", typeof(MouseEnter));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseEnter));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseLeave
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseEventCommandBehaviour(UIElement.MouseLeaveEvent), "Command", typeof(MouseLeave));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseLeave));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseLeftButtonDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseLeftButtonDownEvent), "Command", typeof(MouseLeftButtonDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseLeftButtonDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseLeftButtonUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseLeftButtonUpEvent), "Command", typeof(MouseLeftButtonUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseLeftButtonUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseMove
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseEventCommandBehaviour(UIElement.MouseMoveEvent), "Command", typeof(MouseMove));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseMove));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseRightButtonDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseRightButtonDownEvent), "Command", typeof(MouseRightButtonDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseRightButtonDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseRightButtonUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseRightButtonUpEvent), "Command", typeof(MouseRightButtonUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseRightButtonUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.MouseUpEvent), "Command", typeof(MouseUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class MouseWheel
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseWheelEventCommandBehaviour(UIElement.MouseWheelEvent), "Command", typeof(MouseWheel));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(MouseWheel));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseDownEvent), "Command", typeof(PreviewMouseDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseLeftButtonDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseLeftButtonDownEvent), "Command", typeof(PreviewMouseLeftButtonDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseLeftButtonDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseLeftButtonUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseLeftButtonUpEvent), "Command", typeof(PreviewMouseLeftButtonUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseLeftButtonUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseMove
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseEventCommandBehaviour(UIElement.PreviewMouseMoveEvent), "Command", typeof(PreviewMouseMove));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseMove));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseRightButtonDown
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseRightButtonDownEvent), "Command", typeof(PreviewMouseRightButtonDown));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseRightButtonDown));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseRightButtonUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseRightButtonUpEvent), "Command", typeof(PreviewMouseRightButtonUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseRightButtonUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseUp
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseButtonEventCommandBehaviour(UIElement.PreviewMouseUpEvent), "Command", typeof(PreviewMouseUp));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseUp));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PreviewMouseWheel
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command =
            EF.CreateCommandBehaviour(new MouseWheelEventCommandBehaviour(UIElement.PreviewMouseWheelEvent), "Command", typeof(PreviewMouseWheel));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PreviewMouseWheel));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }
}
