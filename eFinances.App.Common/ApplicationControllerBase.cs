using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common.Exceptions;

namespace eFinances.App.Common
{
    public abstract class ApplicationControllerBase : IApplicationController
    {
        private IApplicationContext _ctx = null;
        private IApplicationModel _model = null;
        private IApplicationView _view = null;

        protected ApplicationControllerBase() { }

        protected ApplicationControllerBase(IApplicationContext ctx, IApplicationModel model)
        {
            _ctx = ctx;
            _model = model;
        }

        public IApplicationModel Model
        {
            get => _model;
        }

        public IApplicationContext Context
        {
            get => _ctx;
        }

        public IApplicationView View
        {
            get => _view;
            set
            {
                _view = value;
                // write all the events...
                InitializeGlobalView();
                InitializeView();
            }
        }

        public abstract void InitializeView();

        private void InitializeGlobalView()
        {
            _view.OnButtonClicked += _view_OnButtonClicked;
        }

        private void _view_OnButtonClicked(object sender, App.Common.EventArgs.ButtonClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.ActionName))
                {
                    throw new InvalidApplicationActionException("ActionName não foi indicada");
                }
                else if (e.ActionName == "EXIT")
                {
                    //TODO: será o melhor metodo para fazer o exit?
                    _view.Exit();
                }
                else
                {
                    try
                    {
                        IModelViewControllerManager mvc = ApplicationFactory.GetInstance(Context, e.ActionName);
                        //mvc.View.Show();
                        mvc.View.Start();
                    }
                    catch (Exception)
                    {
                        throw new InvalidApplicationActionException(
                            String.Format("ActionName: {0} é inválida...", e.ActionName));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
