using System;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace XCommand
{
    public class XCommandBehaviourFactory
    {
        private string commandPtyName;
        private XCommandBehaviour xCmdBehaviour;
        public DependencyProperty CreateCommandBehaviour(XCommandBehaviour xCommandBehaviour, string propertyName, Type ownerType)
        {
            xCmdBehaviour = xCommandBehaviour;
            DependencyProperty property = DependencyProperty.RegisterAttached(propertyName, typeof(ICommand), ownerType,
                                                               new PropertyMetadata(null,
                                                                   xCmdBehaviour.PropertyChangedHandler));
            commandPtyName = propertyName;

            return property;
        }

        public DependencyProperty CreateCommandParameterBehaviour(string commandPropertyName, string propertyName, Type ownerType)
        {
            DependencyProperty property = null;
            if (commandPropertyName.Equals(commandPtyName))
            {
                property = DependencyProperty.RegisterAttached(propertyName, typeof(object), ownerType,
                                                                    new PropertyMetadata(null,
                                                                        xCmdBehaviour.PropertyChangedHandlerParm));
            }
            else
                throw new Exception("Do not found registered command for specific command parameter");
            return property;
        }
    }
}
