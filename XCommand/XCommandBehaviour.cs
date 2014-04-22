using System;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace XCommand
{
    public abstract class XCommandBehaviour
    {
        private readonly RoutedEvent targetRoutedEvent;
        protected Action FinalAction;
        protected object parameter;
        protected DependencyProperty _property;
        protected DependencyProperty _propertyParm;

        protected abstract object GetHandler(RoutedEventHandler baseHandler);

        protected void HandleEvent(object sender, RoutedEventArgs e)
        {
            DependencyObject dp = sender as DependencyObject;
            if (dp == null)
            {
                return;
            }

            FinalAction += new Action(() =>
            {

                ICommand command = dp.GetValue(_property) as ICommand;

                if (command == null)
                {
                    return;
                }

                if (command.CanExecute(e))
                {
                    command.Execute(parameter);
                }
                parameter = null;
            });
        }

        protected void HandleEventParm(object sender, RoutedEventArgs e)
        {
            DependencyObject dp = sender as DependencyObject;
            if (dp == null)
            {
                return;
            }

            if (_propertyParm == null)
            {
                parameter = null;
            }
            else
            {
                parameter = dp.GetValue(_propertyParm) as object;
            }


            if (FinalAction != null)
            {
                FinalAction.Invoke();
                FinalAction = null;
            }
        }


        public XCommandBehaviour(RoutedEvent routedEvent)
        {
            targetRoutedEvent = routedEvent;
        }

        /// <summary>
        /// Listens for a change in the DependencyProperty that we are assigned to, and
        /// adjusts the EventHandlers accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PropertyChangedHandler(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // the first time the property changes,
            // make a note of which property we are supposed
            // to be watching
            if (_property == null)
            {
                _property = e.Property;
            }

            object oldValue = e.OldValue;
            object newValue = e.NewValue;

            UIElement element = sender as UIElement;
            if (element == null) { return; }

            if (oldValue != null)
            {
                element.RemoveHandler(targetRoutedEvent, GetHandler(HandleEvent));
            }

            if (newValue != null)
            {
                element.AddHandler(targetRoutedEvent, GetHandler(HandleEvent), true);
            }

            if (oldValue != null && newValue != null)
            {
                element.RemoveHandler(targetRoutedEvent, GetHandler(HandleEventParm));
            }

            if (newValue != null)
            {
                element.AddHandler(targetRoutedEvent, GetHandler(HandleEventParm), true);
            }
        }

        public void PropertyChangedHandlerParm(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            parameter = string.Empty;
            // the first time the property changes,
            // make a note of which property we are supposed
            // to be watching
            if (_propertyParm == null)
            {
                _propertyParm = e.Property;
            }

            //object oldvalue = e.oldvalue;
            //object newvalue = e.newvalue;

            //AdjustEventHandlersParm(sender, oldValue, newValue);
        }
    }


    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class PointerEventCommandBehaviour : XCommandBehaviour
    {
        public PointerEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new PointerEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class TappedEventCommandBehaviour : XCommandBehaviour
    {
        public TappedEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new TappedEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class RightTappedEventCommandBehaviour : XCommandBehaviour
    {
        public RightTappedEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new RightTappedEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class HoldingEventCommandBehaviour : XCommandBehaviour
    {
        public HoldingEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new HoldingEventHandler(baseHandler);
        }
    }


    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class KeyEventCommandBehaviour : XCommandBehaviour
    {
        public KeyEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new KeyEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class DoubleTappedEventCommandBehaviour : XCommandBehaviour
    {
        public DoubleTappedEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new DoubleTappedEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class DragEventCommandBehaviour : XCommandBehaviour
    {
        public DragEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new DragEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class RoutedEventCommandBehaviour : XCommandBehaviour
    {
        public RoutedEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new RoutedEventHandler(baseHandler);
        }
    }
}
