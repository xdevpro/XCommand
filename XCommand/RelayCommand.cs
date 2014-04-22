using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XCommand
{

    /// <summary>
    /// Josh Smith's Relay Command.  Makes WPF commanding very, very simple.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Fields

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        private List<WeakReference> ControlEvent { get; set; }

        #endregion // Fields

        #region Constructors

        /// <summary>
        /// Creates a new command that can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            ControlEvent = new List<WeakReference>();

            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion // Constructors

        #region ICommand Members

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                //CommandManager.RequerySuggested += value;
                ControlEvent.Add(new WeakReference(value));
            }
            remove
            {
                //CommandManager.RequerySuggested -= value;
                ControlEvent.Remove(ControlEvent.Find(r => ((EventHandler)r.Target) == value));
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion // ICommand Members

        /// <summary>
        /// Calls all EventHandlers that registered with CanExecuteChanged, causing an immediate re-evaluation of this commands bindings.
        /// </summary>
        /// <remarks>
        /// Must be called from the UI thread.
        /// </remarks>
        public void RequeryCanExecute()
        {
            if (ControlEvent != null && ControlEvent.Count > 0)
            {
                foreach (var ce in ControlEvent)
                {
                    if (ce.Target != null)
                        ((EventHandler)(ce.Target)).Invoke(null, EventArgs.Empty);
                }
            }
        }
    }
}
