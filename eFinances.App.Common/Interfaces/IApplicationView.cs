using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common.EventArgs;

namespace eFinances.App.Common
{
    public interface IApplicationView
    {
        //void AssignController(IApplicationController controller);
        IApplicationController Controller { get; }
        IApplicationModel Model { get; }

        // TODO: usamos StartForm apenas quando é um Window App
        object StartForm { get; }

        // TODO: por convenção o Start é usado depois do main app loop ter iniciado
        void Start();

        void Exit();

        // NOTE: todos os eventos que podem ser comuns ficam aqui
        event EventHandler<ButtonClickedEventArgs> OnButtonClicked;

    }
}
