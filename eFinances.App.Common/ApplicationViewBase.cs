using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.Common;

using eFinances.App.Common.EventArgs;

namespace eFinances.App.Common
{
    public abstract class ApplicationViewBase : IApplicationView
    {

        protected IApplicationController _controller = null;
        protected IApplicationModel _model = null;

        protected IApplicationView _view = null;

        public event EventHandler<ButtonClickedEventArgs> OnButtonClicked;
        public abstract IApplicationView CreateConcreteView();

        public ApplicationViewBase() { }

        public ApplicationViewBase(IApplicationController controller)
        {
            _controller = controller;
            _model = controller.Model;
            _view = CreateConcreteView();   // otherwise would be this...
            _controller.View = _view;
        }

        public IApplicationController Controller
        {
            get
            {
                return _controller;
            }
        }

        public IApplicationModel Model
        {
            get
            {
                return _model;
            }
        }

        public void Exit()
        {
            _view.Exit();
        }

        public void Start()
        {
            try
            {
                //return (object)_view;
                _view.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public object StartForm()
        //{
        //    return (object)_view;
        //}

        public object StartForm
        {
            get
            {
                return _view.StartForm;
            }
        }

        protected IApplicationView LaunchView(string viewClassName)
        {
            try
            {
                // TODO: obter o nome da class do concrete view do ficheiro de configuracao
                //string viewClassName = "eFinancesWF.frmDashboard, eFinancesWF";
                if (string.IsNullOrEmpty(viewClassName))
                    throw new ArgumentNullException("ViewClassName nao 'e valida");
                IApplicationView frm = ReflectionHelper<IApplicationView>.GetInstanceOf(viewClassName, new object[] { _controller });
                return frm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
