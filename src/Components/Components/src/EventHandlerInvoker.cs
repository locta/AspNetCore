// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// A bound event handler delegate.
    /// </summary>
    public readonly struct EventHandlerInvoker
    {
        public static readonly EventHandlerInvokerFactory Factory = new EventHandlerInvokerFactory();

        /// <summary>
        /// Creates the new <see cref="EventHandlerInvoker"/>.
        /// </summary>
        /// <param name="delegate">The delegate to bind.</param>
        public EventHandlerInvoker(MulticastDelegate @delegate)
        {
            Delegate = @delegate;
        }

        /// <summary>
        /// Gets the delegate assocated with this <see cref="EventHandlerInvoker"/>.
        /// </summary>
        public MulticastDelegate Delegate { get; }

        /// <summary>
        /// Invokes the delegate associated with this binding.
        /// </summary>
        /// <param name="e">The <see cref="UIEventArgs"/>.</param>
        /// <returns></returns>
        public Task Invoke(UIEventArgs e)
        {
            switch (Delegate)
            {
                case Action action:
                    action.Invoke();
                    return Task.CompletedTask;

                case Action<UIEventArgs> actionEventArgs:
                    actionEventArgs.Invoke(e);
                    return Task.CompletedTask;

                case Func<Task> func:
                    return func.Invoke();

                case Func<UIEventArgs, Task> funcEventArgs:
                    return funcEventArgs.Invoke(e);

                case MulticastDelegate @delegate:
                    return @delegate.DynamicInvoke(e) as Task ?? Task.CompletedTask;

                case null:
                    return Task.CompletedTask;
            }
        }
    }
}
