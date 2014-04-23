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
