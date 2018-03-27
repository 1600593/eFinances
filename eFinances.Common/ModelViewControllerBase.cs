using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.Common
{
    public class ModelViewControllerBase : IModelViewControllerAdapter
    {

        IApplicationController _controller;
        IApplicationView _viewer;
        IApplicationModel _model;

        public IApplicationController Controller 
        {
            get => _controller;
            set => _controller = value;
        }

        public IApplicationModel Model {
            get => _model;
            set => _model = value;
        }

        public IApplicationView View {
            get => _viewer;
            set => _viewer = value;
        }

        public IApplicationData ExecuteAction()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}

