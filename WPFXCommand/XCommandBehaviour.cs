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
                element.RemoveHandler(targetRoutedEvent, GetHandler(HandleEvent) as Delegate);
            }

            if (newValue != null)
            {
                element.AddHandler(targetRoutedEvent, GetHandler(HandleEvent) as Delegate, true);
            }

            if (oldValue != null && newValue != null)
            {
                element.RemoveHandler(targetRoutedEvent, GetHandler(HandleEventParm) as Delegate);
            }

            if (newValue != null)
            {
                element.AddHandler(targetRoutedEvent, GetHandler(HandleEventParm) as Delegate, true);
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

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class MouseEventCommandBehaviour : XCommandBehaviour
    {
        public MouseEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new MouseEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class MouseButtonEventCommandBehaviour : XCommandBehaviour
    {
        public MouseButtonEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new MouseButtonEventHandler(baseHandler);
        }
    }

    /// <summary>
    /// Concret class that implements to get the particular target handler
    /// </summary>
    public class MouseWheelEventCommandBehaviour : XCommandBehaviour
    {
        public MouseWheelEventCommandBehaviour(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }

        protected override object GetHandler(RoutedEventHandler baseHandler)
        {
            return new MouseWheelEventHandler(baseHandler);
        }
    }
}
