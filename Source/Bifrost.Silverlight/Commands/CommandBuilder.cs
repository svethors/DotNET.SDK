﻿using System;
using System.Collections;
using System.Collections.Generic;
using Bifrost.Dynamic;

namespace Bifrost.Commands
{
    /// <summary>
    /// Represents a <see cref="ICommandBuilder"/> for building commands with
    /// </summary>
    public class CommandBuilder<T> : ICommandBuilder<T> 
        where T:ICommand
    {
        ICommandCoordinator _commandCoordinator;
        ICommandBuildingConventions _conventions;

        /// <summary>
        /// Initializes a new instance of <see cref="CommandBuilder"/>
        /// </summary>
        /// <param name="commandCoordinator"><see cref="ICommandCoordinator"/> to use</param>
        public CommandBuilder(ICommandCoordinator commandCoordinator, ICommandBuildingConventions conventions)
        {
            _commandCoordinator = commandCoordinator;
            _conventions = conventions;
        }

#pragma warning disable 1591 // Xml Comments
        public T GetInstance()
        {
            ThrowIfNameIsMissing();

            if (Parameters != null)
                ThrowIfParametersAreAnonymousType();

            T command;

            var typeToCreate = typeof(T);
            if (typeToCreate == typeof(ICommand))
            {
                typeToCreate = typeof(Command);
            }

            command = (T)Activator.CreateInstance(typeToCreate);
            command.CommandCoordinator = _commandCoordinator;
            command.Name = Name;

            if (Parameters is IDictionary)
                PopulateParametersFromDictionary(command);

            if (Parameters is IDictionary<string, object>)
                PopulateParametersFromGenericDictionary(command);


            return command;
        }

        public string Name { get; set; }
        public dynamic Parameters { get; set; }
        public Type Type { get; set; } 
#pragma warning restore 1591 // Xml Comments



        void PopulateParametersFromDictionary(ICommand command)
        {
            var dictionary = Parameters as IDictionary;
            var expandoObject = command.Parameters as BindableExpandoObject;
            if (expandoObject == null)
                return;

            foreach (string key in dictionary.Keys)
                expandoObject[key] = dictionary[key];
        }

        void PopulateParametersFromGenericDictionary(ICommand command)
        {
            var dictionary = Parameters as IDictionary<string,object>;
            var expandoObject = command.Parameters as BindableExpandoObject;
            if (expandoObject == null)
                return;

            foreach (string key in dictionary.Keys)
                expandoObject[key] = dictionary[key];
        }

        void ThrowIfNameIsMissing()
        {
            if (string.IsNullOrEmpty(Name))
                throw new CommandNameMissingException();
        }

        void ThrowIfParametersAreAnonymousType()
        {
            var type = Parameters.GetType();
            if( type.Name.Contains("_Anonymous") )
                throw new UnsupportedParametersConstruct();
        }
    }
}