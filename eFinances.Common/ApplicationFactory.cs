using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace eFinances.Common
{
    public static class ApplicationFactory
    {


        public static IModelViewControllerAdapter GetInstance(IApplicationContext ctx, string Action)
        {
            try
            {

                /*
                in future releases of this code we will have a class to abstract all these and simplify the code...
                */

                ModelViewControllerBase mvc = new ModelViewControllerBase();

                string mapTable;
                string strActionTableName = "Action";   // TODO: get this from config file

                DataTable tblEnv;
                DataTable tblAction;
                DataSet dsMaps;

                dsMaps = new DataSet();
                dsMaps.ReadXml("maps.xml");     // TODO: get this from config file...

                switch (ctx.Environment)
                {
                    case EnvironmentEnum.Windows:
                        mapTable = "WindowsEnvironment";
                        break;
                    case EnvironmentEnum.Web:
                        mapTable = "WebEnvironment";
                        break;
                    case EnvironmentEnum.WebMobile:
                        mapTable = "WebMobileEnvironment";
                        break;
                    case EnvironmentEnum.IOS:
                        mapTable = "IOSEnvironment";
                        break;
                    case EnvironmentEnum.Android:
                        mapTable = "AndriodEnvironment";
                        break;
                    default:
                        throw new NotImplementedException("Invalid or not implemented Application Environment.");
                }

                tblEnv = dsMaps.Tables[mapTable];

                if (tblEnv == null || tblEnv.Rows.Count == 0)
                {
                    throw new NotImplementedException("Invalid map table or no data found.");
                }

                string mfield_ID = tblEnv + "_id";
                string mfield_ID_value = tblEnv.Rows[0][mfield_ID].ToString();

                string filter = string.Format(@"[Name] = '{0}' AND [{1}] = {2}", Action, mfield_ID, mfield_ID_value);

                tblAction = dsMaps.Tables[strActionTableName];

                DataRow[] dtrResults = tblAction.Select(filter);

                if ( dtrResults.Length == 0 )
                {
                    throw new NotImplementedException("Invalid map table or MVC classes not implmented.");
                }

                string controllerClassName = dtrResults[0]["Controller"].ToString();
                string modelClassName = dtrResults[0]["Model"].ToString();
                string viewClassName = dtrResults[0]["View"].ToString();

                if (!string.IsNullOrEmpty(controllerClassName) && 
                    !string.IsNullOrEmpty(modelClassName) && 
                    !string.IsNullOrEmpty(viewClassName ) )
                {

                    mvc.Controller = ReflectionHelper<IApplicationController>.GetInstanceOf(controllerClassName);
                    mvc.Model = ReflectionHelper<IApplicationModel>.GetInstanceOf(modelClassName);
                    mvc.View = ReflectionHelper<IApplicationView>.GetInstanceOf(viewClassName);

                    // assign the dependencies
                    mvc.Controller.AssignModel(mvc.Model);
                    mvc.View.AssignController(mvc.Controller);
                   
                }
                else
                {
                    throw new Exception("Invalid map table or MVC classes not implmented.");
                }

                return mvc;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
