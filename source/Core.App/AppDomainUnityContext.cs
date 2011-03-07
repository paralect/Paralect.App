using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Core.App
{
    public class AppDomainUnityContext
    {
        private static Object _lock = new Object();

        private static IUnityContainer _current;

        public static IUnityContainer Current
        {
            get
            {
                IUnityContainer unity = _current;

                if (unity == null)
                {
                    lock (_lock)
                    {
                        if (unity == null)
                        {
                            unity = new UnityContainer();

                            _current = unity;
                        }
                    }
                }

                return unity;
            }
        }
    }
}
