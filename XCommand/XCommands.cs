//*********************************************************
//
// Copyright XdevPro, Author: [Rukesh Shrestha]. All rights reserved.
// This code can be utilize freely under the name of author.
//
//*********************************************************

using System.Windows.Input;
using Windows.UI.Xaml;

//List of types named as routed event name that is exposed by UIElement
namespace XCommand
{
    public class DoubleTapped
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new DoubleTappedEventCommandBehaviour(UIElement.DoubleTappedEvent), "Command", typeof(DoubleTapped));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(DoubleTapped));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

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

    public class Holding
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new HoldingEventCommandBehaviour(UIElement.HoldingEvent), "Command", typeof(Holding));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(Holding));


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

    public class PointerCanceled
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerCanceledEvent), "Command", typeof(PointerCanceled));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerCanceled));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerCaptureLost
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerCaptureLostEvent), "Command", typeof(PointerCaptureLost));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerCaptureLost));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerEntered
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerEnteredEvent), "Command", typeof(PointerEntered));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerEntered));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerExited
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerExitedEvent), "Command", typeof(PointerExited));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerExited));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerMoved
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerMovedEvent), "Command", typeof(PointerMoved));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerMoved));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerPressed
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerPressedEvent), "Command", typeof(PointerPressed));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerPressed));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerReleased
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerReleasedEvent), "Command", typeof(PointerReleased));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerReleased));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class PointerWheelChanged
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new PointerEventCommandBehaviour(UIElement.PointerWheelChangedEvent), "Command", typeof(PointerWheelChanged));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(PointerWheelChanged));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class RightTapped
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new RightTappedEventCommandBehaviour(UIElement.RightTappedEvent), "Command", typeof(RightTapped));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }

        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(RightTapped));


        public static void SetCommandParameter(DependencyObject o, object value)
        {
            o.SetValue(CommandParameter, value);
        }

        public static object GetCommandParameter(DependencyObject o)
        {
            return o.GetValue(CommandParameter) as object;
        }
    }

    public class Tapped
    {
        private static XCommandBehaviourFactory EF = new XCommandBehaviourFactory();
        public static readonly DependencyProperty Command = EF.CreateCommandBehaviour(new TappedEventCommandBehaviour(UIElement.TappedEvent), "Command", typeof(Tapped));

        public static void SetCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(Command, value);
        }

        public static ICommand GetCommand(DependencyObject o)
        {
            return o.GetValue(Command) as ICommand;
        }


        public static readonly DependencyProperty CommandParameter =
            EF.CreateCommandParameterBehaviour("Command", "CommandParameter", typeof(Tapped));


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
