using System;

namespace eFinances.Common
{
    public class ReflectionHelper<T>
    {
        public static T GetInstanceOf(string className)
        {
            try
            {
                Type oType = Type.GetType(className, true, true);

                if (oType == null)
                    throw new NotImplementedException("Cannot instanciate object.");

                return (T)oType.GetConstructor(Type.EmptyTypes).Invoke(new object[] { });

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}