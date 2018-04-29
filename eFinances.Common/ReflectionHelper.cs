using System;

namespace eFinances.Common
{
    public class ReflectionHelper<T>
    {
        public static T GetInstanceOf(string className, object[] parameters)
        {

            /* TODO: explorar mais o uso dos bindingFlags para instanciar constructors, o approach usado foi apenas para resolver problemas imediados mas não é 
                tem robustez industrial e no futuro poderá trazer problemas como parametros fora da ordem estoirarem o programa. 
            */ 
            try
            {
                Type oType = Type.GetType(className, true, true);

                if (oType == null)
                    throw new NotImplementedException("Cannot instanciate object.");

                // invoca o default constructor que se espera não ter argumentos... caso contrário falha
                if ( parameters == null )
                    return (T)oType.GetConstructor(Type.EmptyTypes).Invoke(new object[] { });
                else
                { 
                    System.Reflection.ConstructorInfo[] all_constructors = oType.GetConstructors();
                    if (all_constructors != null)
                    {
                        foreach (var constructor in all_constructors)
                        {
                            System.Reflection.ParameterInfo[] all_params = constructor.GetParameters();
                            if (all_params != null || all_params.Length > 0 )
                            {
                                if ( all_params.Length == parameters.Length )
                                {
                                    return (T)constructor.Invoke(parameters);
                                }
                            }
                        }                         
                    }
                    throw new ArgumentOutOfRangeException("Nao foram encontrado constructor com o mesmo número de argumentos.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}